using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_5
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register Win = new Register();
            Win.Show();
            this.Hide();
        }

        private void addTag_Click(object sender, EventArgs e)
        {
            AddTag Win = new AddTag();
            Win.Show();
            this.Hide();
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            AddCategory Win = new AddCategory();
            Win.Show();
            this.Hide();
        }

        private void Articles_Click(object sender, EventArgs e)
        {
            all Win = new all();
            Win.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
