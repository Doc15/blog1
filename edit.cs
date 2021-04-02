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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
            get_Info(dataGridView);
            getCategory(categoryBox);
            getUser(authorBox);
            getTag(tagBox);
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yyyy-MM-dd"; 
        }
         
        //Вывод значений из таблицы Article
        void get_Info(DataGridView Grid)
        {
            string query = "select article.id_item, article.name_article, category.title, users.login, article.description, article.date, tags.tag_title from article join category on id_cat=id_category join users on id_us=id_user join tags on id_t=id_tag;"; // запрос значений из таблицы
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

        // выделение при клике
        private void dataGridView_Click(object sender, EventArgs e)
        {
            IDbox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            titleBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            categoryBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            authorBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            articleBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            date.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            tagBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        
        


        // кнопка редактирования
        private void update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE article SET name_article='" + titleBox.Text + "', id_category =" + Convert.ToString(categoryBox.SelectedIndex) + ", id_user=" + Convert.ToString(authorBox.SelectedIndex) + ", id_tag=" + Convert.ToString(tagBox.SelectedIndex) + ", date='" + date.Text + "', description='" + articleBox.Text + "' where id_item=" + IDbox.Text + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Статья отредактирована");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


        // возврат на Articles
        private void back_Click(object sender, EventArgs e)
        {
            Articles Win = new Articles();
            Win.Show();
            this.Hide();
        }

        // копка обновления
        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            get_Info(dataGridView);
        }
    }
}
