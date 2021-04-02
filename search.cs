using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_5
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
            get_Info(dataGridView1);
        }


        // выборка знаений из таблицы
        void get_Info(DataGridView Grid)
        {
            string query = "select id_item, name_article, title, login, description, date, tag_title from article join category on id_cat=id_category join users on id_us=id_user join tags on id_t=id_tag;"; // запрос значений из таблицы
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dataGridView1.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6));
                    }
                } 
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // кнопка перехода на articles
        private void back_Click(object sender, EventArgs e)
        {
            Articles Win = new Articles();
            Win.Show();
            this.Hide();
        }


        // кнопка поиска
        private void searchBut_Click(object sender, EventArgs e)
        {
            
            string query = "select id_item, name_article, title, login, description, date, tag_title from article join category on id_cat=id_category join users on id_us=id_user join tags on id_t=id_tag  where concat(id_item, name_article, title, login, description, date, tag_title) like '%" + toSearch.Text+"%';"; // запрос значений из таблицы
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // выделение строки при клике
        private void dataGridView1_Click(object sender, EventArgs e)
        {

            IDbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            titleBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            catBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            authorBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            articleBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tagBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        // кнопка обновления
        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            get_Info(dataGridView1);
        }

       
    }
}
