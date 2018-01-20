using System;

namespace Balda
{
    /// <summary>
    /// При загрузке каждое слово записывается в структуру в виде дерева. 
    /// Каждый узел этого дерева означает конкретную букву слова и ссылается на не более чем 32 поддерева 
    /// (по количеству букв в алфавите).
    /// </summary>
    public class LinkedChar {

        /// <summary>
        /// строка со всеми буквами, которые выходят из данного узла, размер массива next[] равен длине этой строки. 
        /// Поле используется для нахождения конкретного узла среди массива узлов next[] для данной буквы
        /// </summary>
        public char[] LinkedChars;

        /// <summary>
        /// массив ссылок, выходящих из этого узла
        /// </summary>
        public LinkedChar[] Next;

        /// <summary>
        /// если не NULL, то это слово из словаря
        /// </summary>
        public char[] Word;

        /// <summary>
        /// содержит часть слова (по сути хранит буквы всех предков начиная от корня).
        /// Никогда не NULL
        /// </summary>
        public char[] WordPart;

        /// <summary>
        /// создает пустую ветку. Если ее ни в какую другу ветку не добавить, то это корень дерева
        /// </summary>
        public LinkedChar () {
            LinkedChars = new char[0];
            WordPart = new char[0];
            Next = new LinkedChar[0];
        }

        /// <summary>
        /// создает ветку
        /// </summary>
        /// <param name="parent">родитель этой ветки. Из него надо достать WordPart</param>
        /// <param name="curChar">символ, который обслуживается этой веткой</param>
        public LinkedChar (LinkedChar parent, char curChar) {
            LinkedChars = new char[0];
            Next = new LinkedChar[0];
            if (WordPart == null) {
                WordPart = new char[parent.WordPart.Length + 1];
            }
            parent.WordPart.CopyTo(WordPart, 0);
            WordPart[WordPart.Length - 1] = curChar;
        }

        // Пока не требуется.
        /**
        public LinkedChar getBranchByChars (String wordStart) {
            LinkedChar currentLinkedChar = this;
            foreach (var c in wordStart) {
                
            }
        }
        **/
    }
}
