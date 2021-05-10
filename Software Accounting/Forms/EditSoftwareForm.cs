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
using Software_Accounting.Source;

namespace Software_Accounting.Forms
{
    public partial class EditSoftwareForm : Form
    {
        private bool mouseDown;

        private Point lastLocation;
        private Software Software { get; set; }
        private int SoftwareId { get; set; }
        public EditSoftwareForm(int id)
        {
            InitializeComponent();
            SoftwareId = id;
        }


        private void circleButtonRestore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Восстановить все значения на свои места?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.No || result == DialogResult.Cancel)
                return;

            FillData();
        }

        private void circularButtonSaveChanges_Click(object sender, EventArgs e)
        {
            var Name = textBoxSoftwareName.Text.Trim();
            int? ProjectId = ((ComboBoxItem)comboBoxProjects.Items[comboBoxProjects.SelectedIndex]).Value;

            if (ProjectId == -2)
                ProjectId = null;


            if(Name.Length < 2) 
            {
                MessageBox.Show("Имя должно быть длиннее двух символов");
                return;
            }

            var ProgressStatus = ((ComboBoxItem)comboBoxProgressStatus.Items[comboBoxProgressStatus.SelectedIndex]).Value;
            
            var URL = textBoxURL.Text.Trim();
            if (!UriOpener.IsCorrectUri(URL)) 
            {
                MessageBox.Show("Некорректный URL");
                return;
            }

            var data = new Software { Name = Name, ProjectFk = ProjectId, ProgressStatusFk = ProgressStatus, SourceUrl = URL };

            if (isSoftwareDataEqual(data, Software))
            {
                MessageBox.Show("Нет изменений");
                return;
            }

            using (var ctx = new DBContext())
            {
                Software = ctx.Softwares.SingleOrDefault(s => s.Id == Software.Id);

                Software.Name = data.Name;
                Software.ProjectFk = data.ProjectFk;
                Software.ProgressStatusFk = data.ProgressStatusFk;
                Software.SourceUrl = data.SourceUrl;

                if (Software.ProgressStatusFk == 3)
                    Software.LastUpdateDateTime = DateTime.Now;
                else Software.LastUpdateDateTime = null;

                ctx.SaveChanges();
            }

            MessageBox.Show("Данные о выбранной задаче были обновлены!");
            Close();

        }

        private bool isSoftwareDataEqual(Software a, Software b)
        {
            if (a.Name == b.Name &&
               a.ProjectFk == b.ProjectFk &&
               a.ProgressStatusFk == b.ProgressStatusFk &&
               a.SourceUrl == b.SourceUrl) { return true; }
            else return false;
        }

        private void EditSoftwareForm_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            using (var ctx = new DBContext())
            {
                Software = ctx.Softwares.SingleOrDefault(s => s.Id == SoftwareId);
                if (Software == null)
                {
                    MessageBox.Show("Error while loading Software data");
                    return;
                }
            }

            FillData();
        }

        private void LoadComboboxes()
        {
            using (var ctx = new DBContext())
            {
                comboBoxProjects.Items.Clear();
                comboBoxProjects.DisplayMember = "Name";
                comboBoxProjects.ValueMember = "Value";

                comboBoxProjects.Items.Add(new ComboBoxItem { Value = -2, Name = "Без проекта" });

                var Projects = ctx.Projects.ToList();

                foreach (var project in Projects)
                    comboBoxProjects.Items.Add(new ComboBoxItem { Value = project.Id, Name = project.Name });


                comboBoxProgressStatus.Items.Clear();
                comboBoxProgressStatus.DisplayMember = "Name";
                comboBoxProgressStatus.ValueMember = "Value";


                var ProgressStatuses = ctx.ProgressStatuses.ToList();

                foreach (var status in ProgressStatuses)
                    comboBoxProgressStatus.Items.Add(new ComboBoxItem { Value = status.Id, Name = status.Name });

            }
        }

        private void FillData() 
        {
            textBoxSoftwareName.Text = Software.Name;
            
            foreach(ComboBoxItem item in comboBoxProjects.Items) 
            {
                if (item.Value == Software.ProjectFk) 
                {
                    comboBoxProjects.SelectedItem = item;
                    break;
                }
            }

            foreach (ComboBoxItem item in comboBoxProgressStatus.Items)
            {
                if (item.Value == Software.ProgressStatusFk)
                {
                    comboBoxProgressStatus.SelectedItem = item;
                    break;
                }
            }

            textBoxURL.Text = Software.SourceUrl;
        }

        private void panelEditSoftwareDrag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelEditSoftwareDrag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelEditSoftwareDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
