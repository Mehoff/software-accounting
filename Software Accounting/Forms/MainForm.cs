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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверенны что хотите выйти из аккаунта?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            
            if(result == DialogResult.Yes)
            {
                Close();
                CurrentUser.LogOut();
            } 
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBarPercent_Scroll(object sender, EventArgs e)
        {
            var value = trackBarPercent.Value;
            if (value == 100)
            {
                labelPercent.Text = "Только готовые";
            }
            else if (value == 0) 
            {
                labelPercent.Text = "Только начатые";
            }
            else 
            {
                labelPercent.Text = $"От {value}%";
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new DBContext())
            {

                comboBoxCategory.DisplayMember = "Name";
                comboBoxCategory.ValueMember = "Id";

                comboBoxCategory.DataSource = ctx.UserTypes.ToList();



            }
        }
    }
}
