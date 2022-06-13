using System.ComponentModel;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    partial class MainForm
    {
        /// Required designer variable.
        private readonly IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._menuSectionOne = new System.Windows.Forms.MenuStrip();
            this._fileMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this._newMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this._exitMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this._helpMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this._assignNamePlayerOne = new System.Windows.Forms.Label();
            this.GameHeader = new System.Windows.Forms.Label();
            this._assignNamePlayerTwo = new System.Windows.Forms.Label();
            this._showScorePlayer1 = new System.Windows.Forms.Label();
            this._showScorePlayer2 = new System.Windows.Forms.Label();
            this._buttonOne = new System.Windows.Forms.Button();
            this._buttonTwo = new System.Windows.Forms.Button();
            this._buttonThree = new System.Windows.Forms.Button();
            this._buttonFour = new System.Windows.Forms.Button();
            this._buttonFive = new System.Windows.Forms.Button();
            this._buttonSix = new System.Windows.Forms.Button();
            this._buttonSeven = new System.Windows.Forms.Button();
            this._buttonEight = new System.Windows.Forms.Button();
            this._buttonNine = new System.Windows.Forms.Button();
            this._buttonTen = new System.Windows.Forms.Button();
            this._button11 = new System.Windows.Forms.Button();
            this._button12 = new System.Windows.Forms.Button();
            this._button13 = new System.Windows.Forms.Button();
            this._button14 = new System.Windows.Forms.Button();
            this._button15 = new System.Windows.Forms.Button();
            this._button16 = new System.Windows.Forms.Button();
            this._button17 = new System.Windows.Forms.Button();
            this._button18 = new System.Windows.Forms.Button();
            this._button19 = new System.Windows.Forms.Button();
            this._button20 = new System.Windows.Forms.Button();
            this._button21 = new System.Windows.Forms.Button();
            this._button22 = new System.Windows.Forms.Button();
            this._button23 = new System.Windows.Forms.Button();
            this._button24 = new System.Windows.Forms.Button();
            this._button25 = new System.Windows.Forms.Button();
            this._newGameButton = new System.Windows.Forms.Button();
            this._tableOne = new System.Windows.Forms.TableLayoutPanel();
            this._tableTwo = new System.Windows.Forms.TableLayoutPanel();
            this._menuSectionOne.SuspendLayout();
            this._tableOne.SuspendLayout();
            this._tableTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this._menuSectionOne.BackColor = System.Drawing.SystemColors.MenuBar;
            this._menuSectionOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenuItemSection,
            this._helpMenuItemSection});
            this._menuSectionOne.Location = new System.Drawing.Point(0, 0);
            this._menuSectionOne.Name = "_menuSectionOne";
            this._menuSectionOne.Size = new System.Drawing.Size(504, 24);
            this._menuSectionOne.TabIndex = 0;
            this._menuSectionOne.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this._fileMenuItemSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newMenuItemSection,
            this._toolStripSeparatorOne,
            this._exitMenuItemSection});
            this._fileMenuItemSection.Name = "_fileMenuItemSection";
            this._fileMenuItemSection.Size = new System.Drawing.Size(50, 20);
            this._fileMenuItemSection.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this._newMenuItemSection.Name = "_newMenuItemSection";
            this._newMenuItemSection.Size = new System.Drawing.Size(152, 22);
            this._newMenuItemSection.Text = "New...";
            this._newMenuItemSection.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparatorOne
            // 
            this._toolStripSeparatorOne.Name = "_toolStripSeparatorOne";
            this._toolStripSeparatorOne.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this._exitMenuItemSection.Name = "_exitMenuItemSection";
            this._exitMenuItemSection.Size = new System.Drawing.Size(152, 22);
            this._exitMenuItemSection.Text = "Exit";
            this._exitMenuItemSection.Click += new System.EventHandler(exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this._helpMenuItemSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutMenuItemSection});
            this._helpMenuItemSection.Name = "_helpMenuItemSection";
            this._helpMenuItemSection.Size = new System.Drawing.Size(44, 20);
            this._helpMenuItemSection.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this._aboutMenuItemSection.Name = "_aboutMenuItemSection";
            this._aboutMenuItemSection.Size = new System.Drawing.Size(152, 22);
            this._aboutMenuItemSection.Text = "About";
            this._aboutMenuItemSection.Click += new System.EventHandler(aboutToolStripMenuItem_Click);
            // 
            // labelNamePlayerOne
            // 
            this._assignNamePlayerOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._assignNamePlayerOne.AutoSize = true;
            this._assignNamePlayerOne.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this._assignNamePlayerOne.Location = new System.Drawing.Point(3, 0);
            this._assignNamePlayerOne.Name = "_assignNamePlayerOne";
            this._assignNamePlayerOne.Size = new System.Drawing.Size(114, 26);
            this._assignNamePlayerOne.TabIndex = 26;
            this._assignNamePlayerOne.Text = "Player 1";
            this._assignNamePlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            this.GameHeader.AutoSize = true;
            this.GameHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameHeader.Location = new System.Drawing.Point(192, 38);
            this.GameHeader.Name = "GameHeader";
            this.GameHeader.Size = new System.Drawing.Size(118, 30);
            this.GameHeader.TabIndex = 28;
            this.GameHeader.Text = "Tic Tac Toe";
            // 
            // labelNamePlayerTwo
            // 
            this._assignNamePlayerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._assignNamePlayerTwo.AutoSize = true;
            this._assignNamePlayerTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assignNamePlayerTwo.Location = new System.Drawing.Point(3, 0);
            this._assignNamePlayerTwo.Name = "_assignNamePlayerTwo";
            this._assignNamePlayerTwo.Size = new System.Drawing.Size(114, 26);
            this._assignNamePlayerTwo.TabIndex = 29;
            this._assignNamePlayerTwo.Text = "Player 2";
            this._assignNamePlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScorePlayerOne
            // 
            this._showScorePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._showScorePlayer1.AutoSize = true;
            this._showScorePlayer1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this._showScorePlayer1.Location = new System.Drawing.Point(3, 26);
            this._showScorePlayer1.Name = "_showScorePlayer1";
            this._showScorePlayer1.Size = new System.Drawing.Size(114, 38);
            this._showScorePlayer1.TabIndex = 30;
            this._showScorePlayer1.Text = "0";
            this._showScorePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScorePlayerTwo
            // 
            this._showScorePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._showScorePlayer2.AutoSize = true;
            this._showScorePlayer2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this._showScorePlayer2.Location = new System.Drawing.Point(3, 26);
            this._showScorePlayer2.Name = "_showScorePlayer2";
            this._showScorePlayer2.Size = new System.Drawing.Size(114, 38);
            this._showScorePlayer2.TabIndex = 31;
            this._showScorePlayer2.Text = "0";
            this._showScorePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOne
            // 
            this._buttonOne.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOne.Location = new System.Drawing.Point(15, 153);
            this._buttonOne.Name = "_buttonOne";
            this._buttonOne.Size = new System.Drawing.Size(90, 90);
            this._buttonOne.TabIndex = 32;
            this._buttonOne.UseVisualStyleBackColor = false;
            // 
            // buttonTwo
            // 
            this._buttonTwo.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonTwo.Location = new System.Drawing.Point(111, 153);
            this._buttonTwo.Name = "_buttonTwo";
            this._buttonTwo.Size = new System.Drawing.Size(90, 90);
            this._buttonTwo.TabIndex = 33;
            this._buttonTwo.UseVisualStyleBackColor = false;
            // 
            // buttonThree
            // 
            this._buttonThree.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonThree.Location = new System.Drawing.Point(207, 153);
            this._buttonThree.Name = "_buttonThree";
            this._buttonThree.Size = new System.Drawing.Size(90, 90);
            this._buttonThree.TabIndex = 34;
            this._buttonThree.UseVisualStyleBackColor = false;
            // 
            // buttonFour
            // 
            this._buttonFour.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonFour.Location = new System.Drawing.Point(303, 153);
            this._buttonFour.Name = "_buttonFour";
            this._buttonFour.Size = new System.Drawing.Size(90, 90);
            this._buttonFour.TabIndex = 35;
            this._buttonFour.UseVisualStyleBackColor = false;
            // 
            // buttonFive
            // 
            this._buttonFive.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonFive.Location = new System.Drawing.Point(399, 153);
            this._buttonFive.Name = "_buttonFive";
            this._buttonFive.Size = new System.Drawing.Size(90, 90);
            this._buttonFive.TabIndex = 36;
            this._buttonFive.UseVisualStyleBackColor = false;
            // 
            // buttonSix
            // 
            this._buttonSix.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonSix.Location = new System.Drawing.Point(15, 249);
            this._buttonSix.Name = "_buttonSix";
            this._buttonSix.Size = new System.Drawing.Size(90, 90);
            this._buttonSix.TabIndex = 37;
            this._buttonSix.UseVisualStyleBackColor = false;
            // 
            // buttonSeven
            // 
            this._buttonSeven.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonSeven.Location = new System.Drawing.Point(111, 249);
            this._buttonSeven.Name = "_buttonSeven";
            this._buttonSeven.Size = new System.Drawing.Size(90, 90);
            this._buttonSeven.TabIndex = 38;
            this._buttonSeven.UseVisualStyleBackColor = false;
            // 
            // buttonEight
            // 
            this._buttonEight.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonEight.Location = new System.Drawing.Point(207, 249);
            this._buttonEight.Name = "_buttonEight";
            this._buttonEight.Size = new System.Drawing.Size(90, 90);
            this._buttonEight.TabIndex = 39;
            this._buttonEight.UseVisualStyleBackColor = false;
            // 
            // buttonNine
            // 
            this._buttonNine.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonNine.Location = new System.Drawing.Point(303, 249);
            this._buttonNine.Name = "_buttonNine";
            this._buttonNine.Size = new System.Drawing.Size(90, 90);
            this._buttonNine.TabIndex = 40;
            this._buttonNine.UseVisualStyleBackColor = false;
            // 
            // buttonTen
            // 
            this._buttonTen.BackColor = System.Drawing.Color.Gainsboro;
            this._buttonTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonTen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._buttonTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonTen.Location = new System.Drawing.Point(399, 249);
            this._buttonTen.Name = "_buttonTen";
            this._buttonTen.Size = new System.Drawing.Size(90, 90);
            this._buttonTen.TabIndex = 41;
            this._buttonTen.UseVisualStyleBackColor = false;
            // 
            // buttonEleven
            // 
            this._button11.BackColor = System.Drawing.Color.Gainsboro;
            this._button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button11.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button11.Location = new System.Drawing.Point(15, 345);
            this._button11.Name = "_button11";
            this._button11.Size = new System.Drawing.Size(90, 90);
            this._button11.TabIndex = 42;
            this._button11.UseVisualStyleBackColor = false;
            // 
            // buttonTwelve
            // 
            this._button12.BackColor = System.Drawing.Color.Gainsboro;
            this._button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button12.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button12.Location = new System.Drawing.Point(111, 345);
            this._button12.Name = "_button12";
            this._button12.Size = new System.Drawing.Size(90, 90);
            this._button12.TabIndex = 43;
            this._button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this._button13.BackColor = System.Drawing.Color.Gainsboro;
            this._button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button13.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button13.Location = new System.Drawing.Point(207, 345);
            this._button13.Name = "_button13";
            this._button13.Size = new System.Drawing.Size(90, 90);
            this._button13.TabIndex = 44;
            this._button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this._button14.BackColor = System.Drawing.Color.Gainsboro;
            this._button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button14.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button14.Location = new System.Drawing.Point(303, 345);
            this._button14.Name = "_button14";
            this._button14.Size = new System.Drawing.Size(90, 90);
            this._button14.TabIndex = 45;
            this._button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this._button15.BackColor = System.Drawing.Color.Gainsboro;
            this._button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button15.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button15.Location = new System.Drawing.Point(399, 345);
            this._button15.Name = "_button15";
            this._button15.Size = new System.Drawing.Size(90, 90);
            this._button15.TabIndex = 46;
            this._button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this._button16.BackColor = System.Drawing.Color.Gainsboro;
            this._button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button16.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button16.Location = new System.Drawing.Point(15, 441);
            this._button16.Name = "_button16";
            this._button16.Size = new System.Drawing.Size(90, 90);
            this._button16.TabIndex = 47;
            this._button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this._button17.BackColor = System.Drawing.Color.Gainsboro;
            this._button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button17.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button17.Location = new System.Drawing.Point(111, 441);
            this._button17.Name = "_button17";
            this._button17.Size = new System.Drawing.Size(90, 90);
            this._button17.TabIndex = 48;
            this._button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this._button18.BackColor = System.Drawing.Color.Gainsboro;
            this._button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button18.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button18.Location = new System.Drawing.Point(207, 441);
            this._button18.Name = "_button18";
            this._button18.Size = new System.Drawing.Size(90, 90);
            this._button18.TabIndex = 49;
            this._button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this._button19.BackColor = System.Drawing.Color.Gainsboro;
            this._button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button19.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button19.Location = new System.Drawing.Point(303, 441);
            this._button19.Name = "_button19";
            this._button19.Size = new System.Drawing.Size(90, 90);
            this._button19.TabIndex = 50;
            this._button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this._button20.BackColor = System.Drawing.Color.Gainsboro;
            this._button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button20.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button20.Location = new System.Drawing.Point(399, 441);
            this._button20.Name = "_button20";
            this._button20.Size = new System.Drawing.Size(90, 90);
            this._button20.TabIndex = 51;
            this._button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this._button21.BackColor = System.Drawing.Color.Gainsboro;
            this._button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button21.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button21.Location = new System.Drawing.Point(15, 537);
            this._button21.Name = "_button21";
            this._button21.Size = new System.Drawing.Size(90, 90);
            this._button21.TabIndex = 52;
            this._button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this._button22.BackColor = System.Drawing.Color.Gainsboro;
            this._button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button22.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button22.Location = new System.Drawing.Point(111, 537);
            this._button22.Name = "_button22";
            this._button22.Size = new System.Drawing.Size(90, 90);
            this._button22.TabIndex = 53;
            this._button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this._button23.BackColor = System.Drawing.Color.Gainsboro;
            this._button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button23.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button23.Location = new System.Drawing.Point(207, 537);
            this._button23.Name = "_button23";
            this._button23.Size = new System.Drawing.Size(90, 90);
            this._button23.TabIndex = 54;
            this._button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this._button24.BackColor = System.Drawing.Color.Gainsboro;
            this._button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button24.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button24.Location = new System.Drawing.Point(303, 537);
            this._button24.Name = "_button24";
            this._button24.Size = new System.Drawing.Size(90, 90);
            this._button24.TabIndex = 55;
            this._button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this._button25.BackColor = System.Drawing.Color.Gainsboro;
            this._button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this._button25.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this._button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button25.Location = new System.Drawing.Point(399, 537);
            this._button25.Name = "_button25";
            this._button25.Size = new System.Drawing.Size(90, 90);
            this._button25.TabIndex = 56;
            this._button25.UseVisualStyleBackColor = false;
            // 
            // newGameButton
            // 
            this._newGameButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._newGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._newGameButton.Location = new System.Drawing.Point(165, 80);
            this._newGameButton.Name = "_newGameButton";
            this._newGameButton.Size = new System.Drawing.Size(169, 40);
            this._newGameButton.TabIndex = 57;
            this._newGameButton.Text = "New Game";
            this._newGameButton.UseVisualStyleBackColor = true;
            this._newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // table1
            // 
            this._tableOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._tableOne.ColumnCount = 1;
            this._tableOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableOne.Controls.Add(this._assignNamePlayerOne, 0, 0);
            this._tableOne.Controls.Add(this._showScorePlayer1, 0, 1);
            this._tableOne.Location = new System.Drawing.Point(15, 56);
            this._tableOne.Name = "_tableOne";
            this._tableOne.RowCount = 2;
            this._tableOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._tableOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableOne.Size = new System.Drawing.Size(120, 64);
            this._tableOne.TabIndex = 58;
            // 
            // table2
            // 
            this._tableTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._tableTwo.ColumnCount = 1;
            this._tableTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableTwo.Controls.Add(this._assignNamePlayerTwo, 0, 0);
            this._tableTwo.Controls.Add(this._showScorePlayer2, 0, 1);
            this._tableTwo.Location = new System.Drawing.Point(365, 56);
            this._tableTwo.Name = "_tableTwo";
            this._tableTwo.RowCount = 2;
            this._tableTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._tableTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableTwo.Size = new System.Drawing.Size(120, 64);
            this._tableTwo.TabIndex = 59;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 641);
            this.Controls.Add(this._tableTwo);
            this.Controls.Add(this._tableOne);
            this.Controls.Add(this._newGameButton);
            this.Controls.Add(this._button25);
            this.Controls.Add(this._button24);
            this.Controls.Add(this._button23);
            this.Controls.Add(this._button22);
            this.Controls.Add(this._button21);
            this.Controls.Add(this._button20);
            this.Controls.Add(this._button19);
            this.Controls.Add(this._button18);
            this.Controls.Add(this._button17);
            this.Controls.Add(this._button16);
            this.Controls.Add(this._button15);
            this.Controls.Add(this._button14);
            this.Controls.Add(this._button13);
            this.Controls.Add(this._button12);
            this.Controls.Add(this._button11);
            this.Controls.Add(this._buttonTen);
            this.Controls.Add(this._buttonNine);
            this.Controls.Add(this._buttonEight);
            this.Controls.Add(this._buttonSeven);
            this.Controls.Add(this._buttonSix);
            this.Controls.Add(this._buttonFive);
            this.Controls.Add(this._buttonFour);
            this.Controls.Add(this._buttonThree);
            this.Controls.Add(this._buttonTwo);
            this.Controls.Add(this._buttonOne);
            this.Controls.Add(this.GameHeader);
            this.Controls.Add(this._menuSectionOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuSectionOne;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 680);
            this.MinimumSize = new System.Drawing.Size(520, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._menuSectionOne.ResumeLayout(false);
            this._menuSectionOne.PerformLayout();
            this._tableOne.ResumeLayout(false);
            this._tableOne.PerformLayout();
            this._tableTwo.ResumeLayout(false);
            this._tableTwo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip _menuSectionOne;
        private Button _newGameButton;
        private TableLayoutPanel _tableOne;
        private TableLayoutPanel _tableTwo;
        private ToolStripSeparator _toolStripSeparatorOne;
        private ToolStripMenuItem _fileMenuItemSection;
        private ToolStripMenuItem _aboutMenuItemSection;
        private ToolStripMenuItem _helpMenuItemSection;
        private ToolStripMenuItem _exitMenuItemSection;
        private ToolStripMenuItem _newMenuItemSection;
        public Label GameHeader;
        private Label _assignNamePlayerOne;
        private Label _assignNamePlayerTwo;
        private Label _showScorePlayer1;
        private Label _showScorePlayer2;
        private Button _buttonOne;
        private Button _buttonTwo;
        private Button _buttonThree;
        private Button _buttonFour;
        private Button _buttonFive;
        private Button _buttonSix;
        private Button _buttonSeven;
        private Button _buttonEight;
        private Button _buttonNine;
        private Button _buttonTen;
        private Button _button11;
        private Button _button12;
        private Button _button13;
        private Button _button14;
        private Button _button15;
        private Button _button16;
        private Button _button17;
        private Button _button18;
        private Button _button19;
        private Button _button20;
        private Button _button21;
        private Button _button22;
        private Button _button23;
        private Button _button24;
        private Button _button25;
    }
}

