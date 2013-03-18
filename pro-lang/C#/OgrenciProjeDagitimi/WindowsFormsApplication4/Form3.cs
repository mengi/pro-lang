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
    public partial class Form3 : Form
    {
        public string surname, name,number,proisim,projetes;
        public Form3(string ad,string soyad,string numara,string projead, string tes)
        {
            name = ad;
            surname = soyad;
            number = numara;
            proisim = projead;
            projetes = tes;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            textBox5.Text = tarih.ToString("dd.MM.yyyy");

            textBox1.Text = proisim;
            textBox2.Text = name;
            textBox3.Text = surname;
            textBox4.Text = number;
            textBox6.Text = projetes; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt = new SqlCommand("DELETE FROM Sonuc WHERE Numara ='" + textBox4.Text.ToString() +"'" , baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();


            //sil();
            Form2 frm2 = new Form2(number);
            frm2.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt1 = new SqlCommand("select * from Sonuc",baglan);
            SqlDataReader okuyucu = kmt1.ExecuteReader();
            while (okuyucu.Read())
            {
                if (textBox4.Text.ToString().CompareTo(okuyucu["Numara"].ToString()) == 0)
                {
                    MessageBox.Show("Daha önceden bitirme projesi alimissiniz!!");
                    break;
                }
                else
                {
                    string ad = "insert into Sonuc(Ad, Soyad, Numara, ProjeAdi, AlimTarihi, TeslimTarihi) values('" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    ekle(ad);
                    break;
                }
                
            }
            baglan.Close();
            
        }
        

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            
        }
        public void sil()
        {
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            deneme.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = deneme;
            cmd.CommandText = "DELETE FROM Sonuc";
            cmd.ExecuteNonQuery();
            deneme.Close();
        }
        public void ekle(string query)
        {
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
            deneme.Open();
            SqlCommand cmd = new SqlCommand(query, deneme);
            cmd.ExecuteNonQuery();
            deneme.Close();

        }
    }
}
