using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace PR_5
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        // exit
        private void exitBut_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        // login
        private void logBut_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string query = "select count(*) from users where login= '" + logBox.Text + "'and password='" + passBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Count > 0)
            {
                Articles Win = new Articles();
                Win.Show();
                this.Hide();
            }
            else MessageBox.Show("Ошибка");
        }
    }
}
