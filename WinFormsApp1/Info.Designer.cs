namespace WinFormsApp1
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            email = new TextBox();
            firstname = new TextBox();
            lastname = new TextBox();
            number = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            imageList1 = new ImageList(components);
            label2 = new Label();
            buttonCheckAge = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(99, 279);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(275, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "I consent to the Policy and Terms of Conditions";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // email
            // 
            email.BackColor = Color.Thistle;
            email.Location = new Point(176, 164);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(100, 23);
            email.TabIndex = 1;
            email.Validating += email_Validating;
            // 
            // firstname
            // 
            firstname.BackColor = Color.Thistle;
            firstname.Location = new Point(176, 77);
            firstname.Name = "firstname";
            firstname.PlaceholderText = "First Name";
            firstname.Size = new Size(100, 23);
            firstname.TabIndex = 2;
            firstname.Validating += firstname_Validating;
            // 
            // lastname
            // 
            lastname.BackColor = Color.Thistle;
            lastname.Location = new Point(176, 106);
            lastname.Name = "lastname";
            lastname.PlaceholderText = "Last Name";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 3;
            lastname.Validating += lastname_Validating;
            // 
            // number
            // 
            number.BackColor = Color.Thistle;
            number.Location = new Point(176, 135);
            number.Name = "number";
            number.PlaceholderText = "Phone Number";
            number.Size = new Size(100, 23);
            number.TabIndex = 4;
            number.Validating += number_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(188, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumPurple;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 33);
            label1.Name = "label1";
            label1.Size = new Size(257, 24);
            label1.TabIndex = 7;
            label1.Text = "Enter Personal Information";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(164, 207);
            label2.Name = "label2";
            label2.Size = new Size(157, 18);
            label2.TabIndex = 8;
            label2.Text = "Enter your date of birth";
            // 
            // buttonCheckAge
            // 
            buttonCheckAge.Location = new Point(188, 250);
            buttonCheckAge.Name = "buttonCheckAge";
            buttonCheckAge.Size = new Size(75, 23);
            buttonCheckAge.TabIndex = 9;
            buttonCheckAge.Text = "Check Age";
            buttonCheckAge.UseVisualStyleBackColor = true;
            buttonCheckAge.Click += buttonCheckAge_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(479, 364);
            Controls.Add(buttonCheckAge);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(number);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(email);
            Controls.Add(checkBox1);
            Name = "Info";
            Text = "Form4";
            Load += Info_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox email;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox number;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ImageList imageList1;
        private Label label2;
        private Button buttonCheckAge;
    }
}