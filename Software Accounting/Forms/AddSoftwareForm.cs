using Software_Accounting.Context;
using Software_Accounting.Models;
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

    public struct ComboBoxProjectItem 
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public partial class AddSoftwareForm : Form
    {

        public AddSoftwareForm()
        {
            InitializeComponent();
        }

        private void AddSoftwareForm_Load(object sender, EventArgs e)
        {
            LoadProjects();

            textBoxAuthor.Text = CurrentUser.Instance.Employee.Fullname;

            labelNewProjectName.Visible = false;
            textBoxNewProjectName.Visible = false;
        }

        private void LoadProjects() 
        {
            comboBoxProject.Items.Clear();

            comboBoxProject.DisplayMember = "Name";
            comboBoxProject.ValueMember = "Id";

            comboBoxProject.Items.Add(new ComboBoxProjectItem {Name = "Добавить новый проект...", Value = -1 });
            comboBoxProject.Items.Add(new ComboBoxProjectItem {Name = "Без проекта", Value = -2 });

            List<Project> Projects = new List<Project>();

            using (var ctx = new DBContext()) 
            {
                Projects = ctx.Projects.ToList();
            }

            foreach(var p in Projects) 
                comboBoxProject.Items.Add(new ComboBoxProjectItem { Name = p.Name, Value = p.Id });
        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProject.SelectedIndex == -1)
                return;

            ToggleNewProjectNameControlsVisibility(((ComboBoxProjectItem)comboBoxProject.SelectedItem).Value);
        }

        private void ToggleNewProjectNameControlsVisibility(int value) 
        {
            if (value == -1) 
            {
                labelNewProjectName.Visible = true;
                textBoxNewProjectName.Visible = true;
            }
            else 
            {
                labelNewProjectName.Visible = false;
                textBoxNewProjectName.Visible = false;
            }
        }

        private void circularButtonAdd_Click(object sender, EventArgs e)
        {
            // TODO: Проверки на дубликаты и т.п.

            var isNewProject = ((ComboBoxProjectItem)comboBoxProject.SelectedItem).Value == -1 ? true : false;

            int? newProjectId = null;

            try 
            {
                using (var ctx = new DBContext())
                {
                    string newProjectName = string.Empty;

                    if (isNewProject)
                    {
                        newProjectName = textBoxNewProjectName.Text.Trim();

                        Project newProject = new Project();
                        newProject.Name = newProjectName;
                        ctx.Projects.Add(newProject);
                        ctx.SaveChanges();

                        MessageBox.Show("Сохранен " + newProjectName);

                        newProjectId = newProject.Id;
                    }
                }

                using (var ctx = new DBContext())
                {
                    //Check for nulls
                    var newSoftwareName = textBoxName.Text.Trim();
                    var newSoftwareUrl = textBoxURL.Text.Trim();

                    int? newSoftwareProjectFK;

                    switch (((ComboBoxProjectItem)comboBoxProject.SelectedItem).Value) 
                    {
                        case -1:
                            {
                                newSoftwareProjectFK = newProjectId;
                            }
                            break;
                        case -2:
                            {
                                newSoftwareProjectFK = null;
                            }
                            break;
                        default:
                            {
                                newSoftwareProjectFK = ((ComboBoxProjectItem)comboBoxProject.SelectedItem).Value;
                            }
                            break;
                    }

                    ctx.Softwares.Add(new Software
                    {
                        Name = newSoftwareName,
                        ProgressStatusFk = 1,
                        BeginDateTime = DateTime.Now,
                        AuthorFk = CurrentUser.Instance.Employee.Id,
                        SourceUrl = newSoftwareUrl,
                        ProjectFk = newSoftwareProjectFK
                    });

                    ctx.SaveChanges();

                    MessageBox.Show("Программное обеспечение успешно добавлено");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
