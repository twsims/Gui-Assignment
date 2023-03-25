namespace Gui_Assignment
{
    partial class PlayerRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerRegistration));
            plySubmit = new Button();
            label1 = new Label();
            v = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateOfBirth = new DateTimePicker();
            label2 = new Label();
            playerImage = new PictureBox();
            playerPosition = new Label();
            plyPosition = new ComboBox();
            playerClass = new Label();
            playerSchool = new Label();
            textBox4 = new TextBox();
            cmbPlayerClass = new ComboBox();
            lblPlayerAge = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox10 = new TextBox();
            comboBox1 = new ComboBox();
            playerPhoneNumber = new Label();
            textBox9 = new TextBox();
            button1 = new Button();
            calAge = new Button();
            playersAge = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            addAPlayerToolStripMenuItem = new ToolStripMenuItem();
            parentToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            addATeamToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)playerImage).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // plySubmit
            // 
            plySubmit.BackColor = Color.Plum;
            plySubmit.Location = new Point(541, 625);
            plySubmit.Margin = new Padding(3, 2, 3, 2);
            plySubmit.Name = "plySubmit";
            plySubmit.Size = new Size(130, 45);
            plySubmit.TabIndex = 0;
            plySubmit.Text = "Submit";
            plySubmit.UseVisualStyleBackColor = false;
            plySubmit.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 206);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            label1.Click += Label1_Click;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(156, 240);
            v.Name = "v";
            v.Size = new Size(99, 25);
            v.TabIndex = 2;
            v.Text = "Last Name:";
            v.Click += Label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 234);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(285, 203);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 31);
            textBox3.TabIndex = 6;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Format = DateTimePickerFormat.Short;
            dateOfBirth.Location = new Point(285, 268);
            dateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(152, 31);
            dateOfBirth.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 273);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth:";
            label2.Click += Label2_Click_1;
            // 
            // playerImage
            // 
            playerImage.BackColor = Color.Transparent;
            playerImage.Image = Properties.Resources.EBS_Logo;
            playerImage.InitialImage = null;
            playerImage.Location = new Point(1016, 203);
            playerImage.Margin = new Padding(3, 2, 3, 2);
            playerImage.Name = "playerImage";
            playerImage.Size = new Size(328, 348);
            playerImage.SizeMode = PictureBoxSizeMode.Zoom;
            playerImage.TabIndex = 11;
            playerImage.TabStop = false;
            playerImage.Click += PlayerImage_Click;
            // 
            // playerPosition
            // 
            playerPosition.AutoSize = true;
            playerPosition.Location = new Point(439, 480);
            playerPosition.Margin = new Padding(5, 0, 5, 0);
            playerPosition.Name = "playerPosition";
            playerPosition.Size = new Size(79, 25);
            playerPosition.TabIndex = 12;
            playerPosition.Text = "Position:";
            playerPosition.Click += Label4_Click;
            // 
            // plyPosition
            // 
            plyPosition.FormattingEnabled = true;
            plyPosition.Items.AddRange(new object[] { "PG", "SG", "SF", "PF", "C" });
            plyPosition.Location = new Point(528, 473);
            plyPosition.Margin = new Padding(5);
            plyPosition.Name = "plyPosition";
            plyPosition.Size = new Size(66, 33);
            plyPosition.TabIndex = 13;
            // 
            // playerClass
            // 
            playerClass.AutoSize = true;
            playerClass.Location = new Point(309, 576);
            playerClass.Margin = new Padding(5, 0, 5, 0);
            playerClass.Name = "playerClass";
            playerClass.Size = new Size(56, 25);
            playerClass.TabIndex = 14;
            playerClass.Text = "Class:";
            // 
            // playerSchool
            // 
            playerSchool.AutoSize = true;
            playerSchool.Location = new Point(303, 526);
            playerSchool.Margin = new Padding(5, 0, 5, 0);
            playerSchool.Name = "playerSchool";
            playerSchool.Size = new Size(70, 25);
            playerSchool.TabIndex = 15;
            playerSchool.Text = "School:";
            playerSchool.Click += Label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(389, 520);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.MaxLength = 50;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 31);
            textBox4.TabIndex = 16;
            // 
            // cmbPlayerClass
            // 
            cmbPlayerClass.FormattingEnabled = true;
            cmbPlayerClass.Items.AddRange(new object[] { "3rd", "4th", "5th", "6th", "7th", "8th", "Fresh", "Soph", "Junior", "Senior" });
            cmbPlayerClass.Location = new Point(389, 570);
            cmbPlayerClass.Margin = new Padding(5);
            cmbPlayerClass.Name = "cmbPlayerClass";
            cmbPlayerClass.Size = new Size(66, 33);
            cmbPlayerClass.TabIndex = 17;
            // 
            // lblPlayerAge
            // 
            lblPlayerAge.AutoSize = true;
            lblPlayerAge.Location = new Point(495, 573);
            lblPlayerAge.Margin = new Padding(5, 0, 5, 0);
            lblPlayerAge.Name = "lblPlayerAge";
            lblPlayerAge.Size = new Size(48, 25);
            lblPlayerAge.TabIndex = 18;
            lblPlayerAge.Text = "Age:";
            lblPlayerAge.Click += Label4_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(285, 302);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(309, 31);
            textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(285, 335);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(309, 31);
            textBox7.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 338);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 22;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 304);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 23;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 403);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 25;
            label6.Text = "E-mail:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(285, 403);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(309, 31);
            textBox8.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 370);
            label7.Name = "label7";
            label7.Size = new Size(55, 25);
            label7.TabIndex = 27;
            label7.Text = "State:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 371);
            label8.Name = "label8";
            label8.Size = new Size(41, 25);
            label8.TabIndex = 29;
            label8.Text = "Zip:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(419, 369);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(78, 31);
            textBox10.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            comboBox1.Location = new Point(285, 368);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(64, 33);
            comboBox1.TabIndex = 30;
            // 
            // playerPhoneNumber
            // 
            playerPhoneNumber.AutoSize = true;
            playerPhoneNumber.Location = new Point(156, 439);
            playerPhoneNumber.Name = "playerPhoneNumber";
            playerPhoneNumber.Size = new Size(66, 25);
            playerPhoneNumber.TabIndex = 32;
            playerPhoneNumber.Text = "Phone:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(285, 437);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(309, 31);
            textBox9.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(392, 625);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 33;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // calAge
            // 
            calAge.Location = new Point(461, 268);
            calAge.Name = "calAge";
            calAge.Size = new Size(133, 34);
            calAge.TabIndex = 34;
            calAge.Text = "Player's Age";
            calAge.UseVisualStyleBackColor = true;
            calAge.Click += button2_Click;
            // 
            // playersAge
            // 
            playersAge.AutoSize = true;
            playersAge.BorderStyle = BorderStyle.Fixed3D;
            playersAge.Location = new Point(552, 574);
            playersAge.Name = "playersAge";
            playersAge.Size = new Size(2, 27);
            playersAge.TabIndex = 35;
            playersAge.Click += playersAge_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playerToolStripMenuItem, parentToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1461, 33);
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(57, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.BackColor = SystemColors.ControlDark;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(270, 34);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAPlayerToolStripMenuItem, addATeamToolStripMenuItem });
            playerToolStripMenuItem.ForeColor = Color.White;
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(73, 29);
            playerToolStripMenuItem.Text = "Team";
            // 
            // addAPlayerToolStripMenuItem
            // 
            addAPlayerToolStripMenuItem.Name = "addAPlayerToolStripMenuItem";
            addAPlayerToolStripMenuItem.Size = new Size(270, 34);
            addAPlayerToolStripMenuItem.Text = "Add a Player";
            // 
            // parentToolStripMenuItem
            // 
            parentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            parentToolStripMenuItem.ForeColor = Color.White;
            parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            parentToolStripMenuItem.Size = new Size(84, 29);
            parentToolStripMenuItem.Text = "Parent";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(68, 29);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(225, 34);
            addToolStripMenuItem.Text = "Add a Parent";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // addATeamToolStripMenuItem
            // 
            addATeamToolStripMenuItem.Name = "addATeamToolStripMenuItem";
            addATeamToolStripMenuItem.Size = new Size(270, 34);
            addATeamToolStripMenuItem.Text = "Add a Team";
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Location = new Point(1126, 563);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 37;
            button2.Text = "Upload Pic";
            button2.UseVisualStyleBackColor = false;
            // 
            // PlayerRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.tbojoe_An_official_basketball_court_featuring_a_stunning_purple_2face9d9_5fa8_40d3_996e_5372bc7b91a1;
            ClientSize = new Size(1461, 811);
            Controls.Add(button2);
            Controls.Add(playersAge);
            Controls.Add(calAge);
            Controls.Add(button1);
            Controls.Add(playerPhoneNumber);
            Controls.Add(textBox9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBox10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(lblPlayerAge);
            Controls.Add(cmbPlayerClass);
            Controls.Add(textBox4);
            Controls.Add(playerSchool);
            Controls.Add(playerClass);
            Controls.Add(plyPosition);
            Controls.Add(playerPosition);
            Controls.Add(playerImage);
            Controls.Add(label2);
            Controls.Add(dateOfBirth);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(v);
            Controls.Add(label1);
            Controls.Add(plySubmit);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlayerRegistration";
            Text = "Player Registration";
            Load += PlayerRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)playerImage).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plySubmit;
        private Label label1;
        private Label v;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateOfBirth;
        private Label label2;
        private PictureBox playerImage;
        private Label playerPosition;
        private ComboBox plyPosition;
        private Label playerClass;
        private Label playerSchool;
        private TextBox textBox4;
        private ComboBox cmbPlayerClass;
        private Label lblPlayerAge;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox8;
        private Label label7;
        private Label label8;
        private TextBox textBox10;
        private ComboBox comboBox1;
        private Label playerPhoneNumber;
        private TextBox textBox9;
        private Button button1;
        private Button calAge;
        private Label playersAge;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem addAPlayerToolStripMenuItem;
        private ToolStripMenuItem parentToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem addATeamToolStripMenuItem;
        private Button button2;
    }
}