using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.Data;

namespace DataAccessLayer
{
    public class PersonelDAL
    {
        public static List<Personel> PersonelList()
        {
            List<Personel> Personeller = new List<Personel>();
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand("pr_PersonelListele", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Personeller.Add(new Personel(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5))); 
            }

            reader.Close();
            conn.Close();

            return Personeller;
        }

        public static int PersonelKontrol(string ad)
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand("pr_PersonelKontrol", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Ad", ad);
            conn.Open();

            int sonuc = cmd.ExecuteNonQuery();
            conn.Close();
            return sonuc;
        }

    }
}
