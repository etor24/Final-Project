namespace WinFormsApp1
{
    partial class Register
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
            label1 = new Label();
            password = new TextBox();
            email = new TextBox();
            registerr = new Button();
            length = new Label();
            capital = new Label();
            lowercase = new Label();
            number = new Label();
            repassword = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("MingLiU_HKSCS-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(72, 40);
            label1.Name = "label1";
            label1.Size = new Size(199, 19);
            label1.TabIndex = 0;
            label1.Text = "Create Your Account";
            // 
            // password
            // 
            password.Location = new Point(119, 143);
            password.Name = "password";
            password.PasswordChar = '☆';
            password.PlaceholderText = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 2;
            password.TextChanged += password_TextChanged;
            password.Validating += password_Validating;
            // 
            // email
            // 
            email.Location = new Point(119, 114);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 1;
            email.Validating += email_Validating;
            // 
            // registerr
            // 
            registerr.Location = new Point(128, 284);
            registerr.Name = "registerr";
            registerr.Size = new Size(75, 23);
            registerr.TabIndex = 5;
            registerr.Text = "register";
            registerr.UseVisualStyleBackColor = true;
            registerr.Click += registerr_Click;
            // 
            // length
            // 
            length.AutoSize = true;
            length.BackColor = Color.Transparent;
            length.Location = new Point(58, 214);
            length.Name = "length";
            length.Size = new Size(70, 15);
            length.TabIndex = 6;
            length.Text = "8 characters";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.BackColor = Color.Transparent;
            capital.Location = new Point(58, 229);
            capital.Name = "capital";
            capital.Size = new Size(72, 15);
            capital.TabIndex = 7;
            capital.Text = "capital letter";
            // 
            // lowercase
            // 
            lowercase.AutoSize = true;
            lowercase.BackColor = Color.Transparent;
            lowercase.Location = new Point(58, 244);
            lowercase.Name = "lowercase";
            lowercase.Size = new Size(89, 15);
            lowercase.TabIndex = 8;
            lowercase.Text = "lowercase letter";
            // 
            // number
            // 
            number.AutoSize = true;
            number.BackColor = Color.Transparent;
            number.Location = new Point(58, 259);
            number.Name = "number";
            number.Size = new Size(49, 15);
            number.TabIndex = 9;
            number.Text = "number";
            // 
            // repassword
            // 
            repassword.Location = new Point(119, 172);
            repassword.Name = "repassword";
            repassword.PasswordChar = '☆';
            repassword.PlaceholderText = "retype password";
            repassword.Size = new Size(100, 23);
            repassword.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 199);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 11;
            label2.Text = "password must contain:";
            // 
            // button1
            // 
            button1.Location = new Point(128, 313);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(346, 411);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(repassword);
            Controls.Add(number);
            Controls.Add(lowercase);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(registerr);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(label1);
            Name = "Register";
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox password;
        private TextBox email;
        private Button registerr;
        private Label length;
        private Label capital;
        private Label lowercase;
        private Label number;
        private TextBox repassword;
        private Label label2;
        private Button button1;
    }
}