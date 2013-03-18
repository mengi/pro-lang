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
    
    public partial class Form2 : Form
    {
        Form3 frm3 = new Form3();
        Class1 nesne = new Class1();
        int fiyat, toplam, taksit, adet, tutar, i, a, stok, kdv;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label8.Text = DateTime.Now.ToString("dd.MM.yyyy                                                                                                                   hh:mm:ss"); //labelde tarih saati göstersin dedim

            button2.Enabled = false;//satın al butonunu form yüklenirken pasif ettim

            a = 10;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bilgisayar")
            {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Asus");
                comboBox2.Items.Add("Samsung - X");
                comboBox2.Items.Add("Toshiba");
                comboBox2.Items.Add("Lenova");
                comboBox2.Items.Add("Casper");

                comboBox2.Items.Add("Acer");

                comboBox2.Items.Add("Exper");

            }

            if (comboBox1.Text == "Cep Telefonu")
            {

                comboBox2.Items.Clear();

                comboBox2.Items.Add("Nokia");

                comboBox2.Items.Add("Samsung");

                comboBox2.Items.Add("LG");

            }

            if (comboBox1.Text == "Kamera")
            {

                comboBox2.Items.Clear();

                comboBox2.Items.Add("JVJ");
                comboBox2.Items.Add("Sony");

                comboBox2.Items.Add("Panasonic");
                comboBox2.Items.Add("Canon");
            } 
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Asus")
                textBox1.Text = "1650";

            label12.Text = "10";

            if (comboBox2.Text == "Lenova")
                textBox1.Text = "1600";

            label12.Text = "10";
            if (comboBox2.Text == "Toshiba")
                textBox1.Text = "1700";

            label12.Text = "10";
            if (comboBox2.Text == "Samsung - X")
                textBox1.Text = "1625";

            label12.Text = "10";
            if (comboBox2.Text == "Casper")
                textBox1.Text = "1250";

            label12.Text = "10";

            if (comboBox2.Text == "Acer")
                textBox1.Text = "1550 ";

            label12.Text = "10";

            if (comboBox2.Text == "Exper")

                textBox1.Text = "1445 ";

            label12.Text = "10";

            if (comboBox2.Text == "Nokia")
                textBox1.Text = "750 ";

            label12.Text = "10";

            if (comboBox2.Text == "Samsung")
                textBox1.Text = "600 ";
            label12.Text = "10";

            if (comboBox2.Text == "LG")
                textBox1.Text = "500 ";

            label12.Text = "10";

            if (comboBox2.Text == "JVJ")

                textBox1.Text = "1000 ";
            label12.Text = "10";

            if (comboBox2.Text == "Sony")

                textBox1.Text = "1200 ";
            label12.Text = "10";

            if (comboBox2.Text == "Panasonic")
                textBox1.Text = "1110 ";
            label12.Text = "10";

            if (comboBox2.Text == "Canon")
                textBox1.Text = "1250";

            label12.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fiyat = int.Parse(textBox1.Text);
                adet = int.Parse(comboBox4.Text);
                taksit = int.Parse(comboBox3.Text);
                if (taksit > 0)
                {


                    toplam = (fiyat * adet + (fiyat * adet) * taksit * 8 / 100);//fiyat işlemleri %18 kdv dahil

                    textBox3.Text = toplam.ToString("C");

                    tutar = ((toplam) / taksit);

                    textBox2.Text = tutar.ToString("C");

                }

                else
                {
                    kdv = ((fiyat * adet) * 8 / 100);

                    toplam = (fiyat * adet + kdv);


                    textBox3.Text = toplam.ToString("C");

                }
            }

            catch
            {
                MessageBox.Show(" Alanlara Sayısal Veriler Girilebilir veya Alanlar Boş Bırakılamaz");

            } 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=mengi;Integrated Security=True");
            deneme.Open();
            SqlCommand cmd = new SqlCommand("insert into Kayit (ÜrünKatogorisi, ÜrünAdi, ÜrünFiyati, Taksit, ÜrünAdeti, AylikTutar, Toplamtutar, ÜrünAlimTarihi) values('"+ comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "' , '" + comboBox3.Text.ToString() + "' , '" + comboBox4.Text.ToString() + "','"+textBox2.Text.ToString()+"', '"+textBox3.Text.ToString() +"', '" + DateTime.Now.ToShortDateString() + "')", deneme);
            cmd.ExecuteNonQuery();
            deneme.Close();

            if (comboBox1.Text == "")
                MessageBox.Show("Lütfen Bir Ürün Seçiniz");

            else if (comboBox2.Text == "")

                MessageBox.Show("Lütfen Bir Ürün Adı Seçiniz");

            else if (comboBox4.Text == "")

                MessageBox.Show("Lütfen Alacağınız Ürün Adedini Yazınız");

            else if (textBox3.Text == "")

                MessageBox.Show("Lütfen  Hesapla Butonuna Basarak Aldığınız Ürünlerin Fiyatını Hesaplayınız");//mesajını ver

            else
            {

                i++;
            }



            label10.Text = i.ToString();

            button2.Enabled = true;




        }
        
        private void button4_Click(object sender, EventArgs e)
        {

            nesne.sil();
            Close();
        }

        private void comboBox1_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label10.Text == "0")// stok sayısı sıfırsa  aşağıdaki mesajı ver ve formu kapat dedim.
            {

                MessageBox.Show("Bu Ürün Stoklarda Bulunmamaktadır..Lütfen Başka Bir Ürün Seçiniz");

                this.Close();

            }

            else

                stok = a - int.Parse(label12.Text);
            label10.Text = stok.ToString(); 

            button2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
        }

       
    }
}
