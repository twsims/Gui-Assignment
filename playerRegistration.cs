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
 
 3/27/2023 - Update for Error exception handling I estimated roughly 2 hours to complete the process.
This was a bit more daunting than I expected as I had to account for the various patterns associated to phone number

4/5/2023 - Updated creating a function to add a player to a team and this hould have been roughly 4 hours but I have been dealing with some 
medical setbacks and I had a stroke recently and it has been difficult to concentrate. I wanted to loop through all the controls on the form to 
store the data, but still trying to perfect the for each for a specific control.  I am unsure if I need to store it in a list then send it to a file or just cycle through the controls and 
write it directly to the file.  I also have some issues with the Git push as it erased all my local data and I had to write the code over. So that was unexpected.  I created a text file to store text from one text box
and created a random generator to pick a jersey number for a player. Still a week behind now with having to write the code over I may be 10 days behind. 
 
 4/12/2023 - update to include the arrays and list with some user string functions.  This process was a little tedious as I had to figure out how to incorporate the assingment into my project.  I initially scheduled 10 hours to review all the lectures and read the chapters
related to the subject.  I was able to complete this section in a shorter time frame as I was able to understand the material quicker than expected.  I was able to add an array of players with a list of scores and utilizie string functions to display the information in a List box.
This does not have any significant impact on my project but it is something I can incorporate into the project once I fine tune what I want this project to be overall.

4/15/2023 - in this update I explored the use of inheritance and classes for my project.  This was scheduled to take roughly 4-6 hours but instead it took rougly 7-8 hours for me to fully grasp and unfortunately I am still learning the details here.  
THe update is on the Paren registration from instead of the player registration form. THe base class is person with 3 subclasses or derived classes.  They are Parent, Player and Coach.  I provided some small encapulsation by making sure the Parent 22 or older.  Once you hit the submit button on 
the parent registration form you will populate the inherited classes as they will loop through an array and a list of values associated to the parent, player and coach

4/22/2023 - This session was to make UI changes to simplify the user interface.  I am not a very creative person (design wise) so I made it as simple as I could.  The background image was very large which was causing an issue when loading
so I removed the 4K image and switched to a smoke gray background that allowed the white font to stand out.  Next was to properly align all the text boxes, date picker and combo boxes to allow for a simple interface.
This allowed the application to flow smoothly.  The user login screen we added a forgot username/password link that is currently only pointing to a website but I need to add a databse component to get that piece to work. THis took roughly 5 hours as I spent the majority of my time
reviewing UI sites to get a better understanding of interface design.   
 */

using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Schema;

namespace Gui_Assignment
{
    public partial class PlayerRegistration : Form
    {
        private static ParentRegistration? parentRegistrationForm;
        private static PlayerRegistration? playerRegistrationForm;
        private string[] roster;
        private List<List<int>> points;

        private Team myTeams = new Team();

        public class Team
        {
            public List<Player> Players { get; set; } = new List<Player>();
        }
        public void UpdateRoser(PlayerRegistration newPlayer)
        {
            //Clear List
            rosterList.Items.Clear();
            // Add Each plyaer to the Roster List
            foreach (Player player in myTeams.Players)
            {
                rosterList.Items.Add($"{player.Name} - ({player.Position})");
            }
        }

        public void AddPlayer(Team team, Player player)
        {
            team.Players.Add(player);
        }

        public PlayerRegistration()
        {
            InitializeComponent();
            InitializeRosterAndPoints();
        }

        private void InitializeRosterAndPoints()
        {
            // create a roster to store player names on the team
            roster = new string[] { "Xavier", "Austin", "Asim", "Miles", "Orion" };

            // create a list of points scored by each player
            points = new List<List<int>>();

            // create the points list for each player
            for (int i = 0; i < roster.Length; i++)
            {
                points.Add(new List<int>());
            }
            // Add the points scored for each game
            points[0].AddRange(new int[] { 11, 9, 15 });
            points[1].AddRange(new int[] { 9, 3, 11 });
            points[2].AddRange(new int[] { 20, 11, 12 });
            points[3].AddRange(new int[] { 7, 17, 9 });
            points[4].AddRange(new int[] { 15, 9, 13 });

        }

        private void DisplayRosterAndPoints()
        {
            rosterList.ClearSelected();
            for (int i = 0; i < roster.Length; i++)
            {
                rosterList.Items.Add($"{roster[i]}'s points: {string.Join(",", points[i])}" + Environment.NewLine); // using String function to join a string and int
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* This allows the parent to complete the player registation and open a new form to input 
             * parent information while hiding the player registration form*/
            MessageBox.Show("You have completed player registration! Please provide parent informaton");

            //Creating a streamwriter to send to a text file.
            StreamWriter playerFile = new StreamWriter("C:\\Users\\twsim\\OneDrive\\Documents\\UAT\\MS 539\\Playerfile.txt");

            try
            {
                playerFile.WriteLine(textBox2.Text);
                MessageBox.Show("Data saved properly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Flush the file and close the file
            playerFile.Flush();
            playerFile.Close();

            // display player and scores in List box



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

        private void textBox8_Leave(object sender, EventArgs e)
        {
            string emailAddress = textBox8.Text;

            if (IsValidEmail(emailAddress))
            {
                MessageBox.Show("The email address is valid");
            }
            else
            {
                MessageBox.Show("The email address is NOT valid!");
            }
        }
        public static bool IsValidEmail(string emailAddress)
        {
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                return false;
            }

            try
            {
                // I had to look up this string pattern to validate email address
                string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(emailAddress);
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            string phoneNumber = textBox9.Text;

            if (IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Looks like a good number.");
            }
            else
            {
                MessageBox.Show("This is not a phone number!");
            }
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }

            try
            {
                //I had to look up the pattern for checking for phone numbers
                string pattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(phoneNumber);
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Player newPlayer = new Player();
            {
                Name = textBox3.Text;
                string Position = plyPosition.Text;

            }
            AddPlayer(myTeams, newPlayer);
            // rosterList.ResetText();
            DisplayRosterAndPoints();
            //UpdateRoster() - Still implmenting this feature need additional assistance 
            Random JerseyNo = new Random();
            int randomNumber = JerseyNo.Next(1, 99);
            label9.Text = randomNumber.ToString();
            MessageBox.Show("Player added to the team");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}