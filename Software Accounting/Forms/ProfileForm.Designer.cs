
namespace Software_Accounting.Forms
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.circularButtonDownload = new Software_Accounting.Resources.Classes.CircularButton();
            this.labelProgressState = new System.Windows.Forms.Label();
            this.labelFinishDate = new System.Windows.Forms.Label();
            this.labelBeginDate = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSoftware = new System.Windows.Forms.ListBox();
            this.circleButtonEditProfile = new Software_Accounting.Resources.Classes.CircleButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.circleButtonEditProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 655);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Профиль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.labelUserType);
            this.groupBox1.Controls.Add(this.labelFullname);
            this.groupBox1.Location = new System.Drawing.Point(369, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(349, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Почта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Location = new System.Drawing.Point(349, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(300, 27);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Нет данных";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(349, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Должность";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип учетной записи";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Полное имя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPosition.Location = new System.Drawing.Point(349, 142);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(300, 27);
            this.labelPosition.TabIndex = 4;
            this.labelPosition.Text = "Нет данных";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserType
            // 
            this.labelUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUserType.BackColor = System.Drawing.Color.Transparent;
            this.labelUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserType.Location = new System.Drawing.Point(6, 142);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(300, 27);
            this.labelUserType.TabIndex = 4;
            this.labelUserType.Text = "Нет данных";
            this.labelUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFullname
            // 
            this.labelFullname.BackColor = System.Drawing.Color.Transparent;
            this.labelFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFullname.Location = new System.Drawing.Point(6, 60);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(300, 27);
            this.labelFullname.TabIndex = 4;
            this.labelFullname.Text = "Нет данных";
            this.labelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.circularButtonDownload);
            this.groupBox2.Controls.Add(this.labelProgressState);
            this.groupBox2.Controls.Add(this.labelFinishDate);
            this.groupBox2.Controls.Add(this.labelBeginDate);
            this.groupBox2.Controls.Add(this.labelProjectName);
            this.groupBox2.Controls.Add(this.labelSoftwareName);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBoxSoftware);
            this.groupBox2.Location = new System.Drawing.Point(369, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 432);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задачи пользователя";
            // 
            // circularButtonDownload
            // 
            this.circularButtonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circularButtonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circularButtonDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circularButtonDownload.Enabled = false;
            this.circularButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonDownload.ForeColor = System.Drawing.Color.White;
            this.circularButtonDownload.Location = new System.Drawing.Point(40, 374);
            this.circularButtonDownload.Name = "circularButtonDownload";
            this.circularButtonDownload.Size = new System.Drawing.Size(266, 45);
            this.circularButtonDownload.TabIndex = 4;
            this.circularButtonDownload.Text = "Скачать";
            this.circularButtonDownload.UseVisualStyleBackColor = false;
            this.circularButtonDownload.Click += new System.EventHandler(this.circularButtonDownload_Click);
            // 
            // labelProgressState
            // 
            this.labelProgressState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgressState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProgressState.Location = new System.Drawing.Point(349, 392);
            this.labelProgressState.Name = "labelProgressState";
            this.labelProgressState.Size = new System.Drawing.Size(300, 27);
            this.labelProgressState.TabIndex = 2;
            this.labelProgressState.Text = "Нет данных";
            this.labelProgressState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFinishDate
            // 
            this.labelFinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinishDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFinishDate.Location = new System.Drawing.Point(350, 308);
            this.labelFinishDate.Name = "labelFinishDate";
            this.labelFinishDate.Size = new System.Drawing.Size(300, 27);
            this.labelFinishDate.TabIndex = 2;
            this.labelFinishDate.Text = "Нет данных";
            this.labelFinishDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBeginDate
            // 
            this.labelBeginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBeginDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBeginDate.Location = new System.Drawing.Point(350, 222);
            this.labelBeginDate.Name = "labelBeginDate";
            this.labelBeginDate.Size = new System.Drawing.Size(300, 27);
            this.labelBeginDate.TabIndex = 2;
            this.labelBeginDate.Text = "Нет данных";
            this.labelBeginDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProjectName.Location = new System.Drawing.Point(350, 143);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(300, 27);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "Нет данных";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoftwareName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSoftwareName.Location = new System.Drawing.Point(349, 64);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.Size = new System.Drawing.Size(300, 27);
            this.labelSoftwareName.TabIndex = 2;
            this.labelSoftwareName.Text = "Нет данных";
            this.labelSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(349, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(300, 27);
            this.label15.TabIndex = 3;
            this.label15.Text = "Стадия выполнения:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(350, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 27);
            this.label13.TabIndex = 3;
            this.label13.Text = "Дата завершения:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(350, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 27);
            this.label11.TabIndex = 3;
            this.label11.Text = "Дата начала:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(350, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Проект:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(349, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Название:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSoftware
            // 
            this.listBoxSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.listBoxSoftware.FormattingEnabled = true;
            this.listBoxSoftware.ItemHeight = 21;
            this.listBoxSoftware.Location = new System.Drawing.Point(18, 37);
            this.listBoxSoftware.Name = "listBoxSoftware";
            this.listBoxSoftware.Size = new System.Drawing.Size(309, 319);
            this.listBoxSoftware.TabIndex = 0;
            this.listBoxSoftware.SelectedIndexChanged += new System.EventHandler(this.listBoxSoftware_SelectedIndexChanged);
            // 
            // circleButtonEditProfile
            // 
            this.circleButtonEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circleButtonEditProfile.BackColor = System.Drawing.Color.Lime;
            this.circleButtonEditProfile.BackgroundImage = global::Software_Accounting.Properties.Resources.edit;
            this.circleButtonEditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleButtonEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.circleButtonEditProfile.FlatAppearance.BorderSize = 0;
            this.circleButtonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtonEditProfile.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleButtonEditProfile.ForeColor = System.Drawing.Color.White;
            this.circleButtonEditProfile.Location = new System.Drawing.Point(12, 584);
            this.circleButtonEditProfile.Name = "circleButtonEditProfile";
            this.circleButtonEditProfile.Size = new System.Drawing.Size(50, 50);
            this.circleButtonEditProfile.TabIndex = 16;
            this.circleButtonEditProfile.UseVisualStyleBackColor = false;
            this.circleButtonEditProfile.Visible = false;
            this.circleButtonEditProfile.Click += new System.EventHandler(this.circleButtonEditProfile_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxSoftware;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProgressState;
        private System.Windows.Forms.Label labelFinishDate;
        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private Resources.Classes.CircularButton circularButtonDownload;
        private Resources.Classes.CircleButton circleButtonEditProfile;
    }
}