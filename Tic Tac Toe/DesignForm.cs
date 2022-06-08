using System.ComponentModel;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.menuSectionOne = new System.Windows.Forms.MenuStrip();
            this.fileMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItemSection = new System.Windows.Forms.ToolStripMenuItem();
            this.assignNamePlayerOne = new System.Windows.Forms.Label();
            this.gameHeader = new System.Windows.Forms.Label();
            this.assignNamePlayerTwo = new System.Windows.Forms.Label();
            this.showScorePlayer1 = new System.Windows.Forms.Label();
            this.showScorePlayer2 = new System.Windows.Forms.Label();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonTen = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.tableOne = new System.Windows.Forms.TableLayoutPanel();
            this.tableTwo = new System.Windows.Forms.TableLayoutPanel();
            this.menuSectionOne.SuspendLayout();
            this.tableOne.SuspendLayout();
            this.tableTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuSectionOne.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuSectionOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItemSection,
            this.helpMenuItemSection});
            this.menuSectionOne.Location = new System.Drawing.Point(0, 0);
            this.menuSectionOne.Name = "menuSectionOne";
            this.menuSectionOne.Size = new System.Drawing.Size(504, 24);
            this.menuSectionOne.TabIndex = 0;
            this.menuSectionOne.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileMenuItemSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItemSection,
            this.toolStripSeparatorOne,
            this.exitMenuItemSection});
            this.fileMenuItemSection.Name = "fileMenuItemSection";
            this.fileMenuItemSection.Size = new System.Drawing.Size(50, 20);
            this.fileMenuItemSection.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newMenuItemSection.Name = "newMenuItemSection";
            this.newMenuItemSection.Size = new System.Drawing.Size(152, 22);
            this.newMenuItemSection.Text = "New...";
            this.newMenuItemSection.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparatorOne.Name = "toolStripSeparatorOne";
            this.toolStripSeparatorOne.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitMenuItemSection.Name = "exitMenuItemSection";
            this.exitMenuItemSection.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItemSection.Text = "Exit";
            this.exitMenuItemSection.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpMenuItemSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItemSection});
            this.helpMenuItemSection.Name = "helpMenuItemSection";
            this.helpMenuItemSection.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItemSection.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutMenuItemSection.Name = "aboutMenuItemSection";
            this.aboutMenuItemSection.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItemSection.Text = "About";
            this.aboutMenuItemSection.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelNamePlayer1
            // 
            this.assignNamePlayerOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignNamePlayerOne.AutoSize = true;
            this.assignNamePlayerOne.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.assignNamePlayerOne.Location = new System.Drawing.Point(3, 0);
            this.assignNamePlayerOne.Name = "assignNamePlayerOne";
            this.assignNamePlayerOne.Size = new System.Drawing.Size(114, 26);
            this.assignNamePlayerOne.TabIndex = 26;
            this.assignNamePlayerOne.Text = "Player 1";
            this.assignNamePlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            this.gameHeader.AutoSize = true;
            this.gameHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameHeader.Location = new System.Drawing.Point(192, 38);
            this.gameHeader.Name = "gameHeader";
            this.gameHeader.Size = new System.Drawing.Size(118, 30);
            this.gameHeader.TabIndex = 28;
            this.gameHeader.Text = "Tic Tac Toe";
            // 
            // labelNamePlayer2
            // 
            this.assignNamePlayerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignNamePlayerTwo.AutoSize = true;
            this.assignNamePlayerTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignNamePlayerTwo.Location = new System.Drawing.Point(3, 0);
            this.assignNamePlayerTwo.Name = "assignNamePlayerTwo";
            this.assignNamePlayerTwo.Size = new System.Drawing.Size(114, 26);
            this.assignNamePlayerTwo.TabIndex = 29;
            this.assignNamePlayerTwo.Text = "Player 2";
            this.assignNamePlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScorePlayer1
            // 
            this.showScorePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showScorePlayer1.AutoSize = true;
            this.showScorePlayer1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.showScorePlayer1.Location = new System.Drawing.Point(3, 26);
            this.showScorePlayer1.Name = "showScorePlayer1";
            this.showScorePlayer1.Size = new System.Drawing.Size(114, 38);
            this.showScorePlayer1.TabIndex = 30;
            this.showScorePlayer1.Text = "0";
            this.showScorePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScorePlayer2
            // 
            this.showScorePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showScorePlayer2.AutoSize = true;
            this.showScorePlayer2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.showScorePlayer2.Location = new System.Drawing.Point(3, 26);
            this.showScorePlayer2.Name = "showScorePlayer2";
            this.showScorePlayer2.Size = new System.Drawing.Size(114, 38);
            this.showScorePlayer2.TabIndex = 31;
            this.showScorePlayer2.Text = "0";
            this.showScorePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.buttonOne.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(15, 153);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(90, 90);
            this.buttonOne.TabIndex = 32;
            this.buttonOne.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(111, 153);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(90, 90);
            this.buttonTwo.TabIndex = 33;
            this.buttonTwo.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.buttonThree.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(207, 153);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(90, 90);
            this.buttonThree.TabIndex = 34;
            this.buttonThree.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.buttonFour.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(303, 153);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(90, 90);
            this.buttonFour.TabIndex = 35;
            this.buttonFour.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.buttonFive.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(399, 153);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(90, 90);
            this.buttonFive.TabIndex = 36;
            this.buttonFive.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.buttonSix.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(15, 249);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(90, 90);
            this.buttonSix.TabIndex = 37;
            this.buttonSix.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(111, 249);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(90, 90);
            this.buttonSeven.TabIndex = 38;
            this.buttonSeven.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.buttonEight.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(207, 249);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(90, 90);
            this.buttonEight.TabIndex = 39;
            this.buttonEight.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.buttonNine.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(303, 249);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(90, 90);
            this.buttonNine.TabIndex = 40;
            this.buttonNine.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.buttonTen.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTen.Location = new System.Drawing.Point(399, 249);
            this.buttonTen.Name = "buttonTen";
            this.buttonTen.Size = new System.Drawing.Size(90, 90);
            this.buttonTen.TabIndex = 41;
            this.buttonTen.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(15, 345);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 90);
            this.button11.TabIndex = 42;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(111, 345);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 90);
            this.button12.TabIndex = 43;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gainsboro;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(207, 345);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 90);
            this.button13.TabIndex = 44;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gainsboro;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(303, 345);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 90);
            this.button14.TabIndex = 45;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gainsboro;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(399, 345);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 90);
            this.button15.TabIndex = 46;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(15, 441);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 90);
            this.button16.TabIndex = 47;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gainsboro;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(111, 441);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 90);
            this.button17.TabIndex = 48;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(207, 441);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 90);
            this.button18.TabIndex = 49;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gainsboro;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(303, 441);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 90);
            this.button19.TabIndex = 50;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gainsboro;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(399, 441);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(90, 90);
            this.button20.TabIndex = 51;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gainsboro;
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(15, 537);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(90, 90);
            this.button21.TabIndex = 52;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gainsboro;
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(111, 537);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(90, 90);
            this.button22.TabIndex = 53;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Gainsboro;
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(207, 537);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(90, 90);
            this.button23.TabIndex = 54;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Gainsboro;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(303, 537);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(90, 90);
            this.button24.TabIndex = 55;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Gainsboro;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(399, 537);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(90, 90);
            this.button25.TabIndex = 56;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newGameButton.Location = new System.Drawing.Point(165, 80);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(169, 40);
            this.newGameButton.TabIndex = 57;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // table1
            // 
            this.tableOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableOne.ColumnCount = 1;
            this.tableOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOne.Controls.Add(this.assignNamePlayerOne, 0, 0);
            this.tableOne.Controls.Add(this.showScorePlayer1, 0, 1);
            this.tableOne.Location = new System.Drawing.Point(15, 56);
            this.tableOne.Name = "tableOne";
            this.tableOne.RowCount = 2;
            this.tableOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOne.Size = new System.Drawing.Size(120, 64);
            this.tableOne.TabIndex = 58;
            // 
            // table2
            // 
            this.tableTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableTwo.ColumnCount = 1;
            this.tableTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTwo.Controls.Add(this.assignNamePlayerTwo, 0, 0);
            this.tableTwo.Controls.Add(this.showScorePlayer2, 0, 1);
            this.tableTwo.Location = new System.Drawing.Point(365, 56);
            this.tableTwo.Name = "tableTwo";
            this.tableTwo.RowCount = 2;
            this.tableTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTwo.Size = new System.Drawing.Size(120, 64);
            this.tableTwo.TabIndex = 59;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 641);
            this.Controls.Add(this.tableTwo);
            this.Controls.Add(this.tableOne);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.buttonTen);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.gameHeader);
            this.Controls.Add(this.menuSectionOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuSectionOne;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 680);
            this.MinimumSize = new System.Drawing.Size(520, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuSectionOne.ResumeLayout(false);
            this.menuSectionOne.PerformLayout();
            this.tableOne.ResumeLayout(false);
            this.tableOne.PerformLayout();
            this.tableTwo.ResumeLayout(false);
            this.tableTwo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuSectionOne;
        private Button newGameButton;
        private TableLayoutPanel tableOne;
        private TableLayoutPanel tableTwo;
        private ToolStripSeparator toolStripSeparatorOne;
        private ToolStripMenuItem fileMenuItemSection;
        private ToolStripMenuItem aboutMenuItemSection;
        private ToolStripMenuItem helpMenuItemSection;
        private ToolStripMenuItem exitMenuItemSection;
        private ToolStripMenuItem newMenuItemSection;
        private Label gameHeader;
        private Label assignNamePlayerOne;
        private Label assignNamePlayerTwo;
        private Label showScorePlayer1;
        private Label showScorePlayer2;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonTen;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
    }
}

