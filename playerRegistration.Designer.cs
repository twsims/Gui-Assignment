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
            addATeamToolStripMenuItem = new ToolStripMenuItem();
            addAPlayerToolStripMenuItem = new ToolStripMenuItem();
            parentToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)playerImage).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // plySubmit
            // 
            plySubmit.BackColor = Color.Plum;
            plySubmit.Location = new Point(569, 443);
            plySubmit.Margin = new Padding(2, 1, 2, 1);
            plySubmit.Name = "plySubmit";
            plySubmit.Size = new Size(91, 27);
            plySubmit.TabIndex = 0;
            plySubmit.Text = "Submit";
            plySubmit.UseVisualStyleBackColor = false;
            plySubmit.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(213, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            label1.Click += Label1_Click;
            // 
            // v
            // 
            v.AutoSize = true;
            v.BackColor = Color.Transparent;
            v.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            v.ForeColor = Color.Transparent;
            v.Location = new Point(215, 149);
            v.Margin = new Padding(2, 0, 2, 0);
            v.Name = "v";
            v.Size = new Size(68, 15);
            v.TabIndex = 2;
            v.Text = "Last Name:";
            v.Click += Label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 141);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(296, 115);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 6;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Format = DateTimePickerFormat.Short;
            dateOfBirth.Location = new Point(297, 166);
            dateOfBirth.Margin = new Padding(2, 1, 2, 1);
            dateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(108, 23);
            dateOfBirth.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(200, 172);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth:";
            label2.Click += Label2_Click_1;
            // 
            // playerImage
            // 
            playerImage.BackColor = Color.Transparent;
            playerImage.Image = Properties.Resources.EBS_Logo;
            playerImage.InitialImage = null;
            playerImage.Location = new Point(615, 115);
            playerImage.Margin = new Padding(2, 1, 2, 1);
            playerImage.Name = "playerImage";
            playerImage.Size = new Size(230, 209);
            playerImage.SizeMode = PictureBoxSizeMode.Zoom;
            playerImage.TabIndex = 11;
            playerImage.TabStop = false;
            playerImage.Click += PlayerImage_Click;
            // 
            // playerPosition
            // 
            playerPosition.AutoSize = true;
            playerPosition.BackColor = Color.Transparent;
            playerPosition.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playerPosition.ForeColor = Color.Transparent;
            playerPosition.Location = new Point(432, 338);
            playerPosition.Margin = new Padding(4, 0, 4, 0);
            playerPosition.Name = "playerPosition";
            playerPosition.Size = new Size(54, 15);
            playerPosition.TabIndex = 12;
            playerPosition.Text = "Position:";
            playerPosition.Click += Label4_Click;
            // 
            // plyPosition
            // 
            plyPosition.FormattingEnabled = true;
            plyPosition.Items.AddRange(new object[] { "PG", "SG", "SF", "PF", "C" });
            plyPosition.Location = new Point(492, 335);
            plyPosition.Margin = new Padding(4, 3, 4, 3);
            plyPosition.Name = "plyPosition";
            plyPosition.Size = new Size(47, 23);
            plyPosition.TabIndex = 13;
            // 
            // playerClass
            // 
            playerClass.AutoSize = true;
            playerClass.BackColor = Color.Transparent;
            playerClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playerClass.ForeColor = Color.Transparent;
            playerClass.Location = new Point(450, 393);
            playerClass.Margin = new Padding(4, 0, 4, 0);
            playerClass.Name = "playerClass";
            playerClass.Size = new Size(36, 15);
            playerClass.TabIndex = 14;
            playerClass.Text = "Class:";
            // 
            // playerSchool
            // 
            playerSchool.AutoSize = true;
            playerSchool.BackColor = Color.Transparent;
            playerSchool.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playerSchool.ForeColor = Color.Transparent;
            playerSchool.Location = new Point(439, 364);
            playerSchool.Margin = new Padding(4, 0, 4, 0);
            playerSchool.Name = "playerSchool";
            playerSchool.Size = new Size(47, 15);
            playerSchool.TabIndex = 15;
            playerSchool.Text = "School:";
            playerSchool.Click += Label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(493, 361);
            textBox4.Margin = new Padding(2, 1, 2, 1);
            textBox4.MaxLength = 50;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 16;
            // 
            // cmbPlayerClass
            // 
            cmbPlayerClass.FormattingEnabled = true;
            cmbPlayerClass.Items.AddRange(new object[] { "3rd", "4th", "5th", "6th", "7th", "8th", "Fresh", "Soph", "Junior", "Senior" });
            cmbPlayerClass.Location = new Point(492, 388);
            cmbPlayerClass.Margin = new Padding(4, 3, 4, 3);
            cmbPlayerClass.Name = "cmbPlayerClass";
            cmbPlayerClass.Size = new Size(47, 23);
            cmbPlayerClass.TabIndex = 17;
            // 
            // lblPlayerAge
            // 
            lblPlayerAge.AutoSize = true;
            lblPlayerAge.BackColor = Color.Transparent;
            lblPlayerAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerAge.ForeColor = Color.Transparent;
            lblPlayerAge.Location = new Point(569, 393);
            lblPlayerAge.Margin = new Padding(4, 0, 4, 0);
            lblPlayerAge.Name = "lblPlayerAge";
            lblPlayerAge.Size = new Size(32, 15);
            lblPlayerAge.TabIndex = 18;
            lblPlayerAge.Text = "Age:";
            lblPlayerAge.Click += Label4_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(296, 195);
            textBox6.Margin = new Padding(2, 1, 2, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(218, 23);
            textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(296, 222);
            textBox7.Margin = new Padding(2, 1, 2, 1);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(218, 23);
            textBox7.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(253, 225);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 22;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(229, 198);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 23;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(239, 276);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 25;
            label6.Text = "E-mail:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(296, 273);
            textBox8.Margin = new Padding(2, 1, 2, 1);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(218, 23);
            textBox8.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(243, 252);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "State:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(370, 251);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 29;
            label8.Text = "Zip:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(402, 248);
            textBox10.Margin = new Padding(2, 1, 2, 1);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(56, 23);
            textBox10.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            comboBox1.Location = new Point(296, 248);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(46, 23);
            comboBox1.TabIndex = 30;
            // 
            // playerPhoneNumber
            // 
            playerPhoneNumber.AutoSize = true;
            playerPhoneNumber.BackColor = Color.Transparent;
            playerPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playerPhoneNumber.ForeColor = Color.Transparent;
            playerPhoneNumber.Location = new Point(239, 304);
            playerPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            playerPhoneNumber.Name = "playerPhoneNumber";
            playerPhoneNumber.Size = new Size(45, 15);
            playerPhoneNumber.TabIndex = 32;
            playerPhoneNumber.Text = "Phone:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(297, 301);
            textBox9.Margin = new Padding(2, 1, 2, 1);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(218, 23);
            textBox9.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(464, 443);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(91, 27);
            button1.TabIndex = 33;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // calAge
            // 
            calAge.Location = new Point(419, 165);
            calAge.Margin = new Padding(2);
            calAge.Name = "calAge";
            calAge.Size = new Size(93, 27);
            calAge.TabIndex = 34;
            calAge.Text = "Player's Age";
            calAge.UseVisualStyleBackColor = true;
            calAge.Click += button2_Click;
            // 
            // playersAge
            // 
            playersAge.AutoSize = true;
            playersAge.BackColor = Color.Transparent;
            playersAge.BorderStyle = BorderStyle.Fixed3D;
            playersAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            playersAge.ForeColor = Color.WhiteSmoke;
            playersAge.Location = new Point(609, 393);
            playersAge.Margin = new Padding(2, 0, 2, 0);
            playersAge.Name = "playersAge";
            playersAge.Size = new Size(2, 17);
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
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1144, 24);
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(38, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.BackColor = SystemColors.ControlDark;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(98, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addATeamToolStripMenuItem, addAPlayerToolStripMenuItem });
            playerToolStripMenuItem.ForeColor = Color.White;
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(49, 22);
            playerToolStripMenuItem.Text = "Team";
            // 
            // addATeamToolStripMenuItem
            // 
            addATeamToolStripMenuItem.Name = "addATeamToolStripMenuItem";
            addATeamToolStripMenuItem.Size = new Size(180, 22);
            addATeamToolStripMenuItem.Text = "Add a Team";
            // 
            // addAPlayerToolStripMenuItem
            // 
            addAPlayerToolStripMenuItem.Name = "addAPlayerToolStripMenuItem";
            addAPlayerToolStripMenuItem.Size = new Size(180, 22);
            addAPlayerToolStripMenuItem.Text = "Add a Player";
            addAPlayerToolStripMenuItem.Click += addAPlayerToolStripMenuItem_Click_1;
            // 
            // parentToolStripMenuItem
            // 
            parentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            parentToolStripMenuItem.ForeColor = Color.White;
            parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            parentToolStripMenuItem.Size = new Size(56, 22);
            parentToolStripMenuItem.Text = "Parent";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(145, 22);
            addToolStripMenuItem.Text = "Add a Parent";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(45, 22);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Location = new Point(686, 379);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(91, 27);
            button2.TabIndex = 37;
            button2.Text = "Upload Pic";
            button2.UseVisualStyleBackColor = false;
            // 
            // PlayerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.tbojoe_An_official_basketball_court_featuring_a_stunning_purple_2face9d9_5fa8_40d3_996e_5372bc7b91a1;
            ClientSize = new Size(1144, 573);
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
            Margin = new Padding(2, 1, 2, 1);
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
        private ToolStripMenuItem parentToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem addATeamToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem addAPlayerToolStripMenuItem;
    }
}