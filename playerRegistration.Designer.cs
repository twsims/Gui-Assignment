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
            textBox5 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)playerImage).BeginInit();
            SuspendLayout();
            // 
            // plySubmit
            // 
            plySubmit.BackColor = Color.Plum;
            plySubmit.Location = new Point(533, 585);
            plySubmit.Margin = new Padding(4, 2, 4, 2);
            plySubmit.Name = "plySubmit";
            plySubmit.Size = new Size(169, 58);
            plySubmit.TabIndex = 0;
            plySubmit.Text = "Submit";
            plySubmit.UseVisualStyleBackColor = false;
            plySubmit.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            label1.Click += Label1_Click;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(33, 92);
            v.Margin = new Padding(4, 0, 4, 0);
            v.Name = "v";
            v.Size = new Size(131, 32);
            v.TabIndex = 2;
            v.Text = "Last Name:";
            v.Click += Label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 85);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 45);
            textBox3.Margin = new Padding(4, 2, 4, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 39);
            textBox3.TabIndex = 6;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Format = DateTimePickerFormat.Short;
            dateOfBirth.Location = new Point(200, 128);
            dateOfBirth.Margin = new Padding(4, 2, 4, 2);
            dateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(197, 39);
            dateOfBirth.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth:";
            label2.Click += Label2_Click_1;
            // 
            // playerImage
            // 
            playerImage.Image = Properties.Resources.EBS_Logo;
            playerImage.InitialImage = null;
            playerImage.Location = new Point(639, 17);
            playerImage.Margin = new Padding(4, 2, 4, 2);
            playerImage.Name = "playerImage";
            playerImage.Size = new Size(484, 537);
            playerImage.SizeMode = PictureBoxSizeMode.Zoom;
            playerImage.TabIndex = 11;
            playerImage.TabStop = false;
            playerImage.Click += PlayerImage_Click;
            // 
            // playerPosition
            // 
            playerPosition.AutoSize = true;
            playerPosition.Location = new Point(401, 399);
            playerPosition.Margin = new Padding(6, 0, 6, 0);
            playerPosition.Name = "playerPosition";
            playerPosition.Size = new Size(103, 32);
            playerPosition.TabIndex = 12;
            playerPosition.Text = "Position:";
            playerPosition.Click += Label4_Click;
            // 
            // plyPosition
            // 
            plyPosition.FormattingEnabled = true;
            plyPosition.Items.AddRange(new object[] { "PG", "SG", "SF", "PF", "C" });
            plyPosition.Location = new Point(516, 391);
            plyPosition.Margin = new Padding(6);
            plyPosition.Name = "plyPosition";
            plyPosition.Size = new Size(84, 40);
            plyPosition.TabIndex = 13;
            // 
            // playerClass
            // 
            playerClass.AutoSize = true;
            playerClass.Location = new Point(232, 522);
            playerClass.Margin = new Padding(6, 0, 6, 0);
            playerClass.Name = "playerClass";
            playerClass.Size = new Size(72, 32);
            playerClass.TabIndex = 14;
            playerClass.Text = "Class:";
            // 
            // playerSchool
            // 
            playerSchool.AutoSize = true;
            playerSchool.Location = new Point(223, 458);
            playerSchool.Margin = new Padding(6, 0, 6, 0);
            playerSchool.Name = "playerSchool";
            playerSchool.Size = new Size(91, 32);
            playerSchool.TabIndex = 15;
            playerSchool.Text = "School:";
            playerSchool.Click += Label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 451);
            textBox4.Margin = new Padding(4, 2, 4, 2);
            textBox4.MaxLength = 50;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 39);
            textBox4.TabIndex = 16;
            // 
            // cmbPlayerClass
            // 
            cmbPlayerClass.FormattingEnabled = true;
            cmbPlayerClass.Items.AddRange(new object[] { "3rd", "4th", "5th", "6th", "7th", "8th", "Fresh", "Soph", "Junior", "Senior" });
            cmbPlayerClass.Location = new Point(336, 514);
            cmbPlayerClass.Margin = new Padding(6);
            cmbPlayerClass.Name = "cmbPlayerClass";
            cmbPlayerClass.Size = new Size(84, 40);
            cmbPlayerClass.TabIndex = 17;
            // 
            // lblPlayerAge
            // 
            lblPlayerAge.AutoSize = true;
            lblPlayerAge.Location = new Point(429, 514);
            lblPlayerAge.Margin = new Padding(6, 0, 6, 0);
            lblPlayerAge.Name = "lblPlayerAge";
            lblPlayerAge.Size = new Size(61, 32);
            lblPlayerAge.TabIndex = 18;
            lblPlayerAge.Text = "Age:";
            lblPlayerAge.Click += Label4_Click_1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(514, 514);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(86, 39);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(200, 171);
            textBox6.Margin = new Padding(4, 2, 4, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(400, 39);
            textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(200, 214);
            textBox7.Margin = new Padding(4, 2, 4, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(400, 39);
            textBox7.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 22;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 174);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 23;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 301);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 32);
            label6.TabIndex = 25;
            label6.Text = "E-mail:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(200, 301);
            textBox8.Margin = new Padding(4, 2, 4, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(400, 39);
            textBox8.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 259);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 32);
            label7.TabIndex = 27;
            label7.Text = "State:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 260);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 32);
            label8.TabIndex = 29;
            label8.Text = "Zip:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(374, 257);
            textBox10.Margin = new Padding(4, 2, 4, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 39);
            textBox10.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            comboBox1.Location = new Point(200, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 40);
            comboBox1.TabIndex = 30;
            // 
            // playerPhoneNumber
            // 
            playerPhoneNumber.AutoSize = true;
            playerPhoneNumber.Location = new Point(33, 347);
            playerPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            playerPhoneNumber.Name = "playerPhoneNumber";
            playerPhoneNumber.Size = new Size(87, 32);
            playerPhoneNumber.TabIndex = 32;
            playerPhoneNumber.Text = "Phone:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(200, 344);
            textBox9.Margin = new Padding(4, 2, 4, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(400, 39);
            textBox9.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(339, 585);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(169, 58);
            button1.TabIndex = 33;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // playerRegistration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1156, 668);
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
            Controls.Add(textBox5);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "playerRegistration";
            Text = "Player Registration";
            Load += PlayerRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)playerImage).EndInit();
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
        private TextBox textBox5;
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
    }
}