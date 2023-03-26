/* Terrance Sims
   MS539 - Programming Concepts 
   GUI Assignment
   March 18, 2023

This assignment I initially expected this to take roughly 5 hours to complete.  
My expectation was to spend 1 hour per component.  However, I spend roughly 5 hours researching
and reviewing the course material.  Spent an additional 3 hours going back over the lectures to make
sure I did not miss any key topics.  The next step in building the forms took quite a bit of time roughly,
3-4 hours as I did not know how to properly align items and each component required some additional
research.  I believe the next assignment will be a considerable drop in time spent as the components needed
can be easily added.  I will spend more time on the syntax of the code I need versus understanding the component itself. 
 */

namespace Gui_Assignment
{
    public partial class PlayerRegistration : Form
    {
        private static ParentRegistration? parentRegistrationForm;
        private static PlayerRegistration? playerRegistrationForm;

        // int age;
        public PlayerRegistration()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* This allows the parent to complete the player registation and open a new form to input 
             * parent information while hiding the player registration form*/
            MessageBox.Show("You have completed player registration! Please provide parent informaton");
            parentRegistrationForm = new ParentRegistration();
            parentRegistrationForm.BringToFront();
            parentRegistrationForm.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void PlayerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click_2(object sender, EventArgs e)
        {

        }

        private void PlayerImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player Stats will be shown here!");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            // this closes the form
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid age");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime DateOfBirth = dateOfBirth.Value;
            DateTime Today = DateTime.Now;
            int plyrsAge = Today.Year - DateOfBirth.Year;

            if (DateOfBirth > Today.AddYears(-plyrsAge))
            {
                plyrsAge--;
            }
            MessageBox.Show("Your Age is " + plyrsAge);
            playersAge.Text = plyrsAge.ToString();

        }

        private void playersAge_Click(object sender, EventArgs e)
        {
            // playersAge.Text = plyrsAge;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* This allows the menu strip to go directly to the parent registration.  
             */
            MessageBox.Show("You have completed player registration! Please provide parent informaton");
            parentRegistrationForm = new ParentRegistration();
            parentRegistrationForm.BringToFront();
            parentRegistrationForm.Show();
            this.Hide();
        }

        private void addAPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAPlayerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /* This goes straight to the player registration from the menu selection. Then brings up the form and hides the menu selection*/
            MessageBox.Show("You have successfully logged in.  Welcome to EBS!");
            playerRegistrationForm = new PlayerRegistration();
            playerRegistrationForm.BringToFront();
            playerRegistrationForm.Show();
            //this.Hide();
        }
    }
}