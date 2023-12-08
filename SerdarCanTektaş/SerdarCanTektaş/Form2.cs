using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerdarCanTektaş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PK1UMN1;Initial Catalog=rentcar;Integrated Security=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            string durum = radioButton1.Checked ? "Kiralandı" : "Hala Kiralık";



            baglanti.Open();
                string sqlQuery = "UPDATE arabalar SET aracdurum = @Durum WHERE arabaad = @arabaad";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, baglanti))
                {
                    cmd.Parameters.AddWithValue("@Durum", durum);
                    cmd.Parameters.AddWithValue("@arabaad", comboBox1.Text);
                    cmd.ExecuteNonQuery();
                }
            baglanti.Close();

            MessageBox.Show("Durum başarıyla güncellendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from arabalar", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitsil = new SqlCommand("delete from arabalar where arabaad=@arabaad", baglanti);
            kayitsil.Parameters.AddWithValue("@arabaad", comboBox1.Text);
            kayitsil.ExecuteNonQuery();
            MessageBox.Show("Araba Listeden Kaldırıldı.");
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                string arabaAdi = comboBox1.Text;
                string aracDurumu = radioButton1.Checked ? "Kiralandı" : "Hala Kiralık";


                baglanti.Open();

                SqlCommand arabaekle = new SqlCommand("insert into arabalar(arabaad,aracdurum) values(@ArabaAdi,@AracDurumu)", baglanti);
                arabaekle.Parameters.AddWithValue("@ArabaAdi", arabaAdi);
                arabaekle.Parameters.AddWithValue("@AracDurumu", aracDurumu);
                arabaekle.ExecuteNonQuery();
                MessageBox.Show("Araba başarıyla eklendi.");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir araba adı yazın.");
            }
        }
    }
}
