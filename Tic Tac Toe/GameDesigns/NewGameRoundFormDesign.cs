using System.ComponentModel;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    partial class NewGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameForm));
            this._labelNamePlayerOne = new System.Windows.Forms.Label();
            this._namePlayerOne = new System.Windows.Forms.TextBox();
            this._labelPlayerOne = new System.Windows.Forms.Label();
            this._newGameButton = new System.Windows.Forms.Button();
            this._labelNamePlayerTwo = new System.Windows.Forms.Label();
            this._namePlayerTwo = new System.Windows.Forms.TextBox();
            this._computerCheckbox = new System.Windows.Forms.CheckBox();
            this._buttonMarkPlayerTwo = new System.Windows.Forms.Button();
            this._labelPlayerTwo = new System.Windows.Forms.Label();
            this._buttonMarkPlayerOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNamePlayer1
            // 
            this._labelNamePlayerOne.AutoSize = true;
            this._labelNamePlayerOne.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._labelNamePlayerOne.Location = new System.Drawing.Point(57, 20);
            this._labelNamePlayerOne.Name = "_labelNamePlayerOne";
            this._labelNamePlayerOne.Size = new System.Drawing.Size(66, 21);
            this._labelNamePlayerOne.TabIndex = 0;
            this._labelNamePlayerOne.Text = "Player 1";
            // 
            // namePlayer1
            // 
            this._namePlayerOne.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._namePlayerOne.Location = new System.Drawing.Point(12, 53);
            this._namePlayerOne.Name = "_namePlayerOne";
            this._namePlayerOne.Size = new System.Drawing.Size(160, 29);
            this._namePlayerOne.TabIndex = 1;
            // 
            // labelPlayer1
            // 
            this._labelPlayerOne.AutoSize = true;
            this._labelPlayerOne.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._labelPlayerOne.Location = new System.Drawing.Point(67, 125);
            this._labelPlayerOne.Name = "_labelPlayerOne";
            this._labelPlayerOne.Size = new System.Drawing.Size(47, 21);
            this._labelPlayerOne.TabIndex = 2;
            this._labelPlayerOne.Text = "Label";
            // 
            // newGameButton
            // 
            this._newGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this._newGameButton.Location = new System.Drawing.Point(12, 303);
            this._newGameButton.Name = "_newGameButton";
            this._newGameButton.Size = new System.Drawing.Size(360, 46);
            this._newGameButton.TabIndex = 9;
            this._newGameButton.Text = "Start new game";
            this._newGameButton.UseVisualStyleBackColor = true;
            this._newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // labelNamePlayer2
            // 
            this._labelNamePlayerTwo.AutoSize = true;
            this._labelNamePlayerTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNamePlayerTwo.Location = new System.Drawing.Point(261, 20);
            this._labelNamePlayerTwo.Name = "_labelNamePlayerTwo";
            this._labelNamePlayerTwo.Size = new System.Drawing.Size(66, 21);
            this._labelNamePlayerTwo.TabIndex = 4;
            this._labelNamePlayerTwo.Text = "Player 2";
            // 
            // namePlayer2
            // 
            this._namePlayerTwo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._namePlayerTwo.Location = new System.Drawing.Point(212, 53);
            this._namePlayerTwo.Name = "_namePlayerTwo";
            this._namePlayerTwo.Size = new System.Drawing.Size(160, 29);
            this._namePlayerTwo.TabIndex = 5;
            // 
            // computerCheckbox
            // 
            this._computerCheckbox.AutoSize = true;
            this._computerCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._computerCheckbox.Location = new System.Drawing.Point(232, 247);
            this._computerCheckbox.Name = "_computerCheckbox";
            this._computerCheckbox.Size = new System.Drawing.Size(131, 23);
            this._computerCheckbox.TabIndex = 8;
            this._computerCheckbox.Text = "Computer Player";
            this._computerCheckbox.UseVisualStyleBackColor = true;
            // 
            // buttonMarkPlayer2
            // 
            this._buttonMarkPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this._buttonMarkPlayerTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buttonMarkPlayerTwo.Location = new System.Drawing.Point(250, 151);
            this._buttonMarkPlayerTwo.Name = "_buttonMarkPlayerTwo";
            this._buttonMarkPlayerTwo.Size = new System.Drawing.Size(90, 90);
            this._buttonMarkPlayerTwo.TabIndex = 7;
            this._buttonMarkPlayerTwo.UseVisualStyleBackColor = true;
            this._buttonMarkPlayerTwo.Click += new System.EventHandler(this.buttonMarkPlayer2_Click);
            // 
            // labelPlayer2
            // 
            this._labelPlayerTwo.AutoSize = true;
            this._labelPlayerTwo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._labelPlayerTwo.Location = new System.Drawing.Point(270, 125);
            this._labelPlayerTwo.Name = "_labelPlayerTwo";
            this._labelPlayerTwo.Size = new System.Drawing.Size(47, 21);
            this._labelPlayerTwo.TabIndex = 6;
            this._labelPlayerTwo.Text = "Label";
            // 
            // buttonMarkPlayer1
            // 
            this._buttonMarkPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this._buttonMarkPlayerOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buttonMarkPlayerOne.Location = new System.Drawing.Point(48, 151);
            this._buttonMarkPlayerOne.Name = "_buttonMarkPlayerOne";
            this._buttonMarkPlayerOne.Size = new System.Drawing.Size(90, 90);
            this._buttonMarkPlayerOne.TabIndex = 3;
            this._buttonMarkPlayerOne.UseVisualStyleBackColor = true;
            this._buttonMarkPlayerOne.Click += new System.EventHandler(this.buttonMarkPlayer1_Click);
            // 
            // NewGameForm
            // 
            this.AcceptButton = this._newGameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this._labelNamePlayerOne);
            this.Controls.Add(this._labelNamePlayerTwo);
            this.Controls.Add(this._namePlayerOne);
            this.Controls.Add(this._namePlayerTwo);
            this.Controls.Add(this._newGameButton);
            this.Controls.Add(this._labelPlayerOne);
            this.Controls.Add(this._labelPlayerTwo);
            this.Controls.Add(this._buttonMarkPlayerOne);
            this.Controls.Add(this._buttonMarkPlayerTwo);
            this.Controls.Add(this._computerCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelNamePlayerOne;
        private TextBox _namePlayerOne;
        private Label _labelPlayerOne;
        private Button _newGameButton;
        private Label _labelNamePlayerTwo;
        private TextBox _namePlayerTwo;
        private CheckBox _computerCheckbox;
        private Button _buttonMarkPlayerTwo;
        private Label _labelPlayerTwo;
        private Button _buttonMarkPlayerOne;
    }
}