using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Assignment
{
    public partial class ParentRegistration : Form
    {
        public ParentRegistration()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ParSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have added parent information to your player's profile. Please review Conduct Policy");
            this.Close();
        }

        private void BtnParentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
