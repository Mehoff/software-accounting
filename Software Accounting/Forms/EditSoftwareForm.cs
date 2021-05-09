﻿using Software_Accounting.Models;
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
    public partial class EditSoftwareForm : Form
    {
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
            var ProjectId = ((ComboBoxItem)comboBoxProjects.SelectedItem).Value;
            var ProgressStatus = ((ComboBoxItem)comboBoxProgressStatus.SelectedItem).Value;
            var URL = textBoxURL.Text.Trim();

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
    }
}