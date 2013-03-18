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
    public partial class Form3 : Form
    {
        Class1 nesne1 = new Class1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mengiDataSet1.Kayit' table. You can move, or remove it, as needed.
            this.kayitTableAdapter1.Fill(this.mengiDataSet1.Kayit);
            // TODO: This line of code loads data into the 'mengiDataSet.Kayit' table. You can move, or remove it, as needed.
            this.kayitTableAdapter.Fill(this.mengiDataSet.Kayit);
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=mengi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            deneme.Open();
            DataTable Liste = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Kayit", deneme);
            ad.Fill(Liste);
            dataGridView1.DataSource = Liste;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nesne1.sil();
            Close();
        }
    }
}
