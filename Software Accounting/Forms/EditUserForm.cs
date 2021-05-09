using Software_Accounting.Models;
using Software_Accounting.Context;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Accounting.Forms
{
    public partial class EditUserForm : Form
    {
        private Employee Employee { get; set; }
        private int EmployeeId { get; set; }
        public EditUserForm(int id)
        {
            InitializeComponent();
            EmployeeId = id;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            using(var ctx = new DBContext()) 
            {
                Employee = ctx.Employees.SingleOrDefault(e => e.Id == EmployeeId);
                if(Employee == null) 
                {
                    MessageBox.Show("Ошибка загрузки данных сотрудника");
                    return;
                }
            }
            FillData();
        }

        private void FillData()
        {
            textBoxMail.Text = Employee.Email;
            textBoxName.Text = Employee.Fullname;

            foreach(UserType item in comboBoxUserTypes.Items)
            {
                if(item.Id == Employee.UserTypeFk) 
                {
                    comboBoxUserTypes.SelectedItem = item;
                    break;
                }
            }

            foreach (Position item in comboBoxPositions.Items)
            {
                if (item.Id == Employee.PositionFk)
                {
                    comboBoxPositions.SelectedItem = item;
                    break;
                }
            }

            textBoxName.Focus();
        }

        private void LoadComboBoxes()
        {
            using(var ctx = new DBContext()) 
            {
                comboBoxUserTypes.DisplayMember = "Name";
                comboBoxUserTypes.ValueMember = "Id";
                comboBoxUserTypes.DataSource = ctx.UserTypes.ToList();


                comboBoxPositions.DisplayMember = "Name";
                comboBoxPositions.ValueMember = "Id";
                comboBoxPositions.DataSource = ctx.Positions.ToList();
            }
        }

        private void circularButtonSaveChanges_Click(object sender, EventArgs e)
        {
            var data = new Employee
            {
                Fullname = textBoxName.Text.Trim(),
                Email = textBoxMail.Text.Trim(),
                UserTypeFk = (comboBoxUserTypes.Items[comboBoxUserTypes.SelectedIndex] as UserType).Id,
                PositionFk = (comboBoxPositions.Items[comboBoxPositions.SelectedIndex] as Position).Id
            };

            if (isEqual(Employee, data)) 
            {
                MessageBox.Show("Нет изменений");
                return;
            }

            using(var ctx = new DBContext()) 
            {
                Employee = ctx.Employees.Single(e => e.Id == Employee.Id);
                if(Employee == null) 
                {
                    MessageBox.Show("Ошибка загрузки пользователя");
                    return;
                }

                Employee.Fullname = data.Fullname;
                Employee.Email = data.Email;
                Employee.PositionFk = data.PositionFk;
                Employee.UserTypeFk = data.UserTypeFk;

                ctx.SaveChanges();
            }

            MessageBox.Show("Данные о пользователе были обнлвлены!");
            Close();
        }

        private bool isEqual(Employee a, Employee b)
        {
            if (a.Fullname == b.Fullname &&
                a.Email == b.Email &&
                a.UserTypeFk == b.UserTypeFk &&
                a.PositionFk == b.PositionFk) { return true; }
            else return false;
        }

        private void circleButtonRestore_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
