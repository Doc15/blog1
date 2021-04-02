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
    public partial class all : Form
    {
        public all()
        {
            InitializeComponent();
            get_Info(dataGridView);
            getCategory(categoryBox);
            getUser(authorBox);
            getTag(tagBox);
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yyyy-MM-dd";
        }


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
                        dataGridView.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            get_Info(dataGridView);
            getCategory(categoryBox);
            getUser(authorBox);
            getTag(tagBox);
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yyyy-MM-dd";
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            main Win = new main();
            Win.Show();
            this.Hide();
        }


        // выбор категории
        void getCategory(ComboBox box)
        {
            string query = "select title from category";
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

        // выбор автора
        void getUser(ComboBox box1)
        {
            string query = "select login from users";
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
                        box1.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // выбор тега
        void getTag(ComboBox box2)
        {
            string query = "select tag_title from tags";
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
                        box2.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView_Сlick(object sender, EventArgs e)
        {
            IDbox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            titleBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            categoryBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            authorBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            articleBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            date.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            tagBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            string query = "select id_item, name_article, title, login, description, date, tag_title from article join category on id_cat=id_category join users on id_us=id_user join tags on id_t=id_tag  where concat(id_item, name_article, title, login, description, date, tag_title) like '%" + toSearch.Text + "%';"; // запрос значений из таблицы
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
                        dataGridView.Rows.Clear();
                        dataGridView.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6));
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
