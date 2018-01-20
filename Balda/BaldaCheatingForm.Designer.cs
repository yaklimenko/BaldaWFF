using System.Drawing;

namespace Balda
{
    partial class BaldaCheatingForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMakeTurn = new System.Windows.Forms.Button();
            this.wordsDataSet = new System.Data.DataSet();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showPossibleVariants = new System.Windows.Forms.Button();
            this.editFieldButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.clearFieldButton = new System.Windows.Forms.Button();
            this.baldaCharButton25 = new BaldaCharButton();
            this.baldaCharButton28 = new BaldaCharButton();
            this.baldaCharButton29 = new BaldaCharButton();
            this.baldaCharButton30 = new BaldaCharButton();
            this.baldaCharButton31 = new BaldaCharButton();
            this.baldaCharButton32 = new BaldaCharButton();
            this.baldaCharButton33 = new BaldaCharButton();
            this.baldaCharButton34 = new BaldaCharButton();
            this.baldaCharButton35 = new BaldaCharButton();
            this.baldaCharButton36 = new BaldaCharButton();
            this.baldaCharButton13 = new BaldaCharButton();
            this.baldaCharButton14 = new BaldaCharButton();
            this.baldaCharButton15 = new BaldaCharButton();
            this.baldaCharButton16 = new BaldaCharButton();
            this.baldaCharButton17 = new BaldaCharButton();
            this.baldaCharButton18 = new BaldaCharButton();
            this.baldaCharButton19 = new BaldaCharButton();
            this.baldaCharButton20 = new BaldaCharButton();
            this.baldaCharButton21 = new BaldaCharButton();
            this.baldaCharButton22 = new BaldaCharButton();
            this.baldaCharButton23 = new BaldaCharButton();
            this.baldaCharButton24 = new BaldaCharButton();
            this.baldaCharButton9 = new BaldaCharButton();
            this.baldaCharButton10 = new BaldaCharButton();
            this.baldaCharButton11 = new BaldaCharButton();
            this.baldaCharButton12 = new BaldaCharButton();
            this.baldaCharButton5 = new BaldaCharButton();
            this.baldaCharButton6 = new BaldaCharButton();
            this.baldaCharButton7 = new BaldaCharButton();
            this.baldaCharButton8 = new BaldaCharButton();
            this.baldaCharButton4 = new BaldaCharButton();
            this.baldaCharButton3 = new BaldaCharButton();
            this.baldaCharButton2 = new BaldaCharButton();
            this.baldaCharButton1 = new BaldaCharButton();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 415);
            this.panel1.TabIndex = 0;
            // 
            // buttonMakeTurn
            // 
            this.buttonMakeTurn.Location = new System.Drawing.Point(689, 12);
            this.buttonMakeTurn.Name = "buttonMakeTurn";
            this.buttonMakeTurn.Size = new System.Drawing.Size(100, 23);
            this.buttonMakeTurn.TabIndex = 36;
            this.buttonMakeTurn.Text = "robot";
            this.buttonMakeTurn.UseVisualStyleBackColor = true;
            this.buttonMakeTurn.Click += new System.EventHandler(this.ButtonMakeTurnClick);
            // 
            // wordsDataSet
            // 
            this.wordsDataSet.DataSetName = "NewDataSet";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(580, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 290);
            this.listBox1.TabIndex = 38;
            this.listBox1.Click += new System.EventHandler(this.ListBox1Click);
            // 
            // showPossibleVariants
            // 
            this.showPossibleVariants.Location = new System.Drawing.Point(580, 247);
            this.showPossibleVariants.Name = "showPossibleVariants";
            this.showPossibleVariants.Size = new System.Drawing.Size(100, 23);
            this.showPossibleVariants.TabIndex = 39;
            this.showPossibleVariants.Text = "show vars";
            this.showPossibleVariants.UseVisualStyleBackColor = true;
            this.showPossibleVariants.Click += new System.EventHandler(this.ShowPossibleVariantsClick);
            // 
            // editFieldButton
            // 
            this.editFieldButton.Location = new System.Drawing.Point(689, 247);
            this.editFieldButton.Name = "editFieldButton";
            this.editFieldButton.Size = new System.Drawing.Size(100, 23);
            this.editFieldButton.TabIndex = 40;
            this.editFieldButton.Text = "edit field";
            this.editFieldButton.UseVisualStyleBackColor = true;
            this.editFieldButton.Click += new System.EventHandler(this.EditFieldButtonClick);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(580, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(100, 23);
            this.newGameButton.TabIndex = 75;
            this.newGameButton.Text = "new game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButtonClick);
            // 
            // clearFieldButton
            // 
            this.clearFieldButton.Location = new System.Drawing.Point(689, 218);
            this.clearFieldButton.Name = "clearFieldButton";
            this.clearFieldButton.Size = new System.Drawing.Size(99, 23);
            this.clearFieldButton.TabIndex = 76;
            this.clearFieldButton.Text = "clear field";
            this.clearFieldButton.UseVisualStyleBackColor = true;
            this.clearFieldButton.Click += new System.EventHandler(this.ClearFieldButtonClick);
            // 
            // baldaCharButton25
            // 
            this.baldaCharButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton25.Location = new System.Drawing.Point(427, 525);
            this.baldaCharButton25.Name = "baldaCharButton25";
            this.baldaCharButton25.Size = new System.Drawing.Size(131, 41);
            this.baldaCharButton25.TabIndex = 74;
            this.baldaCharButton25.Text = " ";
            this.baldaCharButton25.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton28
            // 
            this.baldaCharButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton28.Location = new System.Drawing.Point(380, 526);
            this.baldaCharButton28.Name = "baldaCharButton28";
            this.baldaCharButton28.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton28.TabIndex = 73;
            this.baldaCharButton28.Text = "я";
            this.baldaCharButton28.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton29
            // 
            this.baldaCharButton29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton29.Location = new System.Drawing.Point(334, 525);
            this.baldaCharButton29.Name = "baldaCharButton29";
            this.baldaCharButton29.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton29.TabIndex = 72;
            this.baldaCharButton29.Text = "ю";
            this.baldaCharButton29.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton30
            // 
            this.baldaCharButton30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton30.Location = new System.Drawing.Point(288, 525);
            this.baldaCharButton30.Name = "baldaCharButton30";
            this.baldaCharButton30.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton30.TabIndex = 71;
            this.baldaCharButton30.Text = "э";
            this.baldaCharButton30.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton31
            // 
            this.baldaCharButton31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton31.Location = new System.Drawing.Point(242, 525);
            this.baldaCharButton31.Name = "baldaCharButton31";
            this.baldaCharButton31.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton31.TabIndex = 70;
            this.baldaCharButton31.Text = "ь";
            this.baldaCharButton31.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton32
            // 
            this.baldaCharButton32.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton32.Location = new System.Drawing.Point(196, 525);
            this.baldaCharButton32.Name = "baldaCharButton32";
            this.baldaCharButton32.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton32.TabIndex = 69;
            this.baldaCharButton32.Text = "ы";
            this.baldaCharButton32.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton33
            // 
            this.baldaCharButton33.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton33.Location = new System.Drawing.Point(150, 526);
            this.baldaCharButton33.Name = "baldaCharButton33";
            this.baldaCharButton33.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton33.TabIndex = 68;
            this.baldaCharButton33.Text = "ъ";
            this.baldaCharButton33.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton34
            // 
            this.baldaCharButton34.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton34.Location = new System.Drawing.Point(104, 526);
            this.baldaCharButton34.Name = "baldaCharButton34";
            this.baldaCharButton34.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton34.TabIndex = 67;
            this.baldaCharButton34.Text = "щ";
            this.baldaCharButton34.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton35
            // 
            this.baldaCharButton35.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton35.Location = new System.Drawing.Point(58, 526);
            this.baldaCharButton35.Name = "baldaCharButton35";
            this.baldaCharButton35.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton35.TabIndex = 66;
            this.baldaCharButton35.Text = "ш";
            this.baldaCharButton35.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton36
            // 
            this.baldaCharButton36.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton36.Location = new System.Drawing.Point(12, 526);
            this.baldaCharButton36.Name = "baldaCharButton36";
            this.baldaCharButton36.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton36.TabIndex = 65;
            this.baldaCharButton36.Text = "ч";
            this.baldaCharButton36.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton13
            // 
            this.baldaCharButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton13.Location = new System.Drawing.Point(518, 480);
            this.baldaCharButton13.Name = "baldaCharButton13";
            this.baldaCharButton13.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton13.TabIndex = 64;
            this.baldaCharButton13.Text = "ц";
            this.baldaCharButton13.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton14
            // 
            this.baldaCharButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton14.Location = new System.Drawing.Point(472, 480);
            this.baldaCharButton14.Name = "baldaCharButton14";
            this.baldaCharButton14.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton14.TabIndex = 63;
            this.baldaCharButton14.Text = "х";
            this.baldaCharButton14.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton15
            // 
            this.baldaCharButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton15.Location = new System.Drawing.Point(426, 480);
            this.baldaCharButton15.Name = "baldaCharButton15";
            this.baldaCharButton15.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton15.TabIndex = 62;
            this.baldaCharButton15.Text = "ф";
            this.baldaCharButton15.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton16
            // 
            this.baldaCharButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton16.Location = new System.Drawing.Point(380, 480);
            this.baldaCharButton16.Name = "baldaCharButton16";
            this.baldaCharButton16.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton16.TabIndex = 61;
            this.baldaCharButton16.Text = "у";
            this.baldaCharButton16.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton17
            // 
            this.baldaCharButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton17.Location = new System.Drawing.Point(334, 479);
            this.baldaCharButton17.Name = "baldaCharButton17";
            this.baldaCharButton17.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton17.TabIndex = 60;
            this.baldaCharButton17.Text = "т";
            this.baldaCharButton17.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton18
            // 
            this.baldaCharButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton18.Location = new System.Drawing.Point(288, 479);
            this.baldaCharButton18.Name = "baldaCharButton18";
            this.baldaCharButton18.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton18.TabIndex = 59;
            this.baldaCharButton18.Text = "с";
            this.baldaCharButton18.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton19
            // 
            this.baldaCharButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton19.Location = new System.Drawing.Point(242, 479);
            this.baldaCharButton19.Name = "baldaCharButton19";
            this.baldaCharButton19.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton19.TabIndex = 58;
            this.baldaCharButton19.Text = "р";
            this.baldaCharButton19.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton20
            // 
            this.baldaCharButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton20.Location = new System.Drawing.Point(196, 479);
            this.baldaCharButton20.Name = "baldaCharButton20";
            this.baldaCharButton20.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton20.TabIndex = 57;
            this.baldaCharButton20.Text = "п";
            this.baldaCharButton20.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton21
            // 
            this.baldaCharButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton21.Location = new System.Drawing.Point(150, 480);
            this.baldaCharButton21.Name = "baldaCharButton21";
            this.baldaCharButton21.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton21.TabIndex = 56;
            this.baldaCharButton21.Text = "о";
            this.baldaCharButton21.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton22
            // 
            this.baldaCharButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton22.Location = new System.Drawing.Point(104, 480);
            this.baldaCharButton22.Name = "baldaCharButton22";
            this.baldaCharButton22.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton22.TabIndex = 55;
            this.baldaCharButton22.Text = "н";
            this.baldaCharButton22.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton23
            // 
            this.baldaCharButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton23.Location = new System.Drawing.Point(58, 480);
            this.baldaCharButton23.Name = "baldaCharButton23";
            this.baldaCharButton23.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton23.TabIndex = 54;
            this.baldaCharButton23.Text = "м";
            this.baldaCharButton23.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton24
            // 
            this.baldaCharButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton24.Location = new System.Drawing.Point(12, 480);
            this.baldaCharButton24.Name = "baldaCharButton24";
            this.baldaCharButton24.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton24.TabIndex = 53;
            this.baldaCharButton24.Text = "л";
            this.baldaCharButton24.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton9
            // 
            this.baldaCharButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton9.Location = new System.Drawing.Point(519, 434);
            this.baldaCharButton9.Name = "baldaCharButton9";
            this.baldaCharButton9.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton9.TabIndex = 52;
            this.baldaCharButton9.Text = "к";
            this.baldaCharButton9.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton10
            // 
            this.baldaCharButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton10.Location = new System.Drawing.Point(473, 434);
            this.baldaCharButton10.Name = "baldaCharButton10";
            this.baldaCharButton10.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton10.TabIndex = 51;
            this.baldaCharButton10.Text = "й";
            this.baldaCharButton10.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton11
            // 
            this.baldaCharButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton11.Location = new System.Drawing.Point(427, 434);
            this.baldaCharButton11.Name = "baldaCharButton11";
            this.baldaCharButton11.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton11.TabIndex = 50;
            this.baldaCharButton11.Text = "и";
            this.baldaCharButton11.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton12
            // 
            this.baldaCharButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton12.Location = new System.Drawing.Point(381, 434);
            this.baldaCharButton12.Name = "baldaCharButton12";
            this.baldaCharButton12.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton12.TabIndex = 49;
            this.baldaCharButton12.Text = "з";
            this.baldaCharButton12.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton5
            // 
            this.baldaCharButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton5.Location = new System.Drawing.Point(335, 433);
            this.baldaCharButton5.Name = "baldaCharButton5";
            this.baldaCharButton5.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton5.TabIndex = 48;
            this.baldaCharButton5.Text = "ж";
            this.baldaCharButton5.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton6
            // 
            this.baldaCharButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton6.Location = new System.Drawing.Point(289, 433);
            this.baldaCharButton6.Name = "baldaCharButton6";
            this.baldaCharButton6.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton6.TabIndex = 47;
            this.baldaCharButton6.Text = "ё";
            this.baldaCharButton6.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton7
            // 
            this.baldaCharButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton7.Location = new System.Drawing.Point(243, 433);
            this.baldaCharButton7.Name = "baldaCharButton7";
            this.baldaCharButton7.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton7.TabIndex = 46;
            this.baldaCharButton7.Text = "е";
            this.baldaCharButton7.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton8
            // 
            this.baldaCharButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton8.Location = new System.Drawing.Point(197, 433);
            this.baldaCharButton8.Name = "baldaCharButton8";
            this.baldaCharButton8.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton8.TabIndex = 45;
            this.baldaCharButton8.Text = "д";
            this.baldaCharButton8.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton4
            // 
            this.baldaCharButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton4.Location = new System.Drawing.Point(151, 434);
            this.baldaCharButton4.Name = "baldaCharButton4";
            this.baldaCharButton4.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton4.TabIndex = 44;
            this.baldaCharButton4.Text = "г";
            this.baldaCharButton4.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton3
            // 
            this.baldaCharButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton3.Location = new System.Drawing.Point(105, 434);
            this.baldaCharButton3.Name = "baldaCharButton3";
            this.baldaCharButton3.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton3.TabIndex = 43;
            this.baldaCharButton3.Text = "в";
            this.baldaCharButton3.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton2
            // 
            this.baldaCharButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton2.Location = new System.Drawing.Point(59, 434);
            this.baldaCharButton2.Name = "baldaCharButton2";
            this.baldaCharButton2.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton2.TabIndex = 42;
            this.baldaCharButton2.Text = "б";
            this.baldaCharButton2.UseVisualStyleBackColor = true;
            // 
            // baldaCharButton1
            // 
            this.baldaCharButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baldaCharButton1.Location = new System.Drawing.Point(13, 434);
            this.baldaCharButton1.Name = "baldaCharButton1";
            this.baldaCharButton1.Size = new System.Drawing.Size(40, 40);
            this.baldaCharButton1.TabIndex = 41;
            this.baldaCharButton1.Text = "а";
            this.baldaCharButton1.UseVisualStyleBackColor = true;
            // 
            // Balda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 574);
            this.Controls.Add(this.clearFieldButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.baldaCharButton25);
            this.Controls.Add(this.baldaCharButton28);
            this.Controls.Add(this.baldaCharButton29);
            this.Controls.Add(this.baldaCharButton30);
            this.Controls.Add(this.baldaCharButton31);
            this.Controls.Add(this.baldaCharButton32);
            this.Controls.Add(this.baldaCharButton33);
            this.Controls.Add(this.baldaCharButton34);
            this.Controls.Add(this.baldaCharButton35);
            this.Controls.Add(this.baldaCharButton36);
            this.Controls.Add(this.baldaCharButton13);
            this.Controls.Add(this.baldaCharButton14);
            this.Controls.Add(this.baldaCharButton15);
            this.Controls.Add(this.baldaCharButton16);
            this.Controls.Add(this.baldaCharButton17);
            this.Controls.Add(this.baldaCharButton18);
            this.Controls.Add(this.baldaCharButton19);
            this.Controls.Add(this.baldaCharButton20);
            this.Controls.Add(this.baldaCharButton21);
            this.Controls.Add(this.baldaCharButton22);
            this.Controls.Add(this.baldaCharButton23);
            this.Controls.Add(this.baldaCharButton24);
            this.Controls.Add(this.baldaCharButton9);
            this.Controls.Add(this.baldaCharButton10);
            this.Controls.Add(this.baldaCharButton11);
            this.Controls.Add(this.baldaCharButton12);
            this.Controls.Add(this.baldaCharButton5);
            this.Controls.Add(this.baldaCharButton6);
            this.Controls.Add(this.baldaCharButton7);
            this.Controls.Add(this.baldaCharButton8);
            this.Controls.Add(this.baldaCharButton4);
            this.Controls.Add(this.baldaCharButton3);
            this.Controls.Add(this.baldaCharButton2);
            this.Controls.Add(this.baldaCharButton1);
            this.Controls.Add(this.editFieldButton);
            this.Controls.Add(this.showPossibleVariants);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonMakeTurn);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(815, 612);
            this.Name = "Balda";
            this.Text = "Balda";
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMakeTurn;
        private System.Data.DataSet wordsDataSet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showPossibleVariants;
        private System.Windows.Forms.Button editFieldButton;
        public Color defaultForeColor = Color.Black;
        public Color HlForeColor = Color.Red;
        public Color defaultBackColor = Color.FloralWhite;
        public Color HlBackColor = Color.Yellow;
        public Color EditBackColor = Color.CornflowerBlue;
        public Color EditForeColor = Color.Coral;
        private BaldaCharButton baldaCharButton1;
        private BaldaCharButton baldaCharButton2;
        private BaldaCharButton baldaCharButton3;
        private BaldaCharButton baldaCharButton4;
        private BaldaCharButton baldaCharButton5;
        private BaldaCharButton baldaCharButton6;
        private BaldaCharButton baldaCharButton7;
        private BaldaCharButton baldaCharButton8;
        private BaldaCharButton baldaCharButton9;
        private BaldaCharButton baldaCharButton10;
        private BaldaCharButton baldaCharButton11;
        private BaldaCharButton baldaCharButton12;
        private BaldaCharButton baldaCharButton13;
        private BaldaCharButton baldaCharButton14;
        private BaldaCharButton baldaCharButton15;
        private BaldaCharButton baldaCharButton16;
        private BaldaCharButton baldaCharButton17;
        private BaldaCharButton baldaCharButton18;
        private BaldaCharButton baldaCharButton19;
        private BaldaCharButton baldaCharButton20;
        private BaldaCharButton baldaCharButton21;
        private BaldaCharButton baldaCharButton22;
        private BaldaCharButton baldaCharButton23;
        private BaldaCharButton baldaCharButton24;
        private BaldaCharButton baldaCharButton28;
        private BaldaCharButton baldaCharButton29;
        private BaldaCharButton baldaCharButton30;
        private BaldaCharButton baldaCharButton31;
        private BaldaCharButton baldaCharButton32;
        private BaldaCharButton baldaCharButton33;
        private BaldaCharButton baldaCharButton34;
        private BaldaCharButton baldaCharButton35;
        private BaldaCharButton baldaCharButton36;
        private BaldaCharButton baldaCharButton25;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button clearFieldButton;
    }
}

