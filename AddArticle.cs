using MySql.Data.MySqlClient;
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
    public partial class AddArticle : Form
    {
        public AddArticle()
        {
            InitializeComponent();
            getCategory(categoryBox);
            getUser(authorBox);
            getTag(tagBox);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }
        // Добавление статьи в базу                            
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into article(name_article, id_category, id_tag, id_user, date, description) values('" + textBox1.Text + "', '" + Convert.ToString(categoryBox.SelectedIndex) + "', '" + Convert.ToString(tagBox.SelectedIndex)  + "', '" + Convert.ToString(authorBox.SelectedIndex) + "', '" + dateTimePicker1.Text + "', '" + articleBox.Text + "') ;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Статья добавлена");
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
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                        string row = rd.GetString(0);
                        box.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
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
                if(rd.HasRows)
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
        private void button2_Click(object sender, EventArgs e)
        {
            Articles Win = new Articles();
            Win.Show();
            this.Hide();
        }
    }
}
