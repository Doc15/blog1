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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            getRole(Role);
        }

        // переход на Articles
        private void back_Click(object sender, EventArgs e)
        {
            Articles Win = new Articles();
            Win.Show();
            this.Hide();
        }

        // кнопка добавления пользователя
        private void addBut_Click(object sender, EventArgs e)
        {
            string query = "insert into users (login, password, email, id_role) values ('" + logBox.Text + "', '" + passBox.Text + "', '" + emailBox.Text + "', '" + Convert.ToString(Role.SelectedIndex) + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Пользователь добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // выбор роли
        void getRole(ComboBox box)
        {
            string query = "select title_role from role";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string row = rd.GetString(0);
                        box.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
