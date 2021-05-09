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
using System.Diagnostics;

namespace Software_Accounting.Forms
{
    public struct ComboBoxItem
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
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
                    var temp = new List<Software>();
                    foreach(var soft in Software) 
                    {
                        var employee = ctx.Employees.SingleOrDefault(e => e.Id == soft.AuthorFk);
                        if (employee == null)
                            continue;

                        if (employee.Fullname.ToLower().Contains(SoftwareName.ToLower())) 
                            temp.Add(soft);
                    }

                    Software = temp;

                }
                if (SoftwareName.Length > 0)
                {
                    Software = Software.Where(s => s.Name.ToLower().Contains(SoftwareName.ToLower())).ToList();
                }

                if(comboBoxProjects.SelectedIndex != -1) 
                {
                    var SelectedComboBoxItem = (ComboBoxItem)comboBoxProjects.Items[comboBoxProjects.SelectedIndex];

                    switch (SelectedComboBoxItem.Value) 
                    {
                        // Любой
                        case -1: { }
                            break;
                        case -2:
                            {
                                Software = Software.Where(s => s.ProjectFk == null).ToList(); 
                            }
                            break;
                        default:
                            {
                                Software = Software.Where(s => s.ProjectFk == SelectedComboBoxItem.Value).ToList();
                            }
                            break;
                    }
                }

                if(comboBoxProgressStatus.SelectedIndex != -1) 
                {
                    var SelectedComboBoxItem = (ComboBoxItem)comboBoxProgressStatus.Items[comboBoxProgressStatus.SelectedIndex];

                    switch (SelectedComboBoxItem.Value) 
                    {
                        // Любой
                        case -1: { }
                            break;
                        default:
                            {
                                Software = Software.Where(s => s.ProgressStatusFk == SelectedComboBoxItem.Value).ToList();
                            }
                            break;
                    }
                }

                listBoxSoftware.DataSource = Software;
                listBoxSoftware.DisplayMember = "Name";
                listBoxSoftware.ValueMember = "Id";
            }
        }

        private void listBoxSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSoftware.SelectedIndex == -1) 
            {
                groupBoxInfo.Visible = false;
                return;
            }
            else groupBoxInfo.Visible = true;

            using (var ctx = new DBContext()) 
            {
                Software software = ctx.Softwares.SingleOrDefault(s => s.Id == (listBoxSoftware.SelectedItem as Software).Id);

                if(software == null) 
                {
                    MessageBox.Show("Ошибка загрузки задачи");
                    return;
                }

                var Employee = ctx.Employees.SingleOrDefault(e => software.AuthorFk == e.Id);

                if (Employee.Id == CurrentUser.Instance.Employee.Id || CurrentUser.Instance.Employee.UserTypeFk == 1)
                    DrawSoftwareEditButton();
                else HideSoftwareEditButton();
                

                var ProgressStatus = ctx.ProgressStatuses.SingleOrDefault(ps => software.ProgressStatusFk == ps.Id);
                var ProjectName = ctx.Projects.SingleOrDefault(p => software.ProjectFk == p.Id);

                labelEmployeeFullname.Text = Employee != null ? Employee.Fullname : "Нет данных";
                labelEmployeeFullname.Tag = Employee.Id;

                labelProgressStatus.Text = ProgressStatus != null ? ProgressStatus.Name : "Нет данных";
                labelProjectName.Text = ProjectName != null ? ProjectName.Name : "Нет данных";

                labelStartDate.Text = software.BeginDateTime != null ? software.BeginDateTime.ToString() : "Нет данных";
                labelFinishDate.Text = software.LastUpdateDateTime != null ? software.LastUpdateDateTime.ToString() : "Нет данных";
                
                labelSoftwareName.Text = software.Name;
            }
        }

        private void HideSoftwareEditButton()
        {
            circleButtonEditSoftware.Visible = false;
        }

        private void DrawSoftwareEditButton()
        {
            circleButtonEditSoftware.Visible = true;
        }

        private void circleButtonProfile_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(CurrentUser.Instance.Employee.Id);
            profileForm.ShowDialog();

            listBoxSoftware_SelectedIndexChanged(null, null);
        }

        private void circleButtonAddSoftware_Click(object sender, EventArgs e)
        {
            var addSoftwareForm = new AddSoftwareForm();
            addSoftwareForm.ShowDialog();

            TriggerSoftwareLoad(null, null);
        }

        private void labelEmployeeFullname_Click(object sender, EventArgs e)
        {
            var ProfileForm = new ProfileForm((int)labelEmployeeFullname.Tag);
            ProfileForm.ShowDialog();

            listBoxSoftware_SelectedIndexChanged(null, null);
        }

        private void circleButtonEditSoftware_Click(object sender, EventArgs e)
        {
            var SoftwareId = (listBoxSoftware.SelectedItem as Software).Id;
            var form = new EditSoftwareForm(SoftwareId);
            this.Hide();
            form.ShowDialog();
            this.Show();

            //Trigger UI Update
            listBoxSoftware_SelectedIndexChanged(null, null);
        }

        private void LoadComboBoxes()
        {
            using(var ctx = new DBContext()) 
            {
                comboBoxProjects.Items.Clear();
                comboBoxProjects.DisplayMember = "Name";
                comboBoxProjects.ValueMember = "Value";

                comboBoxProjects.Items.Add(new ComboBoxItem { Value = -1, Name = "Любой" });
                comboBoxProjects.Items.Add(new ComboBoxItem { Value = -2, Name = "Без проекта" });

                var Projects = ctx.Projects.ToList();

                foreach (var project in Projects)
                    comboBoxProjects.Items.Add(new ComboBoxItem { Value = project.Id, Name = project.Name });


                comboBoxProgressStatus.Items.Clear();
                comboBoxProgressStatus.DisplayMember = "Name";
                comboBoxProgressStatus.ValueMember = "Value";

                comboBoxProgressStatus.Items.Add(new ComboBoxItem { Value = -1, Name = "Любой" });

                var ProgressStatuses = ctx.ProgressStatuses.ToList();

                foreach (var status in ProgressStatuses)
                    comboBoxProgressStatus.Items.Add(new ComboBoxItem { Value = status.Id, Name = status.Name });
            }
        }

        // Opens Administrator Panel
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

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            UriOpener.OpenUri((listBoxSoftware.SelectedItem as Software).SourceUrl);
        }
    }
}
