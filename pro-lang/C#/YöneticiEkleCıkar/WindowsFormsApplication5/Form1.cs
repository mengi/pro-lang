using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Class1 nesne = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            baglan.Open();
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Gerekeli alanlari doldurunuz !!!","Kayit",MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear(); textBox1.Clear(); textBox3.Clear(); textBox2.Clear();
            }
            else
            {
                string sorgu = "select * from Yönetici";
                SqlCommand kmt = new SqlCommand(sorgu,baglan);
                SqlDataReader okuyucu = kmt.ExecuteReader();
                while (okuyucu.Read())
                {
                    if ((textBox3.Text.ToString().CompareTo(okuyucu["SicilNo"].ToString()) == 0))
                    {
                        MessageBox.Show("Kayitlidir!!","Kayit",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                        maskedTextBox1.Clear();
                        break;
                    }
                        
                    else
                    {
                        string kayit = "insert into Yönetici(Görev,İsim,Soyisim,SicilNo,TCNumarası,CepNo) values('" + comboBox1.Text.ToString() + "','" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "' ,'" + textBox3.Text.ToString() + "','"+textBox4.Text.ToString()+"','"+maskedTextBox1.Text.ToString()+"')";
                        nesne.ekle(kayit);
                        listele1();
                        MessageBox.Show("Kayidiniz Gerceklesmiştir !!!");
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                        maskedTextBox1.Clear();
                        break;          
                    }
                    
                }
                baglan.Close();
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yetkiDataSet1.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yetkiDataSet1.Personel);
            // TODO: This line of code loads data into the 'yetkiDataSet.Yönetici' table. You can move, or remove it, as needed.
            this.yöneticiTableAdapter.Fill(this.yetkiDataSet.Yönetici);
            // Yönetici
            pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\Yönetici1.png");
            toolTip1.SetToolTip(pictureBox1, "Kayit");
            pictureBox2.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\delete.png");
            toolTip1.SetToolTip(pictureBox2, "Sil");
            pictureBox3.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\123.png");
            toolTip1.SetToolTip(pictureBox3, "Güncelle");
            pictureBox4.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\ara.png");
            toolTip1.SetToolTip(pictureBox4,"Arama");

            // Personel

            pictureBox5.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\Personel.png");
            toolTip1.SetToolTip(pictureBox5, "Kayit");
            pictureBox6.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\users_delete (1).png");
            toolTip1.SetToolTip(pictureBox6, "Sil");
            pictureBox7.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\123.png");
            toolTip1.SetToolTip(pictureBox7, "Güncelle");
            pictureBox8.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\Arama7.png");
            toolTip1.SetToolTip(pictureBox8, "Arama");
            
            //sekreter
            pictureBox9.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\Sekreter.png");
            toolTip1.SetToolTip(pictureBox9, "Kayit");
            pictureBox10.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\prs.png");
            toolTip1.SetToolTip(pictureBox10, "Sil");
            pictureBox11.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\123.png");
            toolTip1.SetToolTip(pictureBox11, "Güncelle");
            pictureBox12.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\Arama1.png");
            toolTip1.SetToolTip(pictureBox12, "Arama");
            // silinenler
            pictureBox13.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Yeni klasör (2)\\44.png");
            toolTip1.SetToolTip(pictureBox13, "Silinenler");


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string ad = "DELETE FROM Yönetici WHERE Görev ='"+ comboBox2.Text.ToString() +"' OR İsim = '" + textBox6.Text.ToString()+ "' OR Soyisim ='" + textBox8.Text.ToString() + "'OR SicilNo ='"+textBox7.Text.ToString()+"'OR TCNumarası = '"+textBox9.Text.ToString()+"'OR CepNo = '"+maskedTextBox2.Text.ToString()+"'";
            nesne.sil(ad);
            listele1();
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void listele1()
        {
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            deneme.Open();
            DataTable Liste = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Yönetici", deneme);
            ad.Fill(Liste);
            dataGridView2.DataSource = Liste;
        }
        public void listele2() 
        {
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            deneme.Open();
            DataTable Liste = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Personel", deneme);
            ad.Fill(Liste);
            dataGridView3.DataSource = Liste;

        }
      
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection bagla1 = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            bagla1.Open();
            SqlCommand cmd = new SqlCommand();
            DataTable Liste = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Yönetici WHERE Görev ='"+ comboBox2.Text.ToString() +"' OR İsim = '" + textBox6.Text.ToString()+ "' OR Soyisim ='" + textBox8.Text.ToString() + "'OR SicilNo ='"+textBox7.Text.ToString()+"'OR TCNumarası = '"+textBox9.Text.ToString()+"'OR CepNo = '"+maskedTextBox2.Text.ToString()+"'", bagla1);
            ad.Fill(Liste);
            dataGridView2.DataSource = Liste;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlConnection baglan2 = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            baglan2.Open();
            DataTable Liste = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("update Yönetici set CepNo = '" + maskedTextBox2.Text.ToString() +"'Where Görev = '" + comboBox2.Text.ToString() + "'", baglan2);
            sda.Fill(Liste);
            dataGridView2.DataSource = Liste;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            baglan.Open();
            if (comboBox3.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Gerekeli alanlari doldurunuz !!!", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Clear(); textBox10.Clear(); textBox11.Clear(); textBox12.Clear();
            }
            else
            {
                string sorgu = "select * from Personel";
                SqlCommand kmt = new SqlCommand(sorgu, baglan);
                SqlDataReader okuyucu = kmt.ExecuteReader();
                while (okuyucu.Read())
                {
                    if ((textBox11.Text.ToString().CompareTo(okuyucu["SicilNo"].ToString()) == 0))
                    {
                        MessageBox.Show("Kayitlidir!!", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox10.Clear(); textBox12.Clear(); textBox11.Clear(); textBox5.Clear();
                        maskedTextBox3.Clear();
                        break;
                    }

                    else
                    {
                        string kayit = "insert into Personel(Görev,İsim,Soyisim,SicilNo,TCNumarası,CepNo) values('" + comboBox3.Text.ToString() + "','" + textBox5.Text.ToString() + "' , '" + textBox10.Text.ToString() + "' ,'" + textBox11.Text.ToString() + "','" + textBox12.Text.ToString() + "','" + maskedTextBox3.Text.ToString() + "')";
                        nesne.ekle(kayit);
                        listele1();
                        MessageBox.Show("Kayidiniz Gerceklesmiştir !!!");
                        textBox5.Clear(); textBox10.Clear(); textBox11.Clear(); textBox12.Clear();
                        maskedTextBox3.Clear();
                        break;
                    }

                }
                baglan.Close();

            }
            listele2();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string ad = "DELETE FROM Personel WHERE Görev ='" + comboBox4.Text.ToString() + "' AND İsim = '" + textBox13.Text.ToString() + "' OR Soyisim ='" + textBox14.Text.ToString() + "'OR SicilNo ='" + textBox15.Text.ToString() + "'OR TCNumarası = '" + textBox16.Text.ToString() + "'OR CepNo = '" + maskedTextBox4.Text.ToString() + "'";
            nesne.sil(ad);
            listele2();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SqlConnection baglan2 = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            baglan2.Open();
            DataTable Liste = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("update Personel set CepNo = '" + maskedTextBox4.Text.ToString() + "'Where Görev = '" + comboBox4.Text.ToString() + "'", baglan2);
            sda.Fill(Liste);
            dataGridView3.DataSource = Liste;
            listele2();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SqlConnection bagla3 = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            bagla3.Open();
            SqlCommand cmd = new SqlCommand();
            DataTable Liste = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Personel WHERE Görev ='" + comboBox4.Text.ToString() + "' OR İsim = '" + textBox13.Text.ToString() + "' OR Soyisim ='" + textBox14.Text.ToString() + "'OR SicilNo ='" + textBox15.Text.ToString() + "'OR TCNumarası = '" + textBox16.Text.ToString() + "'OR CepNo = '" + maskedTextBox4.Text.ToString() + "'", bagla3);
            ad.Fill(Liste);
            dataGridView3.DataSource = Liste;

        }
    }
}
