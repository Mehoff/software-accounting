
namespace Software_Accounting.Forms
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPositions = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxUserTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.circleButtonRestore = new Software_Accounting.Resources.Classes.CircleButton();
            this.circularButtonSaveChanges = new Software_Accounting.Resources.Classes.CircularButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.label1.Text = "Редактирование\r\nпользователя\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 613);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.circleButtonRestore);
            this.groupBox1.Controls.Add(this.circularButtonSaveChanges);
            this.groupBox1.Controls.Add(this.comboBoxUserTypes);
            this.groupBox1.Controls.Add(this.comboBoxPositions);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(361, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 587);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование данных пользователя";
            // 
            // comboBoxPositions
            // 
            this.comboBoxPositions.BackColor = System.Drawing.Color.White;
            this.comboBoxPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPositions.FormattingEnabled = true;
            this.comboBoxPositions.Location = new System.Drawing.Point(60, 290);
            this.comboBoxPositions.Name = "comboBoxPositions";
            this.comboBoxPositions.Size = new System.Drawing.Size(435, 29);
            this.comboBoxPositions.TabIndex = 29;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(60, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "ФИО";
            this.textBoxName.Size = new System.Drawing.Size(435, 22);
            this.textBoxName.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(60, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 5);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(60, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 3);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "ФИО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(60, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(435, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "Должность";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(60, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Тип учетной записи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(60, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 3);
            this.panel4.TabIndex = 27;
            // 
            // comboBoxUserTypes
            // 
            this.comboBoxUserTypes.BackColor = System.Drawing.Color.White;
            this.comboBoxUserTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserTypes.FormattingEnabled = true;
            this.comboBoxUserTypes.Location = new System.Drawing.Point(60, 361);
            this.comboBoxUserTypes.Name = "comboBoxUserTypes";
            this.comboBoxUserTypes.Size = new System.Drawing.Size(435, 29);
            this.comboBoxUserTypes.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(60, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "Почта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel5.Location = new System.Drawing.Point(60, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 5);
            this.panel5.TabIndex = 26;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Location = new System.Drawing.Point(60, 193);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.PlaceholderText = "mail@gmail.com";
            this.textBoxMail.Size = new System.Drawing.Size(435, 22);
            this.textBoxMail.TabIndex = 28;
            // 
            // circleButtonRestore
            // 
            this.circleButtonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circleButtonRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circleButtonRestore.BackgroundImage = global::Software_Accounting.Properties.Resources.revert;
            this.circleButtonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButtonRestore.FlatAppearance.BorderSize = 0;
            this.circleButtonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtonRestore.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circleButtonRestore.ForeColor = System.Drawing.Color.White;
            this.circleButtonRestore.Location = new System.Drawing.Point(60, 517);
            this.circleButtonRestore.Name = "circleButtonRestore";
            this.circleButtonRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleButtonRestore.Size = new System.Drawing.Size(60, 60);
            this.circleButtonRestore.TabIndex = 31;
            this.circleButtonRestore.UseVisualStyleBackColor = false;
            this.circleButtonRestore.Click += new System.EventHandler(this.circleButtonRestore_Click);
            // 
            // circularButtonSaveChanges
            // 
            this.circularButtonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circularButtonSaveChanges.FlatAppearance.BorderSize = 0;
            this.circularButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonSaveChanges.ForeColor = System.Drawing.Color.White;
            this.circularButtonSaveChanges.Location = new System.Drawing.Point(287, 521);
            this.circularButtonSaveChanges.Name = "circularButtonSaveChanges";
            this.circularButtonSaveChanges.Size = new System.Drawing.Size(208, 49);
            this.circularButtonSaveChanges.TabIndex = 30;
            this.circularButtonSaveChanges.Text = "Сохранить изменения";
            this.circularButtonSaveChanges.UseVisualStyleBackColor = false;
            this.circularButtonSaveChanges.Click += new System.EventHandler(this.circularButtonSaveChanges_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.ComboBox comboBoxPositions;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Resources.Classes.CircleButton circleButtonRestore;
        private Resources.Classes.CircularButton circularButtonSaveChanges;
        private System.Windows.Forms.ComboBox comboBoxUserTypes;
    }
}