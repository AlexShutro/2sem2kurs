using System.ComponentModel;

namespace Laba2
{
    partial class PublishingHouseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonOwnershipType_Private = new System.Windows.Forms.RadioButton();
            this.radioButtonOwnershipType_State = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDateOfFoundation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(40, 207);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(264, 22);
            this.textBoxCity.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(48, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Введите город\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(40, 131);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(264, 22);
            this.textBoxCountry.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Введите страну";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 22);
            this.textBox2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Введите кол-во страниц (мб)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(40, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 22);
            this.textBoxName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Введите название издательства\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(40, 387);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(264, 70);
            this.buttonConfirm.TabIndex = 37;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Введите дату основания\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Выберите тип издательства\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonOwnershipType_Private
            // 
            this.radioButtonOwnershipType_Private.Location = new System.Drawing.Point(40, 343);
            this.radioButtonOwnershipType_Private.Name = "radioButtonOwnershipType_Private";
            this.radioButtonOwnershipType_Private.Size = new System.Drawing.Size(93, 19);
            this.radioButtonOwnershipType_Private.TabIndex = 41;
            this.radioButtonOwnershipType_Private.TabStop = true;
            this.radioButtonOwnershipType_Private.Text = "Частный\r\n";
            this.radioButtonOwnershipType_Private.UseVisualStyleBackColor = true;
            // 
            // radioButtonOwnershipType_State
            // 
            this.radioButtonOwnershipType_State.Location = new System.Drawing.Point(139, 343);
            this.radioButtonOwnershipType_State.Name = "radioButtonOwnershipType_State";
            this.radioButtonOwnershipType_State.Size = new System.Drawing.Size(165, 19);
            this.radioButtonOwnershipType_State.TabIndex = 42;
            this.radioButtonOwnershipType_State.TabStop = true;
            this.radioButtonOwnershipType_State.Text = "Государственный\r\n";
            this.radioButtonOwnershipType_State.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOfFoundation
            // 
            this.dateTimePickerDateOfFoundation.Location = new System.Drawing.Point(40, 278);
            this.dateTimePickerDateOfFoundation.Name = "dateTimePickerDateOfFoundation";
            this.dateTimePickerDateOfFoundation.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerDateOfFoundation.TabIndex = 43;
            this.dateTimePickerDateOfFoundation.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfFoundation_ValueChanged);
            // 
            // PublishingHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 469);
            this.Controls.Add(this.dateTimePickerDateOfFoundation);
            this.Controls.Add(this.radioButtonOwnershipType_State);
            this.Controls.Add(this.radioButtonOwnershipType_Private);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label8);
            this.Name = "PublishingHouseForm";
            this.Text = "PublishingHouseForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.PublishingHouseForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxName;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonOwnershipType_Private;
        private System.Windows.Forms.RadioButton radioButtonOwnershipType_State;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfFoundation;

        private System.Windows.Forms.Button buttonConfirm;

       
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
      

      
        private System.Windows.Forms.Label label1;

        #endregion
    }
}