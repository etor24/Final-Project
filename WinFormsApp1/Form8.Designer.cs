namespace WinFormsApp1
{
    partial class Form8
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
            cardName = new TextBox();
            cardNumber = new TextBox();
            cvc = new TextBox();
            label1 = new Label();
            expDate = new TextBox();
            pay = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // cardName
            // 
            cardName.Location = new Point(211, 92);
            cardName.Name = "cardName";
            cardName.PlaceholderText = "Cardholder Name";
            cardName.Size = new Size(157, 23);
            cardName.TabIndex = 0;
            cardName.Validating += cardName_Validating;
            // 
            // cardNumber
            // 
            cardNumber.Location = new Point(211, 131);
            cardNumber.Name = "cardNumber";
            cardNumber.PlaceholderText = "Card Number";
            cardNumber.Size = new Size(157, 23);
            cardNumber.TabIndex = 1;
            cardNumber.Validating += cardNumber_Validating;
            // 
            // cvc
            // 
            cvc.Location = new Point(232, 169);
            cvc.Name = "cvc";
            cvc.PlaceholderText = "CVC";
            cvc.Size = new Size(100, 23);
            cvc.TabIndex = 2;
            cvc.Validating += cvc_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(187, 52);
            label1.Name = "label1";
            label1.Size = new Size(199, 18);
            label1.TabIndex = 4;
            label1.Text = "Enter Your Credit Information";
            // 
            // expDate
            // 
            expDate.Location = new Point(232, 198);
            expDate.Name = "expDate";
            expDate.PlaceholderText = "MM/YY";
            expDate.Size = new Size(100, 23);
            expDate.TabIndex = 5;
            expDate.Validating += expDate_Validating;
            // 
            // pay
            // 
            pay.BackColor = Color.PaleVioletRed;
            pay.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            pay.Location = new Point(222, 258);
            pay.Name = "pay";
            pay.Size = new Size(122, 23);
            pay.TabIndex = 7;
            pay.Text = "Pay and continue";
            pay.UseVisualStyleBackColor = false;
            pay.Click += pay_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Location = new Point(246, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "go back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ticket_type_dance_booths_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(578, 385);
            Controls.Add(button1);
            Controls.Add(pay);
            Controls.Add(expDate);
            Controls.Add(label1);
            Controls.Add(cvc);
            Controls.Add(cardNumber);
            Controls.Add(cardName);
            DoubleBuffered = true;
            Name = "Form8";
            Text = "payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cardName;
        private TextBox cardNumber;
        private TextBox cvc;
        private Label label1;
        private TextBox expDate;
        private Button pay;
        private Button button1;
    }
}