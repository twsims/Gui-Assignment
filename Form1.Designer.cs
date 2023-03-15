namespace Gui_Assignment
{
    partial class playerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerRegistration));
            plySubmit = new Button();
            label1 = new Label();
            v = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateOfBirth = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            playerImage = new PictureBox();
            playerPosition = new Label();
            plyPosition = new ComboBox();
            playerClass = new Label();
            playerSchool = new Label();
            textBox4 = new TextBox();
            cmbPlayerClass = new ComboBox();
            lblPlayerAge = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerImage).BeginInit();
            SuspendLayout();
            // 
            // plySubmit
            // 
            plySubmit.Location = new Point(433, 406);
            plySubmit.Margin = new Padding(2, 1, 2, 1);
            plySubmit.Name = "plySubmit";
            plySubmit.Size = new Size(91, 27);
            plySubmit.TabIndex = 0;
            plySubmit.Text = "Submit";
            plySubmit.UseVisualStyleBackColor = true;
            plySubmit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(18, 43);
            v.Margin = new Padding(2, 0, 2, 0);
            v.Name = "v";
            v.Size = new Size(66, 15);
            v.TabIndex = 2;
            v.Text = "Last Name:";
            v.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 100);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 40);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 11);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 6;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new Point(150, 69);
            dateOfBirth.Margin = new Padding(2, 1, 2, 1);
            dateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(217, 23);
            dateOfBirth.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth:";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 10;
            label3.Text = "Parent Guardian:";
            // 
            // playerImage
            // 
            playerImage.Image = Properties.Resources.EBS_Logo;
            playerImage.InitialImage = null;
            playerImage.Location = new Point(433, 16);
            playerImage.Margin = new Padding(2, 1, 2, 1);
            playerImage.Name = "playerImage";
            playerImage.Size = new Size(200, 187);
            playerImage.SizeMode = PictureBoxSizeMode.Zoom;
            playerImage.TabIndex = 11;
            playerImage.TabStop = false;
            // 
            // playerPosition
            // 
            playerPosition.AutoSize = true;
            playerPosition.Location = new Point(433, 220);
            playerPosition.Name = "playerPosition";
            playerPosition.Size = new Size(53, 15);
            playerPosition.TabIndex = 12;
            playerPosition.Text = "Position:";
            playerPosition.Click += label4_Click;
            // 
            // plyPosition
            // 
            plyPosition.FormattingEnabled = true;
            plyPosition.Items.AddRange(new object[] { "PG", "SG", "SF", "PF", "C" });
            plyPosition.Location = new Point(489, 217);
            plyPosition.Name = "plyPosition";
            plyPosition.Size = new Size(47, 23);
            plyPosition.TabIndex = 13;
            // 
            // playerClass
            // 
            playerClass.AutoSize = true;
            playerClass.Location = new Point(433, 282);
            playerClass.Name = "playerClass";
            playerClass.Size = new Size(37, 15);
            playerClass.TabIndex = 14;
            playerClass.Text = "Class:";
            // 
            // playerSchool
            // 
            playerSchool.AutoSize = true;
            playerSchool.Location = new Point(433, 252);
            playerSchool.Name = "playerSchool";
            playerSchool.Size = new Size(46, 15);
            playerSchool.TabIndex = 15;
            playerSchool.Text = "School:";
            playerSchool.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(489, 244);
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
            cmbPlayerClass.Location = new Point(489, 274);
            cmbPlayerClass.Name = "cmbPlayerClass";
            cmbPlayerClass.Size = new Size(47, 23);
            cmbPlayerClass.TabIndex = 17;
            // 
            // lblPlayerAge
            // 
            lblPlayerAge.AutoSize = true;
            lblPlayerAge.Location = new Point(546, 279);
            lblPlayerAge.Name = "lblPlayerAge";
            lblPlayerAge.Size = new Size(31, 15);
            lblPlayerAge.TabIndex = 18;
            lblPlayerAge.Text = "Age:";
            lblPlayerAge.Click += label4_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(580, 279);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 19;
            label4.Text = "label4";
            label4.Click += label4_Click_2;
            // 
            // playerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(673, 464);
            Controls.Add(label4);
            Controls.Add(lblPlayerAge);
            Controls.Add(cmbPlayerClass);
            Controls.Add(textBox4);
            Controls.Add(playerSchool);
            Controls.Add(playerClass);
            Controls.Add(plyPosition);
            Controls.Add(playerPosition);
            Controls.Add(playerImage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateOfBirth);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(v);
            Controls.Add(label1);
            Controls.Add(plySubmit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "playerRegistration";
            Text = "Player Registration";
            Load += playerRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)playerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plySubmit;
        private Label label1;
        private Label v;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateOfBirth;
        private Label label2;
        private Label label3;
        private PictureBox playerImage;
        private Label playerPosition;
        private ComboBox plyPosition;
        private Label playerClass;
        private Label playerSchool;
        private TextBox textBox4;
        private ComboBox cmbPlayerClass;
        private Label lblPlayerAge;
        private Label label4;
    }
}