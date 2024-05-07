namespace WinFormsApp1
{
    partial class Concert
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
            dataGridView1 = new DataGridView();
            City = new ComboBox();
            Date = new ComboBox();
            Artist = new ComboBox();
            Genre = new ComboBox();
            reserve = new Button();
            label1 = new Label();
            back = new Button();
            clear = new Button();
            searchbar = new TextBox();
            concert_id = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumOrchid;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(474, 105);
            dataGridView1.TabIndex = 0;
            // 
            // City
            // 
            City.BackColor = Color.LemonChiffon;
            City.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            City.FormattingEnabled = true;
            City.Items.AddRange(new object[] { "Sofia", "Plovdiv" });
            City.Location = new Point(266, 118);
            City.Name = "City";
            City.Size = new Size(121, 37);
            City.TabIndex = 1;
            City.Text = "City";
            // 
            // Date
            // 
            Date.BackColor = Color.LemonChiffon;
            Date.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Date.FormattingEnabled = true;
            Date.Items.AddRange(new object[] { "2024-12-12", "2025-12-1", "2027-5-6" });
            Date.Location = new Point(520, 118);
            Date.Name = "Date";
            Date.Size = new Size(121, 37);
            Date.TabIndex = 2;
            Date.Text = "Date";
            // 
            // Artist
            // 
            Artist.BackColor = Color.LemonChiffon;
            Artist.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Artist.FormattingEnabled = true;
            Artist.Items.AddRange(new object[] { "Oingo Boingo", "Meow Meow", "Frank Sinatra" });
            Artist.Location = new Point(139, 118);
            Artist.Name = "Artist";
            Artist.Size = new Size(121, 37);
            Artist.TabIndex = 3;
            Artist.Text = "Artist";
            // 
            // Genre
            // 
            Genre.BackColor = Color.LemonChiffon;
            Genre.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Genre.FormattingEnabled = true;
            Genre.Items.AddRange(new object[] { "Pop", "Rock", "Jazz" });
            Genre.Location = new Point(393, 118);
            Genre.Name = "Genre";
            Genre.Size = new Size(121, 37);
            Genre.TabIndex = 4;
            Genre.Text = "Genre";
            // 
            // reserve
            // 
            reserve.BackColor = Color.LemonChiffon;
            reserve.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            reserve.Location = new Point(357, 288);
            reserve.Name = "reserve";
            reserve.Size = new Size(75, 23);
            reserve.TabIndex = 6;
            reserve.Text = "Reserve";
            reserve.UseVisualStyleBackColor = false;
            reserve.Click += reserve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Sylfaen", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(316, 75);
            label1.Name = "label1";
            label1.Size = new Size(149, 27);
            label1.TabIndex = 7;
            label1.Text = "Choose concert";
            // 
            // back
            // 
            back.BackColor = Color.LemonChiffon;
            back.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            back.Location = new Point(12, 12);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 8;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.LemonChiffon;
            clear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            clear.Location = new Point(438, 288);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 9;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // searchbar
            // 
            searchbar.Location = new Point(156, 26);
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "search";
            searchbar.Size = new Size(474, 23);
            searchbar.TabIndex = 10;
            searchbar.TextChanged += searchbar_TextChanged;
            // 
            // concert_id
            // 
            concert_id.Location = new Point(357, 317);
            concert_id.Name = "concert_id";
            concert_id.PlaceholderText = "concert_id";
            concert_id.Size = new Size(75, 23);
            concert_id.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(276, 288);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Concert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1000_F_363668823_e4qn6tjoEeaC0HftGZwTbfJKMe0nwShR;
            ClientSize = new Size(800, 403);
            Controls.Add(concert_id);
            Controls.Add(searchbar);
            Controls.Add(clear);
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(reserve);
            Controls.Add(button1);
            Controls.Add(Genre);
            Controls.Add(Artist);
            Controls.Add(Date);
            Controls.Add(City);
            Controls.Add(dataGridView1);
            Name = "Concert";
            Text = " ";
            Load += Concert_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox City;
        private ComboBox Date;
        private ComboBox Artist;
        private ComboBox Genre;
        private Button reserve;
        private Label label1;
        private Button back;
        private Button clear;
        private TextBox searchbar;
        private TextBox concert_id;
        private Button button1;
    }
}