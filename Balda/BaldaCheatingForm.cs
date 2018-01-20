using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using log4net;

namespace Balda {
    public partial class BaldaCheatingForm : Form {
        public static readonly ILog Log = LogManager.GetLogger(typeof (BaldaCheatingForm));
        private const int PlayFieldButtonSide = 80;
        private const int PlayFieldButtonOffset = 1;
        private const int FontSize = 40;
        private int _fieldSize = 5;
        private readonly GameController _controller;

        //режим редактирования игрового поля
        public bool IsEditMode;
        public BaldaFieldButton ButtonToEdit;

        private const string EditFieldButtonTurnOn = "edit field";
        private const string EditFieldButtonTurnOff = "finish edit";

        public void RefreshPlayFieldChars() {
            _controller.PlayField = GetPlayFieldChars(_fieldSize);
        }

        /// <summary>
        /// создает массив
        /// </summary>
        /// <returns>метод возвращает массив буков-полей. Квадратный.</returns>
        private char[,] GetPlayFieldChars(int fieldSize) {
            var playFieldChars = new char[fieldSize,fieldSize];
            for (var i = 0; i < fieldSize*fieldSize; i++) {
                var b = panel1.Controls[i] as BaldaFieldButton;
                var curChar = b != null ? b.Value : ' ';
                /*  0  5 10 15 20
                 *  1  6 11 16 21
                 *  2  7 12 17 22
                 *  3  8 13 18 23
                 *  4  9 14 19 24
                 */
                var x = (int) Math.Floor((double) (i)/fieldSize);
                var y = (int) ((float) (i)%fieldSize);
                playFieldChars[x, y] = curChar;
            }
            return playFieldChars;
        }

        /// <summary>
        /// метод переносит буковки из массива на кнопочки
        /// </summary>
        /// <param name="playFieldChars"></param>
        public void SetPlayField(char[,] playFieldChars) {
            for (var x = 0; x < _fieldSize; x++) {
                for (var y = 0; y < _fieldSize; y++) {
                    var b = panel1.Controls[(x*5) + y] as BaldaFieldButton;
                    if (b == null) continue; //todo как так нулль??
                    b.Value = playFieldChars[x, y];
                }
            }
        }

        public BaldaCheatingForm() {
            Log.Debug("\tstart");
            InitializeComponent();
            const string filePath = "dic.xml";

            Parser dictionaryParser = new Parser();
            dictionaryParser.Init(filePath);
            LinkedChar wordsTree = dictionaryParser.Parse();            

            wordsDataSet.ReadXml(filePath);
            _controller = new GameController(this, wordsTree, _fieldSize);
            GenerateField(_fieldSize);
            SetPlayField(_controller.PlayField);
        }

        public void GenerateField(int columns) {
            _fieldSize = columns;

            panel1.Size = new Size(
                columns*(PlayFieldButtonSide + PlayFieldButtonOffset*2) + PlayFieldButtonOffset,
                columns*(PlayFieldButtonSide + PlayFieldButtonOffset*2) + PlayFieldButtonOffset);
            panel1.BackColor = DefaultBackColor;
            for (int x = 0; x < columns; x++) {
                for (int y = 0; y < columns; y++) {
                    var b = new BaldaFieldButton {
                                                     Size = new Size(PlayFieldButtonSide, PlayFieldButtonSide),
                                                     Location = new Point(
                                                         2 + (PlayFieldButtonSide + PlayFieldButtonOffset*2)*x,
                                                         2 + (PlayFieldButtonSide + PlayFieldButtonOffset*2)*y),
                                                     TextAlign = ContentAlignment.MiddleCenter
                                                 };
                    //Button b = new Button();

                    var f = new Font(FontFamily.GenericMonospace, FontSize, FontStyle.Bold);
                    b.Font = f;
                    b.ForeColor = defaultForeColor;
                    b.BackColor = defaultBackColor;
                    b.indexX = (x + 1);
                    b.indexY = (y + 1);
                    panel1.Controls.Add(b);
                }
            }
        }

        /*private void CreatePlayField(int columns, int rows)
        {
            
            
        }*/

        private void ButtonMakeTurnClick(object sender, EventArgs e) {
            UnlightField();
            _controller.MakeRobotTurn();
        }

        public void HighlightWord(WordVariant wordVariant) {
            UnlightField();
            foreach (Control c in panel1.Controls) {
                var b = c as BaldaFieldButton;
                if (b != null) {
                    foreach (var idx in wordVariant.Path) {
                        if (b.indexX == idx.X + 1 && b.indexY == idx.Y + 1) {
                            b.Highlight();
                            if (idx == wordVariant.EmptyCellIndex)
                                b.HighLighter();
                        }
                    }
                }
            }
        }

        public void UnlightField() {
            foreach (var b in panel1.Controls.OfType<BaldaFieldButton>()) {
                b.Unlight();
            }
        }

        public void AddWordInList(WordVariant word) {
            //textBox1.AppendText("\n" + word);
            listBox1.Items.Add(word);
        }

        private void ListBox1Click(object sender, EventArgs e) {
            var me = (MouseEventArgs) e;
            var index = listBox1.IndexFromPoint(me.Location);

            if (index == ListBox.NoMatches) return;
            var variant = (WordVariant) listBox1.Items[index];
            HighlightWord(variant);
            //MessageBox.Show(new string(variant.Chars));
        }

        private void ShowPossibleVariantsClick(object sender, EventArgs e) {
            var possibleVars = _controller.GetPossibleVariants();
            listBox1.Items.Clear();
            foreach (var possibleVar in possibleVars) {
                listBox1.Items.Add(possibleVar);
            }
        }

        private void EditFieldButtonClick(object sender, EventArgs e) {
            UnlightField();
            SwitchPlayFieldMode();
        }

        private void SwitchPlayFieldMode() {
            if (IsEditMode) {
                IsEditMode = false;
                buttonMakeTurn.Enabled = true;
                showPossibleVariants.Enabled = true;
                editFieldButton.Text = EditFieldButtonTurnOn;
            } else {
                IsEditMode = true;
                buttonMakeTurn.Enabled = false;
                showPossibleVariants.Enabled = false;
                editFieldButton.Text = EditFieldButtonTurnOff;
            }
        }

        private void ClearFieldButtonClick(object sender, EventArgs e) {
            ClearField();
        }

        private void NewGameButtonClick(object sender, EventArgs e) {
            ClearField();
            _controller.PlaceFirstWord(_controller.PlayField);
            SetPlayField(_controller.PlayField);
        }

        private void ClearField() {
            panel1.Controls.Clear();
            GenerateField(_fieldSize);
        }
    }
}