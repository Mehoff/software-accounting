
namespace Software_Accounting
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new Software_Accounting.Resources.Classes.CircularButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.panelFullname = new System.Windows.Forms.Panel();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.panelConfirm = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDragging = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.labelRegister);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.textBoxFullname);
            this.panel1.Controls.Add(this.panelFullname);
            this.panel1.Controls.Add(this.textBoxConfirm);
            this.panel1.Controls.Add(this.panelConfirm);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.panelPassword);
            this.panel1.Controls.Add(this.textBoxMail);
            this.panel1.Controls.Add(this.panelEmail);
            this.panel1.Location = new System.Drawing.Point(353, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 558);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(75, 391);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(5);
            this.buttonLogin.Size = new System.Drawing.Size(386, 69);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(0, 91);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(545, 65);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.Text = "Вход";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegister
            // 
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRegister.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.labelRegister.Location = new System.Drawing.Point(0, 500);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(545, 58);
            this.labelRegister.TabIndex = 6;
            this.labelRegister.Text = "Регистрация";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonExit.Location = new System.Drawing.Point(503, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(42, 35);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullname.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxFullname.Location = new System.Drawing.Point(40, 170);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.PlaceholderText = "ФИО";
            this.textBoxFullname.Size = new System.Drawing.Size(457, 22);
            this.textBoxFullname.TabIndex = 1;
            // 
            // panelFullname
            // 
            this.panelFullname.BackColor = System.Drawing.Color.Aqua;
            this.panelFullname.Location = new System.Drawing.Point(40, 198);
            this.panelFullname.Name = "panelFullname";
            this.panelFullname.Size = new System.Drawing.Size(457, 1);
            this.panelFullname.TabIndex = 0;
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirm.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxConfirm.Location = new System.Drawing.Point(40, 324);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '•';
            this.textBoxConfirm.PlaceholderText = "Подтвердите пароль";
            this.textBoxConfirm.Size = new System.Drawing.Size(457, 22);
            this.textBoxConfirm.TabIndex = 4;
            // 
            // panelConfirm
            // 
            this.panelConfirm.BackColor = System.Drawing.Color.Aqua;
            this.panelConfirm.Location = new System.Drawing.Point(40, 352);
            this.panelConfirm.Name = "panelConfirm";
            this.panelConfirm.Size = new System.Drawing.Size(457, 1);
            this.panelConfirm.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(40, 275);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.PlaceholderText = "Пароль";
            this.textBoxPassword.Size = new System.Drawing.Size(457, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "qwerty";
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.Aqua;
            this.panelPassword.Location = new System.Drawing.Point(40, 303);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(457, 1);
            this.panelPassword.TabIndex = 0;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMail.Location = new System.Drawing.Point(40, 224);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.PlaceholderText = "Почта";
            this.textBoxMail.Size = new System.Drawing.Size(457, 22);
            this.textBoxMail.TabIndex = 2;
            this.textBoxMail.Text = "admin@gmail.com";
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.Color.Aqua;
            this.panelEmail.Location = new System.Drawing.Point(40, 252);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(457, 1);
            this.panelEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ООО \"Партнер Ай Ди\"";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 212);
            this.label2.TabIndex = 3;
            this.label2.Text = "Программа для учёта програмного обеспечения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Accounting.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelDragging
            // 
            this.panelDragging.BackColor = System.Drawing.Color.Transparent;
            this.panelDragging.Location = new System.Drawing.Point(-1, -1);
            this.panelDragging.Name = "panelDragging";
            this.panelDragging.Size = new System.Drawing.Size(858, 35);
            this.panelDragging.TabIndex = 5;
            this.panelDragging.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseDown);
            this.panelDragging.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseMove);
            this.panelDragging.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDragging_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(897, 556);
            this.Controls.Add(this.panelDragging);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label label1;
        private Resources.Classes.CircularButton buttonLogin;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Panel panelFullname;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Panel panelConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDragging;
    }
}

