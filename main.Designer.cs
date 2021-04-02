namespace PR_5
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.addUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addTag = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.Articles = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.SystemColors.Control;
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUser.Location = new System.Drawing.Point(649, 498);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(124, 52);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Добавить пользователя";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(43)))), ((int)(((byte)(7)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(554, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main";
            // 
            // addTag
            // 
            this.addTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTag.Location = new System.Drawing.Point(811, 498);
            this.addTag.Name = "addTag";
            this.addTag.Size = new System.Drawing.Size(124, 52);
            this.addTag.TabIndex = 12;
            this.addTag.Text = "Добавить тег";
            this.addTag.UseVisualStyleBackColor = true;
            this.addTag.Click += new System.EventHandler(this.addTag_Click);
            // 
            // addCat
            // 
            this.addCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCat.Location = new System.Drawing.Point(968, 498);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(124, 52);
            this.addCat.TabIndex = 11;
            this.addCat.Text = "Добавить категорию";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // Articles
            // 
            this.Articles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Articles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Articles.Location = new System.Drawing.Point(1126, 498);
            this.Articles.Name = "Articles";
            this.Articles.Size = new System.Drawing.Size(124, 52);
            this.Articles.TabIndex = 10;
            this.Articles.Text = "Статьи";
            this.Articles.UseVisualStyleBackColor = true;
            this.Articles.Click += new System.EventHandler(this.Articles_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 563);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addTag);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.Articles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTag;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button Articles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}