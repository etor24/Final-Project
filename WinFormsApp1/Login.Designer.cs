namespace WinFormsApp1
{
    partial class Login
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
            password = new TextBox();
            email = new TextBox();
            label1 = new Label();
            button1 = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // password
            // 
            password.Location = new Point(91, 175);
            password.Name = "password";
            password.PasswordChar = '☆';
            password.PlaceholderText = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(91, 120);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 2;
            email.TextChanged += email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 63);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 3;
            label1.Text = "Login Your Account";
            // 
            // button1
            // 
            button1.Location = new Point(102, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // back
            // 
            back.Location = new Point(102, 251);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 5;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(292, 383);
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(email);
            Controls.Add(password);
            Name = "Login";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox password;
        private TextBox email;
        private Label label1;
        private Button button1;
        private Button back;
    }
}