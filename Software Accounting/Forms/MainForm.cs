using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Accounting.Forms
{
    public partial class MainForm : Form
    {
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
                Close();
        }
    }
}
