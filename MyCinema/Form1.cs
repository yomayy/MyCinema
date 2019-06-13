using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyCinema.Models;
using System.IO;

namespace MyCinema
{
    public partial class Form1 : Form
    {
        string conn_str;
        SqlConnection conn;

        DataSet ds;
        SqlDataAdapter da;

        List<Film> films;
        List<Gener> geners;
        List<Director> directors;
        List<Images> images;

        public Form1()
        {
            InitializeComponent();
            conn_str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KPI\TRPZ_c#\TRPZ_Laba6_Cinema\MyCinema\MyCinema\Cinema.mdf;Integrated Security=True";
            conn = new SqlConnection(conn_str);
            ds = new DataSet();
            Filldgv();

            films = new List<Film>();
            geners = new List<Gener>();
            directors = new List<Director>();
            images = new List<Images>();


            LoadGener();
            LoadDirector();
            LoadImage();

            comboBox_Gener.SelectedIndex = -1;
        }

        public void Filldgv()
        {
            conn.Open();
            string query = "SELECT * FROM Films";
            da = new SqlDataAdapter(query, conn);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        public void LoadGener()
        {
            conn.Open();
            string query = "SELECT * FROM Genres order by Id";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Gener g = new Gener()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"]
                };
                geners.Add(g);
                comboBox_Gener.Items.Add(g.Name);
            }

            conn.Close();
            comboBox_Gener.SelectedIndex = 0;
        }

        public void LoadDirector()
        {
            conn.Open();
            string query = "SELECT * FROM Directors order by Id";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Director d = new Director()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"]
                };
                directors.Add(d);
            }

            conn.Close();
        }

        public void LoadImage()
        {
            conn.Open();
            string query = "SELECT * FROM Image order by Id";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Images img = new Images()
                {
                    Id = (int)reader["Id"],
                    Path = (string)reader["Path"],
                    FilmId = (int)reader["FilmId"]
                };
                images.Add(img);
            }
            conn.Close();
        }

        public void SetPoster(int index)
        {
            string path = "";
            int fid = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString()); 
            string query = String.Format(
                "exec addImage '{0}', '{1}'",
                path, fid);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;

                var gen = geners.Where(
                    x => x.Id == Convert.ToInt32(
                        dataGridView1.Rows[i].Cells[3].Value.ToString())).FirstOrDefault();
                textBox_Genre.Text = gen.Name;

                var dir = directors.Where(
                    x => x.Id == Convert.ToInt32(
                        dataGridView1.Rows[i].Cells[2].Value.ToString())).FirstOrDefault();
                textBox_Director.Text = dir.Name;

                var img = images.Where(
                    x => x.FilmId == Convert.ToInt32(
                        dataGridView1.Rows[i].Cells[0].Value.ToString())).FirstOrDefault();

                pictureBox_Photo.Image = Image.FromFile(img.Path);
            }
            catch (Exception ex) { }
        }

        private void button_BuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicket bt = new BuyTicket();
            bt.Show();
        }

        private void comboBox_Gener_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Gener.SelectedIndex == -1)
            {
                ds.Clear();
                Filldgv();
            }
            else
            {
                ds.Clear();
                int index = comboBox_Gener.SelectedIndex;

                conn.Open();
                string query = "SELECT * FROM Films WHERE GenreId = " +
                    (index + 1).ToString();
                da = new SqlDataAdapter(query, conn);

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            Filldgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text == "admin" && textBox_Pass.Text == "admin")
            {
                //this.Hide();
                AdminForm af = new AdminForm();
                af.Show();
            }
            else
            {
                textBox_Username.Clear();
                textBox_Pass.Clear();
                MessageBox.Show("Your pass or username is not correct, try again","ooops", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            
        }
    }
}
