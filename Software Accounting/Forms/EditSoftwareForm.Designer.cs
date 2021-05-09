
namespace Software_Accounting.Forms
{
    partial class EditSoftwareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSoftwareForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxProgressStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.textBoxSoftwareName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.circularButtonSaveChanges = new Software_Accounting.Resources.Classes.CircularButton();
            this.circleButtonRestore = new Software_Accounting.Resources.Classes.CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование\r\nзадачи\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 572);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxProgressStatus
            // 
            this.comboBoxProgressStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxProgressStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgressStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProgressStatus.FormattingEnabled = true;
            this.comboBoxProgressStatus.Location = new System.Drawing.Point(453, 237);
            this.comboBoxProgressStatus.Name = "comboBoxProgressStatus";
            this.comboBoxProgressStatus.Size = new System.Drawing.Size(435, 29);
            this.comboBoxProgressStatus.TabIndex = 22;
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.BackColor = System.Drawing.Color.White;
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(453, 163);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(435, 29);
            this.comboBoxProjects.TabIndex = 23;
            // 
            // textBoxSoftwareName
            // 
            this.textBoxSoftwareName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoftwareName.Location = new System.Drawing.Point(453, 84);
            this.textBoxSoftwareName.Name = "textBoxSoftwareName";
            this.textBoxSoftwareName.PlaceholderText = "Название ПО";
            this.textBoxSoftwareName.Size = new System.Drawing.Size(435, 22);
            this.textBoxSoftwareName.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(453, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 3);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(453, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 5);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(453, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 3);
            this.panel2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(453, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(435, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Процент выполнения:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(453, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(435, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Проект:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularButtonSaveChanges
            // 
            this.circularButtonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circularButtonSaveChanges.FlatAppearance.BorderSize = 0;
            this.circularButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonSaveChanges.ForeColor = System.Drawing.Color.White;
            this.circularButtonSaveChanges.Location = new System.Drawing.Point(572, 492);
            this.circularButtonSaveChanges.Name = "circularButtonSaveChanges";
            this.circularButtonSaveChanges.Size = new System.Drawing.Size(208, 49);
            this.circularButtonSaveChanges.TabIndex = 24;
            this.circularButtonSaveChanges.Text = "Сохранить изменения";
            this.circularButtonSaveChanges.UseVisualStyleBackColor = false;
            this.circularButtonSaveChanges.Click += new System.EventHandler(this.circularButtonSaveChanges_Click);
            // 
            // circleButtonRestore
            // 
            this.circleButtonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circleButtonRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circleButtonRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleButtonRestore.BackgroundImage")));
            this.circleButtonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButtonRestore.FlatAppearance.BorderSize = 0;
            this.circleButtonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtonRestore.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleButtonRestore.ForeColor = System.Drawing.Color.White;
            this.circleButtonRestore.Location = new System.Drawing.Point(370, 488);
            this.circleButtonRestore.Name = "circleButtonRestore";
            this.circleButtonRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleButtonRestore.Size = new System.Drawing.Size(60, 60);
            this.circleButtonRestore.TabIndex = 25;
            this.circleButtonRestore.UseVisualStyleBackColor = false;
            this.circleButtonRestore.Click += new System.EventHandler(this.circleButtonRestore_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(453, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Задача:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel5.Location = new System.Drawing.Point(453, 354);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 5);
            this.panel5.TabIndex = 17;
            // 
            // textBoxURL
            // 
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxURL.Location = new System.Drawing.Point(453, 336);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.PlaceholderText = "https://github.com/author/repo";
            this.textBoxURL.Size = new System.Drawing.Size(435, 22);
            this.textBoxURL.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(453, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "URL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditSoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 560);
            this.Controls.Add(this.circleButtonRestore);
            this.Controls.Add(this.circularButtonSaveChanges);
            this.Controls.Add(this.comboBoxProgressStatus);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxSoftwareName);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "EditSoftwareForm";
            this.Text = "EditSoftwareForm";
            this.Load += new System.EventHandler(this.EditSoftwareForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxProgressStatus;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.TextBox textBoxSoftwareName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Resources.Classes.CircularButton circularButtonSaveChanges;
        private Resources.Classes.CircleButton circleButtonRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label3;
    }
}