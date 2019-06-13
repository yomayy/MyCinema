namespace MyCinema
{
    partial class AdminForm
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
            this.AddFilmButt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1_AddFilm = new System.Windows.Forms.PictureBox();
            this.textBox3_addGener = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2_addDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_addTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddDirectorButt = new System.Windows.Forms.Button();
            this.textBox1_adDdirName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddGenerButt = new System.Windows.Forms.Button();
            this.textBox2_addGenerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1_Gener = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1_Director = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_AddFilm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFilmButt
            // 
            this.AddFilmButt.Location = new System.Drawing.Point(6, 157);
            this.AddFilmButt.Name = "AddFilmButt";
            this.AddFilmButt.Size = new System.Drawing.Size(276, 43);
            this.AddFilmButt.TabIndex = 0;
            this.AddFilmButt.Text = "Добавить фильм";
            this.AddFilmButt.UseVisualStyleBackColor = true;
            this.AddFilmButt.Click += new System.EventHandler(this.AddFilmButt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1_AddFilm);
            this.groupBox1.Controls.Add(this.textBox3_addGener);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2_addDirector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1_addTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddFilmButt);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильм";
            // 
            // pictureBox1_AddFilm
            // 
            this.pictureBox1_AddFilm.Location = new System.Drawing.Point(6, 206);
            this.pictureBox1_AddFilm.Name = "pictureBox1_AddFilm";
            this.pictureBox1_AddFilm.Size = new System.Drawing.Size(125, 99);
            this.pictureBox1_AddFilm.TabIndex = 7;
            this.pictureBox1_AddFilm.TabStop = false;
            // 
            // textBox3_addGener
            // 
            this.textBox3_addGener.Location = new System.Drawing.Point(6, 128);
            this.textBox3_addGener.Name = "textBox3_addGener";
            this.textBox3_addGener.Size = new System.Drawing.Size(276, 22);
            this.textBox3_addGener.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр:";
            // 
            // textBox2_addDirector
            // 
            this.textBox2_addDirector.Location = new System.Drawing.Point(6, 83);
            this.textBox2_addDirector.Name = "textBox2_addDirector";
            this.textBox2_addDirector.Size = new System.Drawing.Size(276, 22);
            this.textBox2_addDirector.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Режиссер:";
            // 
            // textBox1_addTitle
            // 
            this.textBox1_addTitle.Location = new System.Drawing.Point(6, 38);
            this.textBox1_addTitle.Name = "textBox1_addTitle";
            this.textBox1_addTitle.Size = new System.Drawing.Size(276, 22);
            this.textBox1_addTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBox1_Director);
            this.groupBox2.Controls.Add(this.AddDirectorButt);
            this.groupBox2.Controls.Add(this.textBox1_adDdirName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 311);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режиссер:";
            // 
            // AddDirectorButt
            // 
            this.AddDirectorButt.Location = new System.Drawing.Point(10, 83);
            this.AddDirectorButt.Name = "AddDirectorButt";
            this.AddDirectorButt.Size = new System.Drawing.Size(190, 67);
            this.AddDirectorButt.TabIndex = 2;
            this.AddDirectorButt.Text = "Добавить режиссера";
            this.AddDirectorButt.UseVisualStyleBackColor = true;
            this.AddDirectorButt.Click += new System.EventHandler(this.AddDirectorButt_Click);
            // 
            // textBox1_adDdirName
            // 
            this.textBox1_adDdirName.Location = new System.Drawing.Point(10, 43);
            this.textBox1_adDdirName.Name = "textBox1_adDdirName";
            this.textBox1_adDdirName.Size = new System.Drawing.Size(190, 22);
            this.textBox1_adDdirName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Имя:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1_Gener);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.AddGenerButt);
            this.groupBox3.Controls.Add(this.textBox2_addGenerName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(511, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 311);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Жанр:";
            // 
            // AddGenerButt
            // 
            this.AddGenerButt.Location = new System.Drawing.Point(10, 83);
            this.AddGenerButt.Name = "AddGenerButt";
            this.AddGenerButt.Size = new System.Drawing.Size(184, 67);
            this.AddGenerButt.TabIndex = 2;
            this.AddGenerButt.Text = "Добавить жанр";
            this.AddGenerButt.UseVisualStyleBackColor = true;
            this.AddGenerButt.Click += new System.EventHandler(this.AddGenerButt_Click);
            // 
            // textBox2_addGenerName
            // 
            this.textBox2_addGenerName.Location = new System.Drawing.Point(10, 43);
            this.textBox2_addGenerName.Name = "textBox2_addGenerName";
            this.textBox2_addGenerName.Size = new System.Drawing.Size(184, 22);
            this.textBox2_addGenerName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Название:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Список режиссеров:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Список жанров:";
            // 
            // listBox1_Gener
            // 
            this.listBox1_Gener.FormattingEnabled = true;
            this.listBox1_Gener.ItemHeight = 16;
            this.listBox1_Gener.Location = new System.Drawing.Point(10, 189);
            this.listBox1_Gener.Name = "listBox1_Gener";
            this.listBox1_Gener.ScrollAlwaysVisible = true;
            this.listBox1_Gener.Size = new System.Drawing.Size(184, 116);
            this.listBox1_Gener.TabIndex = 4;
            this.listBox1_Gener.SelectedIndexChanged += new System.EventHandler(this.listBox1_Gener_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "(Выберите из списка)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "(Выберите из списка)";
            // 
            // listBox1_Director
            // 
            this.listBox1_Director.FormattingEnabled = true;
            this.listBox1_Director.ItemHeight = 16;
            this.listBox1_Director.Location = new System.Drawing.Point(10, 189);
            this.listBox1_Director.Name = "listBox1_Director";
            this.listBox1_Director.ScrollAlwaysVisible = true;
            this.listBox1_Director.Size = new System.Drawing.Size(190, 116);
            this.listBox1_Director.TabIndex = 3;
            this.listBox1_Director.SelectedIndexChanged += new System.EventHandler(this.listBox1_Director_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_AddFilm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFilmButt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_addTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3_addGener;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_addDirector;
        private System.Windows.Forms.PictureBox pictureBox1_AddFilm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1_adDdirName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2_addGenerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddDirectorButt;
        private System.Windows.Forms.Button AddGenerButt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1_Gener;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1_Director;
    }
}