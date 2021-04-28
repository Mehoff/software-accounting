
namespace Software_Accounting.Forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDownload = new Software_Accounting.Resources.Classes.CircularButton();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFinishDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmployeeFullname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarPercentage = new System.Windows.Forms.ProgressBar();
            this.listBoxSoftware = new System.Windows.Forms.ListBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.panelFullname = new System.Windows.Forms.Panel();
            this.buttonSearch = new Software_Accounting.Resources.Classes.CircularButton();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarPercent = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSoftwareName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelDragging = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.listBoxSoftware);
            this.panel1.Location = new System.Drawing.Point(315, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 701);
            this.panel1.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(851, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 35);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonDownload);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelFinishDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelStartDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelSoftwareName);
            this.groupBox1.Controls.Add(this.labelCategoryName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelEmployeeFullname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBarPercentage);
            this.groupBox1.Location = new System.Drawing.Point(462, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 633);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о задаче";
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.ForeColor = System.Drawing.Color.White;
            this.buttonDownload.Location = new System.Drawing.Point(79, 569);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(263, 47);
            this.buttonDownload.TabIndex = 12;
            this.buttonDownload.Text = "Скачать";
            this.buttonDownload.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(3, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(402, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "66%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFinishDate
            // 
            this.labelFinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinishDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFinishDate.Location = new System.Drawing.Point(-3, 380);
            this.labelFinishDate.Name = "labelFinishDate";
            this.labelFinishDate.Size = new System.Drawing.Size(414, 27);
            this.labelFinishDate.TabIndex = 1;
            this.labelFinishDate.Text = "FinishDate";
            this.labelFinishDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(-3, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Дата завершения:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartDate.Location = new System.Drawing.Point(-3, 314);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(414, 27);
            this.labelStartDate.TabIndex = 1;
            this.labelStartDate.Text = "StartDate";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(-3, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата начала:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoftwareName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSoftwareName.Location = new System.Drawing.Point(0, 105);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.Size = new System.Drawing.Size(414, 27);
            this.labelSoftwareName.TabIndex = 1;
            this.labelSoftwareName.Text = "SoftwareName";
            this.labelSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCategoryName.Location = new System.Drawing.Point(0, 175);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(414, 27);
            this.labelCategoryName.TabIndex = 1;
            this.labelCategoryName.Text = "CategoryName";
            this.labelCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(0, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категория:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployeeFullname
            // 
            this.labelEmployeeFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmployeeFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmployeeFullname.Location = new System.Drawing.Point(-3, 245);
            this.labelEmployeeFullname.Name = "labelEmployeeFullname";
            this.labelEmployeeFullname.Size = new System.Drawing.Size(414, 27);
            this.labelEmployeeFullname.TabIndex = 1;
            this.labelEmployeeFullname.Text = "EmployeeFullname";
            this.labelEmployeeFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(-3, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(-3, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стадия выполнения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarPercentage
            // 
            this.progressBarPercentage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBarPercentage.Location = new System.Drawing.Point(3, 480);
            this.progressBarPercentage.Name = "progressBarPercentage";
            this.progressBarPercentage.Size = new System.Drawing.Size(402, 10);
            this.progressBarPercentage.Step = 1;
            this.progressBarPercentage.TabIndex = 0;
            this.progressBarPercentage.Value = 50;
            // 
            // listBoxSoftware
            // 
            this.listBoxSoftware.FormattingEnabled = true;
            this.listBoxSoftware.ItemHeight = 21;
            this.listBoxSoftware.Items.AddRange(new object[] {
            "Приложение №1",
            "Программа №2",
            "Софт №3",
            "GTA 5",
            "Team Fortress 2",
            "Dota 2"});
            this.listBoxSoftware.Location = new System.Drawing.Point(55, 35);
            this.listBoxSoftware.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxSoftware.Name = "listBoxSoftware";
            this.listBoxSoftware.Size = new System.Drawing.Size(346, 634);
            this.listBoxSoftware.TabIndex = 0;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullname.Location = new System.Drawing.Point(12, 94);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.PlaceholderText = "ФИО";
            this.textBoxFullname.Size = new System.Drawing.Size(296, 22);
            this.textBoxFullname.TabIndex = 11;
            this.textBoxFullname.TextChanged += new System.EventHandler(this.textBoxFullname_TextChanged);
            // 
            // panelFullname
            // 
            this.panelFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelFullname.Location = new System.Drawing.Point(12, 112);
            this.panelFullname.Name = "panelFullname";
            this.panelFullname.Size = new System.Drawing.Size(296, 5);
            this.panelFullname.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(43, 386);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(225, 47);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Вариант №1",
            "Вариант №2",
            "Вариант №3",
            "Вариант №4",
            "Вариант №5",
            "Вариант №6"});
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 218);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(296, 29);
            this.comboBoxCategory.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(12, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Категория:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarPercent
            // 
            this.trackBarPercent.Location = new System.Drawing.Point(12, 293);
            this.trackBarPercent.Maximum = 100;
            this.trackBarPercent.Name = "trackBarPercent";
            this.trackBarPercent.Size = new System.Drawing.Size(296, 45);
            this.trackBarPercent.TabIndex = 14;
            this.trackBarPercent.Scroll += new System.EventHandler(this.trackBarPercent_Scroll);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(12, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 27);
            this.label10.TabIndex = 1;
            this.label10.Text = "Процент выполнения:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPercent
            // 
            this.labelPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPercent.Location = new System.Drawing.Point(12, 332);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(296, 27);
            this.labelPercent.TabIndex = 1;
            this.labelPercent.Text = "Только начатые";
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(12, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 3);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(12, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 5);
            this.panel3.TabIndex = 10;
            // 
            // textBoxSoftwareName
            // 
            this.textBoxSoftwareName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoftwareName.Location = new System.Drawing.Point(12, 139);
            this.textBoxSoftwareName.Name = "textBoxSoftwareName";
            this.textBoxSoftwareName.PlaceholderText = "Название ПО";
            this.textBoxSoftwareName.Size = new System.Drawing.Size(296, 22);
            this.textBoxSoftwareName.TabIndex = 11;
            this.textBoxSoftwareName.TextChanged += new System.EventHandler(this.textBoxFullname_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(12, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Фильтр поиска";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDragging
            // 
            this.panelDragging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelDragging.Location = new System.Drawing.Point(-3, 0);
            this.panelDragging.Name = "panelDragging";
            this.panelDragging.Size = new System.Drawing.Size(1163, 29);
            this.panelDragging.TabIndex = 11;
            this.panelDragging.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseDown);
            this.panelDragging.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseMove);
            this.panelDragging.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelDragging);
            this.Controls.Add(this.trackBarPercent);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSoftwareName);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFullname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxSoftware;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEmployeeFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarPercentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFinishDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExit;
        private Resources.Classes.CircularButton buttonDownload;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Panel panelFullname;
        private Resources.Classes.CircularButton buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSoftwareName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelDragging;
    }
}