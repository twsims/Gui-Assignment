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
    public partial class userLogin : Form
    {
        private static PlayerRegistration? PlayerRegistrationForm;
        public userLogin()
        {
            InitializeComponent();
        }
        private void DisplayLoadingScreen()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(DisplayLoadingScreen));
                return;
            }
            using (LoadingScreen loadingScreen = new LoadingScreen())
            {
                loadingScreen.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* This allows the parent to complete the player registation and open a new form to input 
            * parent information while hiding the player registration form*/
            MessageBox.Show("You have successfully logged in.  Welcome to EBS!");
            PlayerRegistrationForm = new PlayerRegistration();
            PlayerRegistrationForm.BringToFront();
            PlayerRegistrationForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            string url = "http://www.eastbaysoldiers.org";
            System.Diagnostics.Process.Start(url);
        }

        private void userLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
