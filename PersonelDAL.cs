using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RehberUyg.BusinessLayer;
using Accessibility


namespace RehberUyg.DataAccessLayer
{
	public class PersonelDAL
	{
		public static int PersonelEkle(Personel personel)
		{
			SqlConnection conn = new SqlConnection(Connection.ConnectionString);
			SqlCommand cmd = new SqlCommand("pr_PersonelEkle");
			cmd.CommandType = System.Data.CommanType.StoredProcedure;
			cmd.Parameters.AddWithValue("Ad", personel.Ad);
			conn.Open();
			int sonuc = cmd.ExecuteNonQuery();
			conn.Close();
			return sonuc;
		}

		public static List<Personel> PersonelListele()
		{
			List<Personel> Personeller = new List<Personel>();
			SqlConnection conn = new SqlConnection(Connection.ConnectionString);
			SqlCommand cmd = new SqlCommand("pr_PersonelListele");
			cmd.CommandType = System.Data.CommanType.StoredProcedure;
			conn.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Personeller.Add(new Personel(dr.GetInt32(0), dr.GetString(1)));
			}
			dr.Close();
			conn.Close();
			return Personeller;
		}
	}

}
