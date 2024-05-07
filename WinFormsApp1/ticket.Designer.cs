namespace WinFormsApp1
{
    partial class ticket
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
            price = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Microsoft Himalaya", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 286);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "Total Price";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(329, 286);
            price.Name = "price";
            price.Size = new Size(13, 15);
            price.TabIndex = 3;
            price.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSeaGreen;
            label5.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(207, 26);
            label5.Name = "label5";
            label5.Size = new Size(161, 17);
            label5.TabIndex = 4;
            label5.Text = "Choose Your Seats";
            // 
            // panel1
            // 
            panel1.Location = new Point(89, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 200);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(443, 281);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(31, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.parklife_live_720x405_1206;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 359);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(price);
            Controls.Add(label1);
            Name = "ticket";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label price;
        private Label label5;
        private Panel panel1;
        private Button button1;
        private Button button2;
    }
}