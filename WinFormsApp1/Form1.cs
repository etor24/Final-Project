using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class hp : Form
    {
        string email;
        public hp(string email_)
        {
            InitializeComponent();
            email = email_;
        }

        private void editInfo_Click(object sender, EventArgs e)
        {
            Info form = new Info(email);
            form.Show();
            this.Hide();
        }

        private void seeConcerts_Click(object sender, EventArgs e)
        {
            Concert form = new Concert(email);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage form = new Homepage();
            form.Show();
            this.Hide();
        }
    }
}
