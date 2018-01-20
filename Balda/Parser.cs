using System;
using System.Linq;
using System.Xml;
using Balda.Properties;

namespace Balda {
    internal class Parser {
        private XmlReader _reader;

        private LinkedChar _wordsTreeRoot;

        public void Init(String filePath) {
            _reader = XmlReader.Create(filePath);
            _wordsTreeRoot = new LinkedChar();
        }

        /// <summary>
        /// бегу по xml'ке ридером и парсю слова в дерево
        /// </summary>
        /// <returns>корень дерева со словами</returns>
        public LinkedChar Parse()
        {
            if (_reader == null) {
                Console.WriteLine(Resources.prser_no_reader);
                return null;
            }
            while (_reader.Read()) {
                switch (_reader.NodeType) {
                    case XmlNodeType.Text:
                        ParseWord(_reader.Value);
                        break;
                }
            }
            return _wordsTreeRoot;
        }

        private void ParseWord(String word) {
            var currentLinkedChar = _wordsTreeRoot;
            for (var i = 0; i < word.Length; i++) {
                var currentChar = word[i];
                if (!currentLinkedChar.LinkedChars.Contains(currentChar)) {
                    var newLinkedChar = new LinkedChar(currentLinkedChar, currentChar);
                    ExtendLinkedChar(currentLinkedChar);
                    currentLinkedChar.LinkedChars[currentLinkedChar.LinkedChars.Length - 1] = currentChar;
                    currentLinkedChar.Next[currentLinkedChar.Next.Length - 1] = newLinkedChar;
                }
                currentLinkedChar = currentLinkedChar.Next[
                    Array.IndexOf(currentLinkedChar.LinkedChars, currentChar)
                ];

                if ((i + 1) == word.Length) {
                    currentLinkedChar.Word = word.ToCharArray();
                }
            }
        }

        private static void ExtendLinkedChar(LinkedChar lchar) {
            Array.Resize(ref lchar.Next, lchar.Next.Length + 1);
            Array.Resize(ref lchar.LinkedChars, lchar.LinkedChars.Length + 1);
        }
    }
}