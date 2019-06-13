using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCinema.Models;

namespace MyCinema
{
    public partial class AdminForm : Form
    {
        string conn_str;
        SqlConnection conn;
      

        public AdminForm()
        {
            InitializeComponent();
            conn_str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KPI\TRPZ_c#\TRPZ_Laba6_Cinema\MyCinema\MyCinema\Cinema.mdf;Integrated Security=True";
            conn = new SqlConnection(conn_str);


            LoadDirectorToList();
            LoadGenerToList();
        }

        public void LoadGenerToList()
        {
            conn.Open();
            string query = "SELECT * FROM Genres ORDER BY Id";

            
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            
            try
            {
                
                while (reader.Read())
                {
                    Gener g = new Gener()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"]
                    };
                    listBox1_Gener.Items.Add(g.Name);
                }
                
               
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        public void LoadDirectorToList()
        {
            conn.Open();
            string query = "SELECT * FROM Directors ORDER BY Id";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                
                while (reader.Read())
                {
                    Director d = new Director()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"]
                    };
                    listBox1_Director.Items.Add(d.Name);
                }
                 
                conn.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            
        }

        private void AddFilmButt_Click(object sender, EventArgs e)
        {
            string title = textBox1_addTitle.Text;

            string directorId = Convert.ToString(listBox1_Director.SelectedIndex + 1);
            string generId = Convert.ToString(listBox1_Gener.SelectedIndex + 1);

            if(title == "" || directorId == "" || generId == "")
            {
                MessageBox.Show("Вы не заполнили все поля", "oops",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string source = ofd.FileName;
                    string target = $"..\\..\\Poster\\{ofd.SafeFileName}";
                    pictureBox1_AddFilm.Image = Image.FromFile(source);
                    File.Copy(source, target);

                    //film
                    string filmquery = String.Format(
                        "exec addFilm '{0}', '{1}', '{2}'",
                        title, Convert.ToInt32(directorId), Convert.ToInt32(generId));
                    conn.Open();
                    SqlCommand filmcommand = new SqlCommand(filmquery, conn);
                    filmcommand.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    string query = "SELECT MAX(Id) FROM Films";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    int filmId = 0;
                    while (reader.Read())
                    {
                        filmId = (int)reader.GetValue(0);
                    }

                    conn.Close();

                    //poster
                    string posterquery = String.Format(
                        "exec addImage '{0}', '{1}'",
                        target, filmId);
                    conn.Open();
                    SqlCommand postercommand = new SqlCommand(posterquery, conn);
                    postercommand.ExecuteNonQuery();    
                    conn.Close();


                   
                }
            }
        }

        private void AddDirectorButt_Click(object sender, EventArgs e)
        {
            string name = textBox1_adDdirName.Text;

            string query = String.Format(
                "exec addDirector '{0}'",
                name);

            if(name == "")
            {
                MessageBox.Show("Вы не ввели имя");
            }
            else
            {
                try
                {
                    //exec proc
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();

                    textBox1_adDdirName.Clear();
                    listBox1_Director.Items.Clear();
                    LoadDirectorToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        private void AddGenerButt_Click(object sender, EventArgs e)
        {
            string name = textBox2_addGenerName.Text;

            string query = String.Format(
                "exec addGener '{0}'",
                name);

            if (name == "")
            {
                MessageBox.Show("Вы не ввели название");
            }
            else
            {
                try
                {
                    //exec proc
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();

                    textBox2_addGenerName.Clear();
                    listBox1_Gener.Items.Clear();
                    LoadGenerToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void listBox1_Director_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                textBox2_addDirector.Text = listBox1_Director.SelectedItem.ToString();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listBox1_Gener_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3_addGener.Text = listBox1_Gener.SelectedItem.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
