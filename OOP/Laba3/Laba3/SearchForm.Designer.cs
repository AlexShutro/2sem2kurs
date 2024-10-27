using System.ComponentModel;

namespace Laba2
{
    partial class SearchForm
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
            this.textBoxPublishingHouse = new System.Windows.Forms.TextBox();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.listBoxSearchBase = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPublishingHouse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegexSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYearOfPublishing = new System.Windows.Forms.Label();
            this.YearPublic = new System.Windows.Forms.Button();
            this.textBoxRangeOfPages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Diapazon = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPublishingHouse
            // 
            this.textBoxPublishingHouse.Location = new System.Drawing.Point(716, 33);
            this.textBoxPublishingHouse.Multiline = true;
            this.textBoxPublishingHouse.Name = "textBoxPublishingHouse";
            this.textBoxPublishingHouse.Size = new System.Drawing.Size(281, 308);
            this.textBoxPublishingHouse.TabIndex = 38;
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(0, 34);
            this.textBoxAuthors.Multiline = true;
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(281, 308);
            this.textBoxAuthors.TabIndex = 37;
            // 
            // listBoxSearchBase
            // 
            this.listBoxSearchBase.FormattingEnabled = true;
            this.listBoxSearchBase.HorizontalScrollbar = true;
            this.listBoxSearchBase.ItemHeight = 16;
            this.listBoxSearchBase.Location = new System.Drawing.Point(301, 33);
            this.listBoxSearchBase.Name = "listBoxSearchBase";
            this.listBoxSearchBase.Size = new System.Drawing.Size(397, 308);
            this.listBoxSearchBase.TabIndex = 36;
            this.listBoxSearchBase.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchBase_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "База";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPublishingHouse
            // 
            this.labelPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPublishingHouse.Location = new System.Drawing.Point(733, 3);
            this.labelPublishingHouse.Name = "labelPublishingHouse";
            this.labelPublishingHouse.Size = new System.Drawing.Size(268, 29);
            this.labelPublishingHouse.TabIndex = 34;
            this.labelPublishingHouse.Text = "Издательство";
            this.labelPublishingHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Список Авторов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegexSearch
            // 
            this.buttonRegexSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegexSearch.Location = new System.Drawing.Point(63, 481);
            this.buttonRegexSearch.Name = "buttonRegexSearch";
            this.buttonRegexSearch.Size = new System.Drawing.Size(217, 70);
            this.buttonRegexSearch.TabIndex = 39;
            this.buttonRegexSearch.Text = "Поиск";
            this.buttonRegexSearch.UseVisualStyleBackColor = true;
            this.buttonRegexSearch.Click += new System.EventHandler(this.buttonRegexSearch_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Рег. выражение для издания";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(65, 444);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(215, 22);
            this.textBoxRegex.TabIndex = 42;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(392, 444);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(215, 22);
            this.textBoxYear.TabIndex = 45;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelYearOfPublishing
            // 
            this.labelYearOfPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearOfPublishing.Location = new System.Drawing.Point(339, 412);
            this.labelYearOfPublishing.Name = "labelYearOfPublishing";
            this.labelYearOfPublishing.Size = new System.Drawing.Size(323, 29);
            this.labelYearOfPublishing.TabIndex = 44;
            this.labelYearOfPublishing.Text = "Год Издания";
            this.labelYearOfPublishing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearPublic
            // 
            this.YearPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearPublic.Location = new System.Drawing.Point(390, 481);
            this.YearPublic.Name = "YearPublic";
            this.YearPublic.Size = new System.Drawing.Size(217, 70);
            this.YearPublic.TabIndex = 43;
            this.YearPublic.Text = "Поиск";
            this.YearPublic.UseVisualStyleBackColor = true;
            this.YearPublic.Click += new System.EventHandler(this.YearPublic_Click);
            // 
            // textBoxRangeOfPages
            // 
            this.textBoxRangeOfPages.Location = new System.Drawing.Point(735, 444);
            this.textBoxRangeOfPages.Name = "textBoxRangeOfPages";
            this.textBoxRangeOfPages.Size = new System.Drawing.Size(215, 22);
            this.textBoxRangeOfPages.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(682, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Диапазон страниц(прим. 0-10)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Diapazon
            // 
            this.Diapazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diapazon.Location = new System.Drawing.Point(733, 481);
            this.Diapazon.Name = "Diapazon";
            this.Diapazon.Size = new System.Drawing.Size(217, 70);
            this.Diapazon.TabIndex = 46;
            this.Diapazon.Text = "Поиск";
            this.Diapazon.UseVisualStyleBackColor = true;
            this.Diapazon.Click += new System.EventHandler(this.Diapazon_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(390, 614);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(217, 70);
            this.ButtonSave.TabIndex = 49;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 725);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxRangeOfPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Diapazon);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYearOfPublishing);
            this.Controls.Add(this.YearPublic);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegexSearch);
            this.Controls.Add(this.textBoxPublishingHouse);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.listBoxSearchBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPublishingHouse);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button ButtonSave;

        private System.Windows.Forms.TextBox textBoxRangeOfPages;

        private System.Windows.Forms.TextBox textBoxYear;

        private System.Windows.Forms.ListBox listBoxSearchBase;

        private System.Windows.Forms.Button buttonRegexSearch;
        private System.Windows.Forms.TextBox textBoxRegex;

        private System.Windows.Forms.Label labelYearOfPublishing;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button YearPublic;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Diapazon;

        private System.Windows.Forms.TextBox textBoxSize;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.TextBox textBoxPublishingHouse;
        private System.Windows.Forms.TextBox textBoxAuthors;
        private System.Windows.Forms.ListBox listBoxBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPublishingHouse;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}