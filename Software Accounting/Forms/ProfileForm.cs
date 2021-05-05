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
    public partial class ProfileForm : Form
    {
        private int EmployeeId { get; set; }
        private Employee Employee { get; set; }
        public ProfileForm(int id)
        {
            InitializeComponent();
            EmployeeId = id;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            using(var ctx = new DBContext()) 
            {
                Employee = ctx.Employees.SingleOrDefault(e => e.Id == EmployeeId);
                if (Employee == null)
                    return;

                // Softwares
                listBoxSoftware.DisplayMember = "Name";
                listBoxSoftware.ValueMember = "Id";
                listBoxSoftware.DataSource = ctx.Softwares.Where(s => s.AuthorFk == Employee.Id).ToList();

                // Info
                labelFullname.Text = Employee.Fullname;
                labelEmail.Text = Employee.Email;


                var UserType = ctx.UserTypes.SingleOrDefault(ut => ut.Id == Employee.UserTypeFk);
                var Position = ctx.Positions.SingleOrDefault(p => p.Id == Employee.PositionFk);


                labelUserType.Text = UserType.Name;
                labelPosition.Text = Position.Name;


            }
        }

        private void listBoxSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var ctx = new DBContext()) 
            {
                var software = ctx.Softwares.SingleOrDefault(s => s.Id == (listBoxSoftware.SelectedItem as Software).Id);
                if (software == null)
                    return;


                var ProgressStatus = ctx.ProgressStatuses.SingleOrDefault(ps => ps.Id == software.ProgressStatusFk);
                var Project = ctx.Projects.SingleOrDefault(p => p.Id == software.ProjectFk);

                labelSoftwareName.Text = software.Name;
                labelProjectName.Text = Project != null ? Project.Name : "Не привязан к проекту";
                labelBeginDate.Text = software.BeginDateTime != null ? software.BeginDateTime.ToString() : "Нет данных";
                labelFinishDate.Text = software.LastUpdateDateTime != null ? software.LastUpdateDateTime.ToString() : "Нет данных";
                labelProgressState.Text = ProgressStatus.Name;
            }
        }

        private void circularButtonDownload_Click(object sender, EventArgs e)
        {
            // TODO...
        }
    }
}
