
namespace PR_5
{
    partial class Articles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh = new System.Windows.Forms.Button();
            this.addArticle = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delArt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.name,
            this.category,
            this.author,
            this.description,
            this.date,
            this.tag});
            this.list.Cursor = System.Windows.Forms.Cursors.Default;
            this.list.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 29);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1067, 384);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "№";
            this.number.Width = 50;
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.Width = 220;
            // 
            // category
            // 
            this.category.Text = "Категория";
            this.category.Width = 136;
            // 
            // author
            // 
            this.author.Text = "Автор";
            this.author.Width = 132;
            // 
            // description
            // 
            this.description.Text = "Статья";
            this.description.Width = 325;
            // 
            // date
            // 
            this.date.Text = "Дата";
            this.date.Width = 145;
            // 
            // tag
            // 
            this.tag.Text = "Тег";
            this.tag.Width = 129;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.Location = new System.Drawing.Point(1085, 76);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(89, 38);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // addArticle
            // 
            this.addArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArticle.Location = new System.Drawing.Point(1210, 84);
            this.addArticle.Name = "addArticle";
            this.addArticle.Size = new System.Drawing.Size(124, 52);
            this.addArticle.TabIndex = 2;
            this.addArticle.Text = "Добавить статью";
            this.addArticle.UseVisualStyleBackColor = true;
            this.addArticle.Click += new System.EventHandler(this.addArticle_Click);
            // 
            // addUser
            // 
            this.addUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUser.Location = new System.Drawing.Point(1210, 24);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(124, 54);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Добавить пользователя";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // addCat
            // 
            this.addCat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCat.Location = new System.Drawing.Point(1210, 142);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(124, 52);
            this.addCat.TabIndex = 4;
            this.addCat.Text = "Добавить категорию";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(1085, 33);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 37);
            this.search.TabIndex = 5;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1251, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delArt
            // 
            this.delArt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delArt.Location = new System.Drawing.Point(1085, 120);
            this.delArt.Name = "delArt";
            this.delArt.Size = new System.Drawing.Size(89, 28);
            this.delArt.TabIndex = 8;
            this.delArt.Text = "Удалить статью";
            this.delArt.UseVisualStyleBackColor = true;
            this.delArt.Click += new System.EventHandler(this.delArt_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1210, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить тег";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(1210, 258);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(124, 53);
            this.update.TabIndex = 10;
            this.update.Text = "Редактировать статью";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 427);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delArt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.addArticle);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.list);
            this.Name = "Articles";
            this.Text = "Articles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button addArticle;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addCat;
        public System.Windows.Forms.ColumnHeader category;
        protected System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delArt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader tag;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Button update;
    }
}