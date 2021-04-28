using Software_Accounting.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Accounting
{
    public partial class LoginForm : Form
    {
        //Todo: Add Dragging
        private bool dragging = false;
        private Point offset;
        private bool isLoggingIn = true;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            isLoggingIn = !isLoggingIn;
            UpdateUI();
        }

        private void UpdateUI() 
        {
            switch (isLoggingIn)
            {
                case true: 
                    {

                        labelHeader.Focus();

                        labelHeader.Text = "Вход";
                        buttonLogin.Text = "Вход";
                        labelRegister.Text = "Регистрация";

                        textBoxConfirm.Visible = false;
                        panelConfirm.Visible = false;

                        textBoxFullname.Visible = false;
                        panelFullname.Visible = false;
                    }
                break;
                case false:
                    {

                        labelHeader.Focus();

                        labelHeader.Text = "Регистрация";
                        buttonLogin.Text = "Зарегистироваться";
                        labelRegister.Text = "Войти";

                        textBoxConfirm.Visible = true;
                        panelConfirm.Visible = true;

                        textBoxFullname.Visible = true;
                        panelFullname.Visible = true;
                    }
                    break;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Show();
            //if (isLoggingIn)
            ////Log In
            //{

            //}
            //else
            ////Register
            //{

            //}
        }
    }
}
