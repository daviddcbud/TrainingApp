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
    public partial class frmHobbies : Form
    {
        public frmHobbies()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstHobbies.Items.Add(txtHobby.Text);
            txtHobby.Text = "";
        }
    }
}
