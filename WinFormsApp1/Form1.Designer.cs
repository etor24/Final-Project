namespace WinFormsApp1
{
    partial class hp
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
            seeConcerts = new Button();
            editInfo = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Gabriola", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(192, 87);
            label1.Name = "label1";
            label1.Size = new Size(202, 35);
            label1.TabIndex = 0;
            label1.Text = "What would you like to do?";
            // 
            // seeConcerts
            // 
            seeConcerts.BackColor = Color.LavenderBlush;
            seeConcerts.Font = new Font("Segoe Script", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            seeConcerts.Location = new Point(233, 143);
            seeConcerts.Name = "seeConcerts";
            seeConcerts.Size = new Size(117, 23);
            seeConcerts.TabIndex = 2;
            seeConcerts.Text = "See Concerts";
            seeConcerts.UseVisualStyleBackColor = false;
            seeConcerts.Click += seeConcerts_Click;
            // 
            // editInfo
            // 
            editInfo.BackColor = Color.LavenderBlush;
            editInfo.Font = new Font("Segoe Script", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            editInfo.Location = new Point(244, 172);
            editInfo.Name = "editInfo";
            editInfo.Size = new Size(97, 23);
            editInfo.TabIndex = 3;
            editInfo.Text = "Edit Info";
            editInfo.UseVisualStyleBackColor = false;
            editInfo.Click += editInfo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(253, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.the_mann_center_concert_photo_by_snicole_for_the_mann_2200x1237px;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(594, 368);
            Controls.Add(button1);
            Controls.Add(editInfo);
            Controls.Add(seeConcerts);
            Controls.Add(label1);
            Name = "hp";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button seeConcerts;
        private Button editInfo;
        private Button button1;
    }
}