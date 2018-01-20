using System;
using System.Collections.Generic;
using System.Linq;
using log4net;

namespace Balda {
    internal class BaldaRobot {
        public char[,] PlayField;
        //public List<string> dictionary;
        private LinkedChar wordsTree;
        public bool startAtEmptyCell = false;
        public int playFieldSize;
        public List<string> usedWords = new List<string>();

        public static readonly ILog log = LogManager.GetLogger(typeof (BaldaRobot));

        /// <summary>
        /// метод служит для поиска всех возможных вариантов на поле.
        /// </summary>
        /// <param name="playField">игровое поле</param>
        /// <param name="unusedOnly">смотреть ли на список использованных в игре слов</param>
        /// <returns>список слов в виде wordVariant</returns>
        public List<WordVariant> GetPossibleVariants(char[,] playField, bool unusedOnly) {
            PlayField = playField;
            var allVariants = new List<WordVariant>();

            for (var x = 0; x < 5; x++) {
                for (var y = 0; y < 5; y++) {
                    var idx = new CellIndex(x, y);
                    //поиск идет от любой заполненной клетки (т.е. первая буква не может быть на пустом слове)
                    if (PlayField[x, y] != ' ' || startAtEmptyCell) {
                        allVariants.AddRange(GetVariantsAt(idx, new WordVariant(wordsTree)));
                    }
                }
            }

            allVariants = RemoveDuplicates(allVariants);

            if (!unusedOnly) {
                allVariants.Sort(VariantComparer);
                return allVariants;
            }

            
            if (allVariants.Count > 0) {
                var filteredVariants = new List<WordVariant>();
                foreach (var variant in allVariants) {
                    var variantChars = new string(variant.Branch.Word);
                    foreach (var usedWord in usedWords) {
                        //find repeats in already used words
                        if (usedWord == variantChars) {
                            break;
                        }

                        //бывают одинаковые вариантыза один вызов. Тут они отсеиваются.
                        //todo чето в линк конвертнуть можно... хз
                        foreach (var notUsedVar in filteredVariants) {
                            //find repeats in filtered variants
                            var filteredWord = new string(notUsedVar.Branch.Word);
                            if (filteredWord != variantChars) continue;
                            break;
                        }
                        filteredVariants.Add(variant);
                    }
                }
                if (filteredVariants.Count > 0) {
                    filteredVariants.Sort(VariantComparer);
                }
                return filteredVariants;
            }
            return new List<WordVariant>();
        }

        private List<WordVariant> RemoveDuplicates(List<WordVariant> variantList)
        {
            var resList = new List<WordVariant>();
            foreach(var wordVarToSearch in variantList) {

                if (resList.Count > 1) {
                    var hasDbl = false;
                    foreach (var wordVarUniq in resList) {
                        if (wordVarToSearch.Word != wordVarUniq.Word) continue;
                        hasDbl = true;
                        break;
                    }
                    if (!hasDbl) {
                        resList.Add(wordVarToSearch);
                    }
                    
                } else {
                    resList.Add(wordVarToSearch);
                }
            }
            return resList;
        }

        public int VariantComparer(WordVariant x, WordVariant y) {
            if (x == null) {
                if (y == null) {
                    return 0;
                }
                return -1;
            }
            if (y == null) {
                return 1;
            }
            var retval = x.Branch.Word.Length.CompareTo(y.Branch.Word.Length);
            if (retval != 0) {
                return retval;
            }
            var xstr = new string(x.Branch.Word);
            var ystr = new string(y.Branch.Word);
            return String.Compare(xstr, ystr, StringComparison.Ordinal);
        }

        public WordVariant GetLongestWord(char[,] playfield) {
            var filteredVariants = GetPossibleVariants(playfield, true);

            if (filteredVariants.Count > 0) {
                var longestWordLength = 0;
                WordVariant longestVariant = null;
                foreach (var variant in filteredVariants) {
                    if (variant.Branch.Word.Length <= longestWordLength) continue;
                    longestWordLength = variant.Branch.Word.Length;
                    longestVariant = variant;
                }
                return longestVariant;
            }
            return null;
        }
        
        private List<WordVariant> GetVariantsAt(CellIndex startIdx, WordVariant wordStart) {
            //сюда попадают слова, которые удалось собрать по полю
            var resVariants = new List<WordVariant>();

            //TODO: optimize search variants
            if (wordStart.Branch.LinkedChars.Length == 0 && PlayField[startIdx.X, startIdx.Y] == ' ') {
                wordStart.UsedEmptyCell = true;
                wordStart.EmptyCellIndex = startIdx;
            }
            //к текущей имеющейся начальной части слова прибавляем букву, 
            //которая есть в клетке по соседству (если есть). Если рядом три непустые клетки,
            //то получится три части, которые надо проверить по словарю
            var tempVars = GetNearestVariants(startIdx, wordStart);
            if (tempVars.Count > 0) {
                foreach (var tmp in tempVars) {
                    //если после поиска вариантов есть такие, что слово полностью собралось 
                    //и была использована пустая клетка, 
                    //то в рещультирующую выборку добавляю этот вариант
                    if (tmp.UsedEmptyCell && tmp.Branch.Word != null) {
                        resVariants.Add(tmp);
                    }
                    
                    var longerVariants = GetVariantsAt(tmp.Path[tmp.Path.Length - 1], tmp);
                    foreach (var newVariant in longerVariants) {
                        var isRepeat = false;
                        var newWord = new string(newVariant.Branch.Word);
                        foreach (var existingVariant in resVariants) //look for repeats in candidates
                        {
                            var existingWord = new string(existingVariant.Branch.Word);
                            if (existingWord == newWord) {
                                isRepeat = true;
                                break;
                            }
                        }
                        if (!isRepeat) resVariants.Add(newVariant);
                    }
                }
            }
            return resVariants;
        }

