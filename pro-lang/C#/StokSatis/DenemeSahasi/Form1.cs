using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DenemeSahasi
{
    public partial class Form1 : Form
    {
        Class1 nesne = new Class1();
        Form2 frm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=mengi;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
 
            string sifre, sifre_tekrar,mail,ad,soyad,kadi;
            kadi = textBox3.Text.ToString();
            ad = textBox4.Text.ToString().ToUpper();
            soyad = textBox5.Text.ToString().ToUpper();
            sifre = textBox6.Text.ToString();
            sifre_tekrar = textBox7.Text.ToString();
            mail = textBox8.Text.ToString();
            if (sifre != sifre_tekrar)
            {
                MessageBox.Show("Sifre Uyuşmazligi !!!");
                textBox7.Clear();
            }
             
            else if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                 MessageBox.Show("Lütfen gerekli boş alanları doldurunuz");
            }

            else if (mail != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Kayit1", baglanti);
                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                   
                    
                    if (mail.CompareTo(okuyucu["Posta"].ToString())== 0)
                    {
                        MessageBox.Show("E-posta kayıtlıdır baska bir E-posta giriniz");
                        textBox8.Clear();
                        break;
                        
                    }
                    else
                    {
                        string kisi = "insert into Kayit1(KullaniciAdi, Ad, Soyad, Sifre, Posta) values('" + kadi + "' , '" + ad + "' ,'" + soyad + "','" + sifre + "','" + mail + "')";
                        nesne.ekle(kisi);
                        MessageBox.Show("Kaydiniz basarıyla gercekleşmiştir");
                        break;

                    }
                }
                
                
                baglanti.Close();
               
            }
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
           

            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "")
            {
                MessageBox.Show("Gerekli yerleri doldurunuz !");
            }

            else if(textBox2.Text != "")
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=mengi;Integrated Security=True");
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("Select * From Kayit1 where KullaniciAdi ='"+textBox1.Text.ToString()+"'",baglanti);
                SqlDataReader okuyucu1 = komut1.ExecuteReader();

                while (okuyucu1.Read())
                {
                    if (textBox1.Text.ToString() == okuyucu1["KullaniciAdi"].ToString())
                    {
                        if (textBox2.Text.ToString() == okuyucu1["Sifre"].ToString())
                        {
                            //MessageBox.Show("Hos Geldiniz Alişverişe :)");
                            frm2.Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Sifre yanlis ...");
                            textBox2.Clear();
                            break;
                        }
                    }
                  
                    
                }
                //nesne.sil();
               
                baglanti.Close();
                
            }
           
        }
    }
}
