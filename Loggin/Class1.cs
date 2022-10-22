using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;
using System.Security;


namespace Loggin
{
    internal class Class1

    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=FAIK_ARDA\\MYSQLSERVER;Initial Catalog=Logg-ın;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
        





    }
}
