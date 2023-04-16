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

public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }    
        public int Age { get; set; }

        public Person(string name, string lName, int age)
        {
            firstName = name;
            lastName = lName;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
           MessageBox.Show($" First Name: {firstName}, Last Name: {lastName}, Age: {Age}", "From base class");
        }
    }

   //Derived Class: Parent
    public class Parent : Person
    {
        public string Child
            {
                get; set;
            }   
    public Parent(string name, string lName, int age, string child) : base(name, lName, age)
            {
                Child = child; 

                //Encapsulation here to check for appropriate age if they are < 22 the system will automatically set the age to 22
                if (age < 22) 
                {
                   age = 22;                    
                }
            }
        public override void DisplayInfo()
            {
                MessageBox.Show($"Parent - Name: {firstName}, Last Name: {lastName}, Age: {Age}, Child: {Child}", "From Parent Class");
            }
    }

     // Derived class: Player
    public class Player : Person
    {
        public string Position
        {
            get; set; }

    public Player(string name, string lastName, int age, string position) : base(name, lastName, age)
        {
            Position = position;
        }

        public override void DisplayInfo()
        {
            MessageBox.Show($"Player - Name: {firstName}, Last Name: {lastName}, Age: {Age}, Position: {Position}", "From Player Class (inherited)");
        }
    }

    // Derived class: Coach
    public class Coach : Person
    {
        public string Specialty
        {
            get; set; }

    public Coach(string name, string lastName, int age, string specialty) : base(name, lastName, age)
        {
            Specialty = specialty;
        }

        public override void DisplayInfo()
        {
            MessageBox.Show($"Coach - Name: {firstName}, Last Name: {lastName}, Age: {Age}, Specialty: {Specialty}", "From Coach Class (inherited)");
        }
    }

    private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ParSubmit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("You have added parent information to your player's profile. Please review Conduct Policy");
            // Create instances of Parent, player and coach
            Player player = new Player("Xavier", "Sims", 13, "Point Guard");
            Coach coach = new Coach("Terrance", "Sims", 47, "Fundamentals");
            Parent parent = new Parent("Meah", "Sims", 44, "Xavier Sims");

            // Call DisplayInfo() on each instance
            player.DisplayInfo(); 
            coach.DisplayInfo();  
            parent.DisplayInfo();
           
            // Create an array of Person references and call DisplayInfo() on each element
            Person[] people = new Person[] { player, coach, parent };
          
            // this section is only required if we have people in the person class, but we only need to call the displayinfo for the player and coach using this foreach loop will only cycle through the player and coach twice

          /*  foreach (Person person in people)
            {
                person.DisplayInfo();
            } */
            this.Close();
        }

        private void BtnParentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParentRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
