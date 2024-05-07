namespace WinFormsApp1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

            Register inf = new Register();
            inf.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login inf = new Login();
            inf.Show();
            this.Hide();

        }

        private void guest_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}