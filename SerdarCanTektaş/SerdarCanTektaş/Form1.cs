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

namespace SerdarCanTektaş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PK1UMN1;Initial Catalog=rentcar;Integrated Security=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Bilgiler Boş Olamaz.");
                return;
            }

            if (GirisKontrol(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş başarılı");
                Form2 mainForm = new Form2();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Bilgiler Yanlış");
            }
        }
        private bool GirisKontrol(string kullaniciAdi, string sifre)
        {

            baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM adminpanel WHERE a_kullaniciad = @Kadi AND a_sifre = @sifre", baglanti);
            command.Parameters.AddWithValue("@Kadi", kullaniciAdi);
            command.Parameters.AddWithValue("@sifre", sifre);

            using (SqlDataReader reader = command.ExecuteReader())

            {
                return reader.HasRows;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'rentcarDataSet1.adminpanel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminpanelTableAdapter.Fill(this.rentcarDataSet1.adminpanel);


        }
    }
}
