using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Software_Accounting.Context;
using Software_Accounting.Models;
using Software_Accounting.Source;

namespace Software_Accounting.Forms
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }


        // Пока не работает
        private void TriggerSoftwareLoad(object sender, EventArgs e) 
        {
            listBoxSoftware.DataSource = null;

            using (var ctx = new DBContext()) 
            {
                var Software = ctx.Softwares.ToList();

                var FullName = textBoxFullname.Text.Trim();
                var SoftwareName = textBoxSoftwareName.Text.Trim();


                // TODO: Добавить в комбобокс вариант "Без проекта" и обработку этого варианта в этой функции
                if (FullName.Length > 0) 
                {
                    Software = Software.Where(s => s.AuthorFkNavigation.Fullname.ToLower().Contains(FullName.ToLower())).ToList();
                }
                if (SoftwareName.Length > 0)
                {
                    Software = Software.Where(s => s.Name.ToLower().Contains(SoftwareName.ToLower())).ToList();
                }
                if(comboBoxProjects.SelectedIndex != -1) 
                {
                    Software = Software.Where(s => s.ProjectFk == (comboBoxProjects.SelectedItem as Project).Id).ToList();
                }
                if(comboBoxProgressStatus.SelectedIndex != -1) 
                {
                    Software = Software.Where(s => s.ProgressStatusFk == (comboBoxProgressStatus.SelectedItem as ProgressStatus).Id).ToList();
                }

                listBoxSoftware.DataSource = Software;
                listBoxSoftware.DisplayMember = "Name";
                listBoxSoftware.ValueMember = "Id";
            }
        }


        private void listBoxSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSoftware.SelectedIndex == -1)
                return;
            
            // TODO: Сделать Лейбл кликабельным чтобы можно было открыть профиль этого пользователя и посмотреть все его остальные проекты в другом окне
                
            using (var ctx = new DBContext()) 
            {
                Software software = ctx.Softwares.SingleOrDefault(s => s.Id == (listBoxSoftware.SelectedItem as Software).Id);

                if(software == null) 
                {
                    MessageBox.Show("Ошибка загрузки задачи");
                    return;
                }

                var Employee = ctx.Employees.SingleOrDefault(e => software.AuthorFk == e.Id);
                var ProgressStatus = ctx.ProgressStatuses.SingleOrDefault(ps => software.ProgressStatusFk == ps.Id);
                var ProjectName = ctx.Projects.SingleOrDefault(p => software.ProjectFk == p.Id);

                labelEmployeeFullname.Text = Employee != null ? Employee.Fullname : "Нет данных";
                labelProgressStatus.Text = ProgressStatus != null ? ProgressStatus.Name : "Нет данных";
                labelProjectName.Text = ProjectName != null ? ProjectName.Name : "Нет данных";

                labelStartDate.Text = software.BeginDateTime != null ? software.BeginDateTime.ToString() : "Нет данных";
                labelFinishDate.Text = software.LastUpdateDateTime != null ? software.LastUpdateDateTime.ToString() : "Нет данных";
                
                labelSoftwareName.Text = software.Name;
            }
        }

        private void circleButtonProfile_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(CurrentUser.Instance.Employee.Id);
            profileForm.ShowDialog();
        }

        private void circleButtonAddSoftware_Click(object sender, EventArgs e)
        {
            var addSoftwareForm = new AddSoftwareForm();
            addSoftwareForm.ShowDialog();
        }


        private void LoadComboBoxes()
        {
            using (var ctx = new DBContext())
            {
                comboBoxProjects.DisplayMember = "Name";
                comboBoxProjects.ValueMember = "Id";
                comboBoxProjects.DataSource = ctx.Projects.ToList();

                comboBoxProgressStatus.DisplayMember = "Name";
                comboBoxProgressStatus.ValueMember = "Id";
                comboBoxProgressStatus.DataSource = ctx.ProgressStatuses.ToList();
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверенны что хотите выйти из аккаунта?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Close();
                CurrentUser.LogOut();
            }
        }

        // Form Dragging
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
