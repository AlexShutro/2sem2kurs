namespace Laba2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.RadioButton radioButtonFormatHTML;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelPublishingHouse = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonFormatPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatEPUB = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatTXT = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatFB2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUDC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumberOfPages = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxBase = new System.Windows.Forms.ListBox();
            this.PublishingHouse = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Button();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.textBoxPublishingHouse = new System.Windows.Forms.TextBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.poiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirovkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataZagruzkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eventLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.SortitTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            radioButtonFormatHTML = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonFormatHTML
            // 
            radioButtonFormatHTML.Location = new System.Drawing.Point(26, 525);
            radioButtonFormatHTML.Name = "radioButtonFormatHTML";
            radioButtonFormatHTML.Size = new System.Drawing.Size(115, 22);
            radioButtonFormatHTML.TabIndex = 8;
            radioButtonFormatHTML.TabStop = true;
            radioButtonFormatHTML.Text = "HTML";
            radioButtonFormatHTML.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список Авторов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPublishingHouse
            // 
            this.labelPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPublishingHouse.Location = new System.Drawing.Point(733, 50);
            this.labelPublishingHouse.Name = "labelPublishingHouse";
            this.labelPublishingHouse.Size = new System.Drawing.Size(268, 29);
            this.labelPublishingHouse.TabIndex = 5;
            this.labelPublishingHouse.Text = "Издательство";
            this.labelPublishingHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(394, 407);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(217, 70);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить в Базу";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonFormatPDF
            // 
            this.radioButtonFormatPDF.Location = new System.Drawing.Point(26, 563);
            this.radioButtonFormatPDF.Name = "radioButtonFormatPDF";
            this.radioButtonFormatPDF.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatPDF.TabIndex = 9;
            this.radioButtonFormatPDF.TabStop = true;
            this.radioButtonFormatPDF.Text = "PDF";
            this.radioButtonFormatPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatEPUB
            // 
            this.radioButtonFormatEPUB.Location = new System.Drawing.Point(26, 602);
            this.radioButtonFormatEPUB.Name = "radioButtonFormatEPUB";
            this.radioButtonFormatEPUB.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatEPUB.TabIndex = 10;
            this.radioButtonFormatEPUB.TabStop = true;
            this.radioButtonFormatEPUB.Text = "EPUB";
            this.radioButtonFormatEPUB.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatTXT
            // 
            this.radioButtonFormatTXT.Location = new System.Drawing.Point(26, 640);
            this.radioButtonFormatTXT.Name = "radioButtonFormatTXT";
            this.radioButtonFormatTXT.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatTXT.TabIndex = 11;
            this.radioButtonFormatTXT.TabStop = true;
            this.radioButtonFormatTXT.Text = "TXT";
            this.radioButtonFormatTXT.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatFB2
            // 
            this.radioButtonFormatFB2.Location = new System.Drawing.Point(26, 674);
            this.radioButtonFormatFB2.Name = "radioButtonFormatFB2";
            this.radioButtonFormatFB2.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatFB2.TabIndex = 12;
            this.radioButtonFormatFB2.TabStop = true;
            this.radioButtonFormatFB2.Text = "FB2";
            this.radioButtonFormatFB2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "File Format\r\n";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "База";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(174, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите размер файла (мб)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(174, 525);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(215, 22);
            this.textBoxSize.TabIndex = 16;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigitsOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(174, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Введите имя файла\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(174, 578);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 22);
            this.textBoxName.TabIndex = 18;
            // 
            // textBoxUDC
            // 
            this.textBoxUDC.Location = new System.Drawing.Point(174, 638);
            this.textBoxUDC.Name = "textBoxUDC";
            this.textBoxUDC.Size = new System.Drawing.Size(215, 22);
            this.textBoxUDC.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(174, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Введите УДК файла\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(174, 690);
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(215, 22);
            this.textBoxNumberOfPages.TabIndex = 22;
            this.textBoxNumberOfPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigitsOnly_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(174, 668);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Введите кол-во страниц (мб)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(427, 602);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.ShowUpDown = true;
            this.dateTimePickerYear.Size = new System.Drawing.Size(172, 22);
            this.dateTimePickerYear.TabIndex = 25;
            this.dateTimePickerYear.Value = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(427, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Введите год издания\r\n\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxBase
            // 
            this.listBoxBase.FormattingEnabled = true;
            this.listBoxBase.HorizontalScrollbar = true;
            this.listBoxBase.ItemHeight = 16;
            this.listBoxBase.Location = new System.Drawing.Point(301, 80);
            this.listBoxBase.Name = "listBoxBase";
            this.listBoxBase.Size = new System.Drawing.Size(397, 308);
            this.listBoxBase.TabIndex = 28;
            this.listBoxBase.SelectedIndexChanged += new System.EventHandler(this.listBoxBase_SelectedIndexChanged);
            // 
            // PublishingHouse
            // 
            this.PublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishingHouse.Location = new System.Drawing.Point(716, 497);
            this.PublishingHouse.Name = "PublishingHouse";
            this.PublishingHouse.Size = new System.Drawing.Size(185, 63);
            this.PublishingHouse.TabIndex = 29;
            this.PublishingHouse.Text = "Издательство";
            this.PublishingHouse.UseVisualStyleBackColor = true;
            this.PublishingHouse.Click += new System.EventHandler(this.PublishingHouse_Click);
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.Location = new System.Drawing.Point(716, 649);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(185, 63);
            this.author.TabIndex = 30;
            this.author.Text = "Авторы\r\n";
            this.author.UseVisualStyleBackColor = true;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(0, 81);
            this.textBoxAuthors.Multiline = true;
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(281, 308);
            this.textBoxAuthors.TabIndex = 31;
            // 
            // textBoxPublishingHouse
            // 
            this.textBoxPublishingHouse.Location = new System.Drawing.Point(716, 80);
            this.textBoxPublishingHouse.Multiline = true;
            this.textBoxPublishingHouse.Name = "textBoxPublishingHouse";
            this.textBoxPublishingHouse.Size = new System.Drawing.Size(281, 308);
            this.textBoxPublishingHouse.TabIndex = 32;
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadFromFile.Location = new System.Drawing.Point(156, 407);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(217, 70);
            this.buttonLoadFromFile.TabIndex = 33;
            this.buttonLoadFromFile.Text = "Загрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveInFile.Location = new System.Drawing.Point(634, 407);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(217, 70);
            this.buttonSaveInFile.TabIndex = 34;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // poiskToolStripMenuItem
            // 
            this.poiskToolStripMenuItem.Name = "poiskToolStripMenuItem";
            this.poiskToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.poiskToolStripMenuItem.Text = "Поиск";
            this.poiskToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // sortirovkaToolStripMenuItem
            // 
            this.sortirovkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameToolStripMenuItem,
            this.DataZagruzkaToolStripMenuItem});
            this.sortirovkaToolStripMenuItem.Name = "sortirovkaToolStripMenuItem";
            this.sortirovkaToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.sortirovkaToolStripMenuItem.Text = "Сортировка";
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.NameToolStripMenuItem.Text = "По названию";
            this.NameToolStripMenuItem.Click += new System.EventHandler(this.NameToolStripMenuItem_Click);
            // 
            // DataZagruzkaToolStripMenuItem
            // 
            this.DataZagruzkaToolStripMenuItem.Name = "DataZagruzkaToolStripMenuItem";
            this.DataZagruzkaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.DataZagruzkaToolStripMenuItem.Text = "Дате загрузки";
            this.DataZagruzkaToolStripMenuItem.Click += new System.EventHandler(this.DataZagruzkaToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiskToolStripMenuItem,
            this.sortirovkaToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countLabel,
            this.eventLabel,
            this.timeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(999, 26);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countLabel
            // 
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(82, 20);
            this.countLabel.Text = "countLabel";
            // 
            // eventLabel
            // 
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(151, 20);
            this.eventLabel.Text = "toolStripStatusLabel2";
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 20);
            this.timeLabel.Text = "timeLabel";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.SortitTool,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(999, 27);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "SearchTool";
            this.toolStripButton1.Click += new System.EventHandler(this.SearchTool_Click);
            // 
            // SortitTool
            // 
            this.SortitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortitTool.Image = ((System.Drawing.Image)(resources.GetObject("SortitTool.Image")));
            this.SortitTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortitTool.Name = "SortitTool";
            this.SortitTool.Size = new System.Drawing.Size(29, 28);
            this.SortitTool.Text = "SortitTool";
            this.SortitTool.Click += new System.EventHandler(this.SortitTool_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton5.Text = "ClearTool";
            this.toolStripButton5.Click += new System.EventHandler(this.ClearTool_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton6.Text = "DeleteTool";
            this.toolStripButton6.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 868);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.textBoxPublishingHouse);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.author);
            this.Controls.Add(this.PublishingHouse);
            this.Controls.Add(this.listBoxBase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUDC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonFormatFB2);
            this.Controls.Add(this.radioButtonFormatTXT);
            this.Controls.Add(this.radioButtonFormatEPUB);
            this.Controls.Add(this.radioButtonFormatPDF);
            this.Controls.Add(radioButtonFormatHTML);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPublishingHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripStatusLabel countLabel;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ToolStripButton toolStripButton3;

        private System.Windows.Forms.ToolStripButton toolStripButton2;

        private System.Windows.Forms.ToolStripMenuItem DataZagruzkaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem NameToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem sortirovkaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem poiskToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveInFile;

        private System.Windows.Forms.TextBox textBoxAuthors;

        private System.Windows.Forms.TextBox textBoxPublishingHouse;

        private System.Windows.Forms.Button author;

        private System.Windows.Forms.Button PublishingHouse;

        private System.Windows.Forms.ListBox listBoxBase;

        private System.Windows.Forms.DateTimePicker dateTimePickerYear;

        private System.Windows.Forms.TextBox textBoxNumberOfPages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox textBoxUDC;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBoxName;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSize;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.RadioButton radioButtonFormatFB2;

        private System.Windows.Forms.RadioButton radioButtonFormatPDF;
        private System.Windows.Forms.RadioButton radioButtonFormatEPUB;
        private System.Windows.Forms.RadioButton radioButtonFormatTXT;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Label labelPublishingHouse;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton SortitTool;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripStatusLabel eventLabel;
        private System.Windows.Forms.ToolStripStatusLabel timeLabel;
    }
}