        /// <summary>
        /// Метод формирует варианты из ближайших клеток к клетке, индекс которой передан в параметре startIdx, если в дереве есть подходящие ветки.
        /// Если попалась пустая клетка, то формирует варианты с любой возможной буквой (если в текуще ветке такие есть)
        /// Либо метод формирует один вариант, на клетке, с индексом startIdx
        /// </summary>
        /// <param name="startIdx"></param>
        /// <param name="wordStart"></param>
        /// <returns>список найденных вариантов</returns>
        private List<WordVariant> GetNearestVariants(CellIndex startIdx, WordVariant wordStart) {
            CellIndex[] nearestIndexes; 
            if (wordStart.Branch.WordPart.Length == 0) {
                //индекс текущей клетки. Если только начал подбирать слова и вариант пока пустой
                nearestIndexes = new CellIndex[1];
                nearestIndexes[0] = startIdx;
            } else {
                //индексы клеток справа, слева, выше и ниже от текущей клетки
                nearestIndexes = new CellIndex[4];
                nearestIndexes[0] = new CellIndex(startIdx.X + 1, startIdx.Y);
                nearestIndexes[1] = new CellIndex(startIdx.X - 1, startIdx.Y);
                nearestIndexes[2] = new CellIndex(startIdx.X, startIdx.Y + 1);
                nearestIndexes[3] = new CellIndex(startIdx.X, startIdx.Y - 1);
            }
            var nearestVariants = new List<WordVariant>();

            foreach (CellIndex idx in nearestIndexes) { //check these variants for aviability
                //check if cell is not out of playfield bounds and check if I didn't use this cell
                if (idx.X < playFieldSize && idx.Y < playFieldSize &&
                    idx.X >= 0 && idx.Y >= 0 &&
                    !CellIndex.ListHasIndex(idx, wordStart.Path)) {//todo переделать для модификации балды "узелки"
                    var c = PlayField[idx.X, idx.Y];
                    
                    if (c == ' ' && !wordStart.UsedEmptyCell) {
                        //ситуация, когда натолкнулся на пустую клетку, и могу использовать ее как "любую букву"
                        for (var i = 0; i < wordStart.Branch.LinkedChars.Length; i++) {
                            var tmp = new WordVariant(wordStart, wordStart.Branch.Next[i]) {
                                UsedEmptyCell = true, 
                                EmptyCellIndex = idx
                            };
                            tmp.ExtendPath(idx);
                            nearestVariants.Add(tmp);
                        }
                    } else if (c != ' ') {
                        //клетка непустая. Ищу подходящую ветку
                        if (wordStart.Branch.LinkedChars.Contains(c)) {
                            var pos = Array.IndexOf(wordStart.Branch.LinkedChars, c);
                            var tmp = new WordVariant(wordStart, wordStart.Branch.Next[pos]);
                            tmp.ExtendPath(idx);
                            nearestVariants.Add(tmp);
                        }
                    }
                }
            }
            return nearestVariants;
        }

        public void SetWordsTree (LinkedChar tree) {
            wordsTree = tree;
        }
    }

    public class WordVariant {
        public CellIndex[] Path;
        public CellIndex EmptyCellIndex;
        public bool UsedEmptyCell;
        public LinkedChar Branch;
        private string _word;
        public string Word {
            get {
                if (_word != null && _word.Length == Branch.Word.Length) {
                    return _word;
                }
                if (Branch.Word != null) {
                    _word = new string(Branch.Word);
                    return _word;
                } else {
                    return null;
                }
            }
        }

        /// <summary>
        /// создает новый вариант, на букву длиннее предыдущего
        /// </summary>
        /// <param name="start">предыдущий найденный вариант</param>
        /// <param name="branch">найденная для этого варианта ветка</param>
        public WordVariant(WordVariant start, LinkedChar branch) {
            //if (branch.LinkedChars.Length >= start.Branch.LinkedChars.Length) {//todo выяснить, зачем эта проверка
            UsedEmptyCell = start.UsedEmptyCell;
            //Completed = start.Completed;
            Branch = branch;
            Path = new CellIndex[start.Path.Length];
            start.Path.CopyTo(Path, 0);
            //}
        }

        /// <summary>
        /// создается пустой вариант, ветка для которого - корень дерева
        /// </summary>
        public WordVariant (LinkedChar tree) {
            Path = new CellIndex[0];
            UsedEmptyCell = false;
            Branch = tree;
        }

        public int GetEmptyCellCharPos() {
            if (UsedEmptyCell && EmptyCellIndex != null) {
                for (var i = 0; i < Path.Length; i++)
                    if (Path[i] == EmptyCellIndex) return i;
            }
            return -1;
        }
        
        public void ExtendPath (CellIndex cellIndex) {
            Array.Resize(ref Path, Path.Length + 1);
            Path[Path.Length - 1] = cellIndex;
        }

        public override string ToString() {
            return new string(Branch.WordPart);
        }

    }

    public class CellIndex {
        public int X;
        public int Y;

        public CellIndex(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public static bool ListHasIndex(CellIndex searchedIndex, CellIndex[] indexList) {
            foreach (CellIndex idx in indexList) {
                if (searchedIndex.X == idx.X && searchedIndex.Y == idx.Y)
                    return true;
            }
            return false;
        }

        public override string ToString() {
            return "x: " + X + " y: " + Y;
        }
    }
}