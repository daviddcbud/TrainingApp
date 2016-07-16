using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtLastName.Text + ", " + txtFirstname.Text;
            lblName.Text = name;
            var grade = "";
            if (rb10th.Checked)
            {
                grade = "10th";
            }
            lblName.Text += " is in " + grade + " grade";

            System.IO.File.WriteAllText("mydata.txt", lblName.Text); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmHobbies();
            frm.Show();
        }
    }
}
