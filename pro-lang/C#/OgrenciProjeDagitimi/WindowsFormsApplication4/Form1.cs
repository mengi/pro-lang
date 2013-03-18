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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection baglan = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yeni;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            string sifre, no,numara;
            no = textBox1.Text.ToString();
            sifre = textBox2.Text.ToString();
            numara = Convert.ToString(textBox1.Text.ToString());
            if (textBox2.Text != "")
            {
                baglan.Open();
                SqlCommand kmt1 = new SqlCommand("select * from OgrenciBilgileri",baglan);
                SqlDataReader okuyucu1 = kmt1.ExecuteReader();
                
                while (okuyucu1.Read())
                {
                    if (no.CompareTo(okuyucu1["OgrenciNo"].ToString()) == 0)
                    {
                        if (sifre.CompareTo(okuyucu1["OgrenciSifre"].ToString()) == 0)
                        {
                            Form2 frm2 = new Form2(numara);
                            frm2.Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            label4.Text = "Şifre Hatali !!!";
                            textBox2.Clear();
                            break;
                        }
                    }
                    
                }
                baglan.Close();
                
                
            }
          
           
        } 

        
    }
}
