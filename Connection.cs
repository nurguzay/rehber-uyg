using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility

namespace RehberUyg.DataAccessLayer
{
	public class Connection
	{
		public static string ConnectionString
		{
			get
			{
				return "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rehber;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			}
		}
	}

}
