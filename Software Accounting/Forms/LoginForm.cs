using Software_Accounting.Context;
using Software_Accounting.Models;
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
using Software_Accounting.Source;
using System.Net.Mail;

namespace Software_Accounting
{
    public partial class LoginForm : Form
    {
        //Todo: Add Dragging
        private bool mouseDown;
        private Point lastLocation;
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
            try 
            {
                using (var ctx = new DBContext())
                {
                    // EMAIL VALIDATION
                    string email = string.Empty;
                    try 
                    {
                        email = new MailAddress(textBoxMail.Text.Trim()).Address;
                    }
                    catch(FormatException fe) 
                    {
                        MessageBox.Show("Email адрес невалидный");
                        return;
                    }

                    var password = textBoxPassword.Text.Trim();

                    //PASSWORD VALIDATION
                    if(password.Length < 6) 
                    {
                        MessageBox.Show("Пароль должен быть не меньше 6 символов");
                        return;
                    }

                    if (isLoggingIn)
                    //Log In
                    {
                        var user = ctx.Employees.SingleOrDefault(e => e.Email == email && e.Password == password);

                        if (user == null) 
                        {
                            MessageBox.Show("Пользователь не найден");
                            return;
                        }       
                    }
                    else
                    //Register
                    //TODO: Больше проверок: (6 символов, одна заглавная и тп, Regex на почту и ФИО)
                    {
                        var name = textBoxFullname.Text.Trim();
                        var confirmation = textBoxConfirm.Text.Trim();

                        if (!password.Equals(confirmation)) { MessageBox.Show("Пароли не совпадают"); return; }

                        if(ctx.Employees.SingleOrDefault(e => e.Email == email) != null) 
                        {
                            MessageBox.Show("Пользователь с этой почтой уже зарегистрирован");
                            return;
                        }

                        Employee newEmployee = new Employee
                        {
                            Fullname = name,
                            Email = email,
                            Password = password,
                            UserTypeFk = 3, // Пользователь
                            PositionFk = 1, // По дефолу все Junior Programmer, Admin может поменять эти значения
                        };

                        ctx.Employees.Add(newEmployee);
                        ctx.SaveChanges();

                        MessageBox.Show("Успешная регистрация!");
                    }

                    CurrentUser.Instance.Employee = ctx.Employees.SingleOrDefault(e => e.Email == email && e.Password == password);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            Show();
        }
        private void panelDragging_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void panelDragging_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void panelDragging_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
