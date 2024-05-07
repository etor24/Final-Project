namespace WinFormsApp1
{
    partial class Homepage
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
            register = new Button();
            button2 = new Button();
            guest = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // register
            // 
            register.BackColor = Color.PapayaWhip;
            register.Location = new Point(119, 172);
            register.Name = "register";
            register.Size = new Size(75, 23);
            register.TabIndex = 0;
            register.Text = "register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PapayaWhip;
            button2.Location = new Point(119, 201);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // guest
            // 
            guest.BackColor = Color.PapayaWhip;
            guest.Location = new Point(101, 230);
            guest.Name = "guest";
            guest.Size = new Size(110, 23);
            guest.TabIndex = 2;
            guest.Text = "Use as Guest";
            guest.UseVisualStyleBackColor = false;
            guest.Click += guest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OrangeRed;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(96, 35);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 3;
            label1.Text = "Welcome To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Ink Free", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "SoRaEv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(38, 9);
            label3.Name = "label3";
            label3.Size = new Size(242, 17);
            label3.TabIndex = 5;
            label3.Text = "**the best site 2024 for concert reservation";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 144);
            label4.Name = "label4";
            label4.Size = new Size(202, 15);
            label4.TabIndex = 6;
            label4.Text = "How would you like to enter the site?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(341, 316);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guest);
            Controls.Add(button2);
            Controls.Add(register);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register;
        private Button button2;
        private Button guest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}