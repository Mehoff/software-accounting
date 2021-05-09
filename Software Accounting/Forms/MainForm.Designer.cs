
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.circleButtonAddSoftware = new Software_Accounting.Resources.Classes.CircleButton();
            this.listBoxSoftware = new System.Windows.Forms.ListBox();
            this.circleButtonProfile = new Software_Accounting.Resources.Classes.CircleButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonDownload = new Software_Accounting.Resources.Classes.CircularButton();
            this.circleButtonEditSoftware = new Software_Accounting.Resources.Classes.CircleButton();
            this.labelProgressStatus = new System.Windows.Forms.Label();
            this.labelFinishDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmployeeFullname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.panelFullname = new System.Windows.Forms.Panel();
            this.buttonSearch = new Software_Accounting.Resources.Classes.CircularButton();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSoftwareName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelDragging = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxProgressStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.circleButtonProfile);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.groupBoxInfo);
            this.panel1.Location = new System.Drawing.Point(315, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 701);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.circleButtonAddSoftware);
            this.groupBox2.Controls.Add(this.listBoxSoftware);
            this.groupBox2.Location = new System.Drawing.Point(13, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 645);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задачи";
            // 
            // circleButtonAddSoftware
            // 
            this.circleButtonAddSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circleButtonAddSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.circleButtonAddSoftware.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleButtonAddSoftware.BackgroundImage")));
            this.circleButtonAddSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButtonAddSoftware.FlatAppearance.BorderSize = 0;
            this.circleButtonAddSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtonAddSoftware.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleButtonAddSoftware.ForeColor = System.Drawing.Color.White;
            this.circleButtonAddSoftware.Location = new System.Drawing.Point(7, 579);
            this.circleButtonAddSoftware.Name = "circleButtonAddSoftware";
            this.circleButtonAddSoftware.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleButtonAddSoftware.Size = new System.Drawing.Size(60, 60);
            this.circleButtonAddSoftware.TabIndex = 15;
            this.circleButtonAddSoftware.UseVisualStyleBackColor = false;
            this.circleButtonAddSoftware.Click += new System.EventHandler(this.circleButtonAddSoftware_Click);
            // 
            // listBoxSoftware
            // 
            this.listBoxSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSoftware.BackColor = System.Drawing.Color.White;
            this.listBoxSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.listBoxSoftware.FormattingEnabled = true;
            this.listBoxSoftware.ItemHeight = 21;
            this.listBoxSoftware.Location = new System.Drawing.Point(7, 28);
            this.listBoxSoftware.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxSoftware.Name = "listBoxSoftware";
            this.listBoxSoftware.Size = new System.Drawing.Size(393, 546);
            this.listBoxSoftware.TabIndex = 0;
            this.listBoxSoftware.SelectedIndexChanged += new System.EventHandler(this.listBoxSoftware_SelectedIndexChanged);
            // 
            // circleButtonProfile
            // 
            this.circleButtonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circleButtonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.circleButtonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleButtonProfile.BackgroundImage")));
            this.circleButtonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleButtonProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.circleButtonProfile.FlatAppearance.BorderSize = 0;
            this.circleButtonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtonProfile.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleButtonProfile.ForeColor = System.Drawing.Color.White;
            this.circleButtonProfile.Location = new System.Drawing.Point(817, 49);
            this.circleButtonProfile.Name = "circleButtonProfile";
            this.circleButtonProfile.Size = new System.Drawing.Size(50, 50);
            this.circleButtonProfile.TabIndex = 15;
            this.circleButtonProfile.UseVisualStyleBackColor = false;
            this.circleButtonProfile.Click += new System.EventHandler(this.circleButtonProfile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(851, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 29);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.buttonDownload);
            this.groupBoxInfo.Controls.Add(this.circleButtonEditSoftware);
            this.groupBoxInfo.Controls.Add(this.labelProgressStatus);
            this.groupBoxInfo.Controls.Add(this.labelFinishDate);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Controls.Add(this.labelStartDate);
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.labelSoftwareName);
            this.groupBoxInfo.Controls.Add(this.labelProjectName);
            this.groupBoxInfo.Controls.Add(this.label5);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.labelEmployeeFullname);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Location = new System.Drawing.Point(438, 94);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(435, 586);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация о задаче";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.ForeColor = System.Drawing.Color.White;
            this.buttonDownload.Location = new System.Drawing.Point(88, 507);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(263, 50);
            this.buttonDownload.TabIndex = 12;
            this.buttonDownload.Text = "Скачать";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // circleButtonEditSoftware
            // 
            this.circleButtonEditSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circleButtonEditSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circleButtonEditSoftware.BackgroundImage = global::Software_Accounting.Properties.Resources.edit;
            this.circleButtonEditSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleButtonEditSoftware.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.circleButtonEditSoftware.FlatAppearance.BorderSize = 0;
            this.circleButtonEditSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtonEditSoftware.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleButtonEditSoftware.ForeColor = System.Drawing.Color.White;
            this.circleButtonEditSoftware.Location = new System.Drawing.Point(379, 31);
            this.circleButtonEditSoftware.Name = "circleButtonEditSoftware";
            this.circleButtonEditSoftware.Size = new System.Drawing.Size(50, 50);
            this.circleButtonEditSoftware.TabIndex = 15;
            this.circleButtonEditSoftware.UseVisualStyleBackColor = false;
            this.circleButtonEditSoftware.Visible = false;
            this.circleButtonEditSoftware.Click += new System.EventHandler(this.circleButtonEditSoftware_Click);
            // 
            // labelProgressStatus
            // 
            this.labelProgressStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgressStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProgressStatus.Location = new System.Drawing.Point(0, 397);
            this.labelProgressStatus.Name = "labelProgressStatus";
            this.labelProgressStatus.Size = new System.Drawing.Size(435, 27);
            this.labelProgressStatus.TabIndex = 1;
            this.labelProgressStatus.Text = "FinishDate";
            this.labelProgressStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFinishDate
            // 
            this.labelFinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinishDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFinishDate.Location = new System.Drawing.Point(3, 329);
            this.labelFinishDate.Name = "labelFinishDate";
            this.labelFinishDate.Size = new System.Drawing.Size(426, 27);
            this.labelFinishDate.TabIndex = 1;
            this.labelFinishDate.Text = "FinishDate";
            this.labelFinishDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(3, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Дата завершения:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartDate.Location = new System.Drawing.Point(3, 263);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(426, 27);
            this.labelStartDate.TabIndex = 1;
            this.labelStartDate.Text = "StartDate";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(3, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата начала:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoftwareName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSoftwareName.Location = new System.Drawing.Point(6, 54);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.Size = new System.Drawing.Size(426, 27);
            this.labelSoftwareName.TabIndex = 1;
            this.labelSoftwareName.Text = "SoftwareName";
            this.labelSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProjectName.Location = new System.Drawing.Point(6, 124);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(426, 27);
            this.labelProjectName.TabIndex = 1;
            this.labelProjectName.Text = "ProjectName";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Проект:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployeeFullname
            // 
            this.labelEmployeeFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmployeeFullname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmployeeFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmployeeFullname.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeFullname.Location = new System.Drawing.Point(3, 194);
            this.labelEmployeeFullname.Name = "labelEmployeeFullname";
            this.labelEmployeeFullname.Size = new System.Drawing.Size(426, 27);
            this.labelEmployeeFullname.TabIndex = 1;
            this.labelEmployeeFullname.Text = "EmployeeFullname";
            this.labelEmployeeFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEmployeeFullname.Click += new System.EventHandler(this.labelEmployeeFullname_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(3, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(0, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стадия выполнения:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullname.Location = new System.Drawing.Point(12, 94);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.PlaceholderText = "ФИО";
            this.textBoxFullname.Size = new System.Drawing.Size(296, 22);
            this.textBoxFullname.TabIndex = 11;
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
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(12, 360);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(296, 47);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Сортировать";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.TriggerSoftwareLoad);
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.BackColor = System.Drawing.Color.White;
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(12, 218);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(296, 29);
            this.comboBoxProjects.TabIndex = 13;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.TriggerSoftwareLoad);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(12, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Проект:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Процент выполнения:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.Black;
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
            this.panelDragging.Location = new System.Drawing.Point(0, 0);
            this.panelDragging.Name = "panelDragging";
            this.panelDragging.Size = new System.Drawing.Size(1169, 29);
            this.panelDragging.TabIndex = 11;
            this.panelDragging.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseDown);
            this.panelDragging.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseMove);
            this.panelDragging.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(12, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 3);
            this.panel4.TabIndex = 10;
            // 
            // comboBoxProgressStatus
            // 
            this.comboBoxProgressStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxProgressStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgressStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProgressStatus.FormattingEnabled = true;
            this.comboBoxProgressStatus.Location = new System.Drawing.Point(12, 292);
            this.comboBoxProgressStatus.Name = "comboBoxProgressStatus";
            this.comboBoxProgressStatus.Size = new System.Drawing.Size(296, 29);
            this.comboBoxProgressStatus.TabIndex = 13;
            this.comboBoxProgressStatus.SelectedIndexChanged += new System.EventHandler(this.TriggerSoftwareLoad);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelDragging);
            this.Controls.Add(this.comboBoxProgressStatus);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSoftwareName);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFullname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxSoftware;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelEmployeeFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFinishDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExit;
        private Resources.Classes.CircularButton buttonDownload;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Panel panelFullname;
        private Resources.Classes.CircularButton buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSoftwareName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelDragging;
        private Resources.Classes.CircleButton circleButtonProfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelProgressStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxProgressStatus;
        private Resources.Classes.CircleButton circleButtonAddSoftware;
        private Resources.Classes.CircleButton circleButtonEditSoftware;
    }
}