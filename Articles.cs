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
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
            get_Info(list);
        }
        // Вывод значений из таблицы Article в listview
        void get_Info(ListView List)
        {
            string query = "select article.id_item, article.name_article, category.title, users.login, article.description, article.date, tags.tag_title from article join category on id_cat=id_category join users on id_us=id_user join tags on id_t=id_tag;"; // запрос значений из таблицы
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // кнопка обновления значений в таблице 
        private void Refresh_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            get_Info(list);
        }
        // перехд на форму добавления статьи
        private void addArticle_Click(object sender, EventArgs e)
        {
            AddArticle Win = new AddArticle();
            Win.Show();
            this.Hide();
        }
        // перехд на форму регистрации
        private void addUser_Click(object sender, EventArgs e)
        {
            Register Win = new Register();
            Win.Show();
            this.Hide();
        }

        // переход на форму добавдения категории 
        private void addCat_Click(object sender, EventArgs e)
        {
            AddCategory Win = new AddCategory();
            Win.Show();
            this.Hide();
        }

        // выход из приложения
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // кнопка поиска
        private void search_Click(object sender, EventArgs e)
        {
            search Win = new search();
            Win.Show();
            this.Hide();
        }




        // удаление записи из таблицы Article
        private void delArt_Click(object sender, EventArgs e)
        {
            string query = "delete from article where id_item = '" + list.Items[list.SelectedIndices[0]].Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    foreach(ListViewItem item in list.SelectedItems)
                    {
                    list.Items.Remove(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        // добавление тега
        private void button2_Click(object sender, EventArgs e)
        {
            AddTag Win = new AddTag();
            Win.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            edit Win = new edit();
            Win.Show();
            this.Hide();
        }
    }
}
