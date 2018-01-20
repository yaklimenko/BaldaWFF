using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Balda {
    internal class GameController {
        private char[,] _playField;
        public char[,] PlayField {
            get { return _playField; }
            set {
                _playField = value;
            }
        }
        private int fieldSize = 5;
        private BaldaRobot robot;
        private BaldaCheatingForm mainForm;
        private LinkedChar wordsTree;

        public GameController(BaldaCheatingForm mainForm, LinkedChar wordsTree, int fieldSize) {
            this.wordsTree = wordsTree;
            this.mainForm = mainForm;
            this.fieldSize = fieldSize;
            PlayField = new char[this.fieldSize, this.fieldSize];
            FormatField(PlayField);
            var firstWord = PlaceFirstWord(PlayField);
            InitSearchRobot(robot);
            robot.usedWords.Add(firstWord);
        }

        /// <summary>
        /// Робот делает ход.
        /// </summary>
        public void MakeRobotTurn() {
            //todo refactor робота выделить в отдельный класс
            mainForm.UnlightField();
            var coolWord = robot.GetLongestWord(PlayField);
            if (coolWord == null || coolWord.Branch.Word.Length == 0) return;

            var coolWordStr = new string(coolWord.Branch.Word);
            robot.usedWords.Add(coolWordStr);
            PlayField[coolWord.EmptyCellIndex.X, coolWord.EmptyCellIndex.Y] =
                coolWord.Branch.Word[coolWord.GetEmptyCellCharPos()];
            robot.PlayField = PlayField;
            mainForm.SetPlayField(PlayField);
            mainForm.HighlightWord(coolWord);
            //mainForm.AddWordInList(new string(coolWord.Chars));
            mainForm.AddWordInList(coolWord);
        }

        public List<WordVariant> GetPossibleVariants() {
            mainForm.UnlightField();
            return robot.GetPossibleVariants(PlayField, false);
        }

        private void InitSearchRobot(BaldaRobot robot) {
            robot = new BaldaRobot();
            robot.PlayField = PlayField;
            robot.SetWordsTree(wordsTree);
            robot.playFieldSize = fieldSize;
            robot.startAtEmptyCell = true;
            this.robot = robot;
        }

        private void FormatField(char[,] field) {
            for (int x = 0; x < 5; x++) {
                for (int y = 0; y < 5; y++) {
                    field[x, y] = ' ';
                }
            }
        }
        
        /// <summary>
        /// помещает первое слово на поле.
        /// </summary>
        /// <param name="field">игровое поле</param>
        /// <returns>слово, которое было помещено на поле</returns>
        public string PlaceFirstWord(char[,] field) {
            if (wordsTree == null) {
                return null;
            }
            var suitableWordChars = new char[fieldSize];
            var neededLengthWords = GetAllWordsAtLevel(fieldSize, wordsTree);
            if (neededLengthWords == null || neededLengthWords.Count == 0) {
                return null;
            }
            var rnd = new Random();
            var choice = rnd.Next(neededLengthWords.Count);
            neededLengthWords[choice].Word.CopyTo(suitableWordChars, 0);
            var word = new string(suitableWordChars);
            for (var i = 0; i < fieldSize; i++) {
                field[i, (int)Math.Floor((double)fieldSize / 2d)] = word[i];
            }
            return word;
        }

        /// <summary>
        /// Метод рекурсивно ищет в дереве слова нужной длины.
        /// </summary>
        /// <param name="targetLevel">длина слова - оно же уровень дерева</param>
        /// <param name="branch">текущая ветка дерева</param>
        /// <param name="curLevel">текущая длина слова - она же уровень дерева</param>
        /// <returns>список листьев дерева со словами нужной длины. Весь возможный</returns>
        private static List<LinkedChar> GetAllWordsAtLevel(int targetLevel, LinkedChar branch, int curLevel = 0) {
            var resWords = new List<LinkedChar>();
            var timeToAddResults = targetLevel - curLevel != 1;
            foreach (var nextBranch in branch.Next) {
                if (timeToAddResults) {
                    resWords.AddRange(GetAllWordsAtLevel(targetLevel, nextBranch, curLevel + 1));
                } else {
                    if (nextBranch.Word != null) {
                        resWords.Add(nextBranch);
                    }
                }
                
            }
            return resWords;
        }
    }
}