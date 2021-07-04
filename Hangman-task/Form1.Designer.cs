
namespace Hangman_task
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.mainBox = new System.Windows.Forms.Label();
            this.show_mainBox = new System.Windows.Forms.Button();
            this.lifePointsLbl = new System.Windows.Forms.Label();
            this.userCharacterInput = new System.Windows.Forms.TextBox();
            this.characterLbl = new System.Windows.Forms.Label();
            this.checkCharacterBtn = new System.Windows.Forms.Button();
            this.capitalLbl = new System.Windows.Forms.Label();
            this.userWordInput = new System.Windows.Forms.TextBox();
            this.checkWordBtn = new System.Windows.Forms.Button();
            this.notInWordLbl = new System.Windows.Forms.Label();
            this.notInWordList = new System.Windows.Forms.ListBox();
            this.hintLbl = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(314, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(288, 69);
            this.title.TabIndex = 3;
            this.title.Text = "Hangman";
            // 
            // mainBox
            // 
            this.mainBox.AutoSize = true;
            this.mainBox.Font = new System.Drawing.Font("MingLiU", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainBox.Location = new System.Drawing.Point(54, 153);
            this.mainBox.MinimumSize = new System.Drawing.Size(800, 0);
            this.mainBox.Name = "mainBox";
            this.mainBox.Padding = new System.Windows.Forms.Padding(20);
            this.mainBox.Size = new System.Drawing.Size(800, 140);
            this.mainBox.TabIndex = 6;
            this.mainBox.Text = "mainBox";
            this.mainBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBox.Visible = false;
            // 
            // show_mainBox
            // 
            this.show_mainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show_mainBox.Location = new System.Drawing.Point(410, 459);
            this.show_mainBox.Name = "show_mainBox";
            this.show_mainBox.Size = new System.Drawing.Size(109, 42);
            this.show_mainBox.TabIndex = 7;
            this.show_mainBox.Text = "Start";
            this.show_mainBox.UseVisualStyleBackColor = true;
            this.show_mainBox.Click += new System.EventHandler(this.show_mainBox_Click);
            // 
            // lifePointsLbl
            // 
            this.lifePointsLbl.AutoSize = true;
            this.lifePointsLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lifePointsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lifePointsLbl.Location = new System.Drawing.Point(882, 28);
            this.lifePointsLbl.Name = "lifePointsLbl";
            this.lifePointsLbl.Padding = new System.Windows.Forms.Padding(10);
            this.lifePointsLbl.Size = new System.Drawing.Size(205, 56);
            this.lifePointsLbl.TabIndex = 8;
            this.lifePointsLbl.Text = "Life points: 5";
            this.lifePointsLbl.Visible = false;
            // 
            // userCharacterInput
            // 
            this.userCharacterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userCharacterInput.Location = new System.Drawing.Point(705, 390);
            this.userCharacterInput.MaxLength = 1;
            this.userCharacterInput.Name = "userCharacterInput";
            this.userCharacterInput.Size = new System.Drawing.Size(76, 41);
            this.userCharacterInput.TabIndex = 9;
            this.userCharacterInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userCharacterInput.Visible = false;
            // 
            // characterLbl
            // 
            this.characterLbl.AutoSize = true;
            this.characterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterLbl.Location = new System.Drawing.Point(641, 333);
            this.characterLbl.Name = "characterLbl";
            this.characterLbl.Size = new System.Drawing.Size(213, 36);
            this.characterLbl.TabIndex = 10;
            this.characterLbl.Text = "Input character";
            this.characterLbl.Visible = false;
            // 
            // checkCharacterBtn
            // 
            this.checkCharacterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkCharacterBtn.Location = new System.Drawing.Point(678, 459);
            this.checkCharacterBtn.Name = "checkCharacterBtn";
            this.checkCharacterBtn.Size = new System.Drawing.Size(129, 42);
            this.checkCharacterBtn.TabIndex = 11;
            this.checkCharacterBtn.Text = "Check";
            this.checkCharacterBtn.UseVisualStyleBackColor = true;
            this.checkCharacterBtn.Visible = false;
            this.checkCharacterBtn.Click += new System.EventHandler(this.checkCharacterBtn_Click);
            // 
            // capitalLbl
            // 
            this.capitalLbl.AutoSize = true;
            this.capitalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.capitalLbl.Location = new System.Drawing.Point(33, 333);
            this.capitalLbl.Name = "capitalLbl";
            this.capitalLbl.Size = new System.Drawing.Size(243, 36);
            this.capitalLbl.TabIndex = 12;
            this.capitalLbl.Text = "Input whole word";
            this.capitalLbl.Visible = false;
            // 
            // userWordInput
            // 
            this.userWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userWordInput.Location = new System.Drawing.Point(27, 390);
            this.userWordInput.MaxLength = 20;
            this.userWordInput.Name = "userWordInput";
            this.userWordInput.Size = new System.Drawing.Size(261, 41);
            this.userWordInput.TabIndex = 13;
            this.userWordInput.Visible = false;
            // 
            // checkWordBtn
            // 
            this.checkWordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkWordBtn.Location = new System.Drawing.Point(80, 459);
            this.checkWordBtn.Name = "checkWordBtn";
            this.checkWordBtn.Size = new System.Drawing.Size(128, 42);
            this.checkWordBtn.TabIndex = 14;
            this.checkWordBtn.Text = "Check";
            this.checkWordBtn.UseVisualStyleBackColor = true;
            this.checkWordBtn.Visible = false;
            this.checkWordBtn.Click += new System.EventHandler(this.checkWordBtn_Click);
            // 
            // notInWordLbl
            // 
            this.notInWordLbl.AutoSize = true;
            this.notInWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notInWordLbl.Location = new System.Drawing.Point(916, 119);
            this.notInWordLbl.Name = "notInWordLbl";
            this.notInWordLbl.Size = new System.Drawing.Size(140, 29);
            this.notInWordLbl.TabIndex = 15;
            this.notInWordLbl.Text = "Not-in-word";
            this.notInWordLbl.Visible = false;
            // 
            // notInWordList
            // 
            this.notInWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notInWordList.FormattingEnabled = true;
            this.notInWordList.ItemHeight = 58;
            this.notInWordList.Location = new System.Drawing.Point(933, 165);
            this.notInWordList.Name = "notInWordList";
            this.notInWordList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notInWordList.Size = new System.Drawing.Size(97, 352);
            this.notInWordList.TabIndex = 16;
            this.notInWordList.Visible = false;
            // 
            // hintLbl
            // 
            this.hintLbl.AutoSize = true;
            this.hintLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hintLbl.Location = new System.Drawing.Point(75, 109);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(55, 29);
            this.hintLbl.TabIndex = 17;
            this.hintLbl.Text = "Hint";
            this.hintLbl.Visible = false;
            // 
            // userNameInput
            // 
            this.userNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNameInput.Location = new System.Drawing.Point(355, 336);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(238, 35);
            this.userNameInput.TabIndex = 19;
            this.userNameInput.Text = "Enter your name";
            this.userNameInput.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.Location = new System.Drawing.Point(400, 390);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 50);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 547);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.hintLbl);
            this.Controls.Add(this.notInWordList);
            this.Controls.Add(this.notInWordLbl);
            this.Controls.Add(this.checkWordBtn);
            this.Controls.Add(this.userWordInput);
            this.Controls.Add(this.capitalLbl);
            this.Controls.Add(this.checkCharacterBtn);
            this.Controls.Add(this.characterLbl);
            this.Controls.Add(this.userCharacterInput);
            this.Controls.Add(this.lifePointsLbl);
            this.Controls.Add(this.show_mainBox);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.title);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label mainBox;
        private System.Windows.Forms.Button show_mainBox;
        private System.Windows.Forms.Label lifePointsLbl;
        private System.Windows.Forms.TextBox userCharacterInput;
        private System.Windows.Forms.Label characterLbl;
        private System.Windows.Forms.Button checkCharacterBtn;
        private System.Windows.Forms.Label capitalLbl;
        private System.Windows.Forms.TextBox userWordInput;
        private System.Windows.Forms.Button checkWordBtn;
        private System.Windows.Forms.Label notInWordLbl;
        private System.Windows.Forms.ListBox notInWordList;
        private System.Windows.Forms.Label hintLbl;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Button saveBtn;
    }
}

