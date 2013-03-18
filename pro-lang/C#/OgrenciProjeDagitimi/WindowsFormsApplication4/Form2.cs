using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public string no, tes;
        public Form2(string numara)
        {

            no = numara;
            no = numara;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            listBox1.Items.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\C#\\nurettins.png");
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select ProjeAd from Odev where HocaID = 1",baglan);
            SqlDataReader okuyucu1 = kmt1.ExecuteReader();
            while (okuyucu1.Read())
            {
                listBox1.Items.Add(okuyucu1["ProjeAd"]);
                
            }
            baglan.Close();
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\C#\\erdal.png");
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select ProjeAd from Odev where HocaID = 4", baglan);
            SqlDataReader okuyucu1 = kmt1.ExecuteReader();
            while (okuyucu1.Read())
            {
                listBox1.Items.Add(okuyucu1["ProjeAd"]);

            }
            baglan.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\C#\\roktas.png");
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select ProjeAd from Odev where HocaID = 2", baglan);
            SqlDataReader okuyucu1 = kmt1.ExecuteReader();
            while (okuyucu1.Read())
            {
                listBox1.Items.Add(okuyucu1["ProjeAd"]);

            }
            baglan.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\C#\\22052009278_reasonably_small.jpg");
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select ProjeAd from Odev where HocaID = 3", baglan);
            SqlDataReader okuyucu1 = kmt1.ExecuteReader();
            while (okuyucu1.Read())
            {
                listBox1.Items.Add(okuyucu1["ProjeAd"]);

            }
            baglan.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ad, soyad, nmr, projeadi;
            nmr = no;
            ad = textBox3.Text.ToString();
            soyad = textBox4.Text.ToString();
            projeadi = textBox1.Text.ToString();
            Form3 frm3 = new Form3(ad, soyad, nmr, projeadi, tes);
            frm3.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox1.Text = listBox1.Text;
            textBox2.Text = no;
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select OgrenciAd,OgrenciSoyad from OgrenciBilgileri where OgrenciNo = '" + no + "'", baglan);
            SqlDataReader okuyucu1 = kmt1.ExecuteReader();
            while (okuyucu1.Read())
            {
                textBox4.Text = okuyucu1["OgrenciSoyad"].ToString();
                textBox3.Text = okuyucu1["OgrenciAd"].ToString();
                
            }
            baglan.Close();

            SqlConnection bag = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            bag.Open();
            SqlCommand kmt2 = new SqlCommand("select ProjeAciklama,ProjeTeslimTarihi from Odev where ProjeAd = '" + textBox1.Text.ToString() + "'", bag);
            SqlDataReader okuyucu2 = kmt2.ExecuteReader();
            while (okuyucu2.Read())
            {
                
                listBox2.Items.Add(okuyucu2["ProjeAciklama"].ToString());
                tes = okuyucu2["ProjeTeslimTarihi"].ToString();
            }
            bag.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\C#\\kerem.png");
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select ProjeAd from Odev where HocaID = 5", baglan);
            SqlDataReader okuyucu1 = kmt1.ExecuteReader();
            while (okuyucu1.Read())
            {
                listBox1.Items.Add(okuyucu1["ProjeAd"]);

            }
            baglan.Close();

        }
    }
}
