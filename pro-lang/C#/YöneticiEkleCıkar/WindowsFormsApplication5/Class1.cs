using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    class Class1
    {
         public void ekle(string query)
        {
            SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
            deneme.Open();
            SqlCommand cmd = new SqlCommand(query,deneme);
            cmd.ExecuteNonQuery();
            deneme.Close();

        }
         public void sil(string query)
         {
             SqlConnection deneme = new SqlConnection("Data Source=ADMINN\\MENGI;Initial Catalog=Yetki;Integrated Security=True");
             deneme.Open();
             SqlCommand cmd = new SqlCommand(query, deneme);
             cmd.ExecuteNonQuery();
             deneme.Close();
         }
    }
}
