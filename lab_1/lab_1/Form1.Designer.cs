using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',')
            {

            }
            else
            {
                e.Handled = true;
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.calculator = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.sexlabel = new System.Windows.Forms.Label();
            this.yourweight = new System.Windows.Forms.Label();
            this.yourheight = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.yourYearsOld = new System.Windows.Forms.Label();
            this.yearsOldTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.yourGoal = new System.Windows.Forms.Label();
            this.goalWeight = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.howDay = new System.Windows.Forms.Label();
            this.goalComboBox = new System.Windows.Forms.ComboBox();
            this.resultWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.weightTextBox.Location = new System.Drawing.Point(300, 122);
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(144, 26);
            this.weightTextBox.TabIndex = 0;
            
            weightTextBox.KeyPress += onlyNumbers;
            // 
            // calculator
            // 
            this.calculator.AutoSize = true;
            this.calculator.Cursor = System.Windows.Forms.Cursors.No;
            this.calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calculator.Location = new System.Drawing.Point(272, 9);
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(191, 20);
            this.calculator.TabIndex = 2;
            this.calculator.Text = "Калькулятор калорий";
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(254, 69);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(86, 20);
            this.man.TabIndex = 3;
            this.man.TabStop = true;
            this.man.Text = "Мужской";
            this.man.UseVisualStyleBackColor = true;
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(406, 69);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(87, 20);
            this.woman.TabIndex = 4;
            this.woman.TabStop = true;
            this.woman.Text = "Женский";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // sexlabel
            // 
            this.sexlabel.AutoSize = true;
            this.sexlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.sexlabel.Location = new System.Drawing.Point(341, 40);
            this.sexlabel.Name = "sexlabel";
            this.sexlabel.Size = new System.Drawing.Size(55, 15);
            this.sexlabel.TabIndex = 5;
            this.sexlabel.Text = "Ваш пол";
            // 
            // yourweight
            // 
            this.yourweight.AutoSize = true;
            this.yourweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.yourweight.Location = new System.Drawing.Point(342, 104);
            this.yourweight.Name = "yourweight";
            this.yourweight.Size = new System.Drawing.Size(54, 15);
            this.yourweight.TabIndex = 6;
            this.yourweight.Text = "Ваш вес";
            yourweight.KeyPress += onlyNumbers;
            // 
            // yourheight
            // 
            this.yourheight.AutoSize = true;
            this.yourheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.yourheight.Location = new System.Drawing.Point(342, 161);
            this.yourheight.Name = "yourheight";
            this.yourheight.Size = new System.Drawing.Size(61, 15);
            this.yourheight.TabIndex = 8;
            this.yourheight.Text = "Ваш рост";
            yourheight.KeyPress += onlyNumbers;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(300, 179);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(144, 22);
            this.heightTextBox.TabIndex = 7;
            
            heightTextBox.KeyPress += onlyNumbers;
            // 
            // yourYearsOld
            // 
            this.yourYearsOld.AutoSize = true;
            this.yourYearsOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.yourYearsOld.Location = new System.Drawing.Point(329, 214);
            this.yourYearsOld.Name = "yourYearsOld";
            this.yourYearsOld.Size = new System.Drawing.Size(81, 15);
            this.yourYearsOld.TabIndex = 10;
            this.yourYearsOld.Text = "Ваш возраст";
            yourYearsOld.KeyPress += onlyNumbers;
            // 
            // yearsOldTextBox
            // 
            this.yearsOldTextBox.Location = new System.Drawing.Point(300, 232);
            this.yearsOldTextBox.Name = "yearsOldTextBox";
            this.yearsOldTextBox.Size = new System.Drawing.Size(144, 22);
            this.yearsOldTextBox.TabIndex = 9;
           
            yearsOldTextBox.KeyPress += onlyNumbers;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(126, 490);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(488, 34);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // yourGoal
            // 
            this.yourGoal.AutoSize = true;
            this.yourGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.yourGoal.Location = new System.Drawing.Point(334, 270);
            this.yourGoal.Name = "yourGoal";
            this.yourGoal.Size = new System.Drawing.Size(69, 15);
            this.yourGoal.TabIndex = 12;
            this.yourGoal.Text = "Ваша цель";
            
            // 
            // goalWeight
            // 
            this.goalWeight.AutoSize = true;
            this.goalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.goalWeight.Location = new System.Drawing.Point(324, 328);
            this.goalWeight.Name = "goalWeight";
            this.goalWeight.Size = new System.Drawing.Size(94, 15);
            this.goalWeight.TabIndex = 13;
            this.goalWeight.Text = "Желаемый вес";
            goalWeight.KeyPress += onlyNumbers;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(300, 408);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(144, 22);
            this.timeTextBox.TabIndex = 15;
            timeTextBox.KeyPress += onlyNumbers;
            // 
            // howDay
            // 
            this.howDay.AutoSize = true;
            this.howDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.howDay.Location = new System.Drawing.Point(310, 388);
            this.howDay.Name = "howDay";
            this.howDay.Size = new System.Drawing.Size(117, 17);
            this.howDay.TabIndex = 16;
            this.howDay.Text = "За сколько дней";
            // 
            // goalComboBox
            // 
            this.goalComboBox.DisplayMember = "32";
            this.goalComboBox.FormattingEnabled = true;
            this.goalComboBox.Items.AddRange(new object[] {
            "Поддержание веса",
            "Снижение веса ",
            "Увеличение веса"});
            this.goalComboBox.Location = new System.Drawing.Point(300, 288);
            this.goalComboBox.Name = "goalComboBox";
            this.goalComboBox.Size = new System.Drawing.Size(144, 24);
            this.goalComboBox.TabIndex = 17;
           
            // 
            // resultWeight
            // 
            this.resultWeight.Location = new System.Drawing.Point(300, 346);
            this.resultWeight.Name = "resultWeight";
            this.resultWeight.Size = new System.Drawing.Size(144, 22);
            this.resultWeight.TabIndex = 18;
            
            resultWeight.KeyPress += onlyNumbers;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 750);
            this.Controls.Add(this.resultWeight);
            this.Controls.Add(this.goalComboBox);
            this.Controls.Add(this.howDay);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.goalWeight);
            this.Controls.Add(this.yourGoal);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.yourYearsOld);
            this.Controls.Add(this.yearsOldTextBox);
            this.Controls.Add(this.yourheight);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.yourweight);
            this.Controls.Add(this.sexlabel);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.calculator);
            this.Controls.Add(this.weightTextBox);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        #endregion

        private System.Windows.Forms.TextBox weightTextBox;
		private System.Windows.Forms.Label calculator;
		private System.Windows.Forms.RadioButton man;
		private System.Windows.Forms.RadioButton woman;
		private System.Windows.Forms.Label sexlabel;
		private System.Windows.Forms.Label yourweight;
		private System.Windows.Forms.Label yourheight;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.Label yourYearsOld;
		private System.Windows.Forms.TextBox yearsOldTextBox;
		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.Label yourGoal;
		private System.Windows.Forms.Label goalWeight;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.Label howDay;
		private System.Windows.Forms.ComboBox goalComboBox;
		private System.Windows.Forms.TextBox resultWeight;
    
    }
}