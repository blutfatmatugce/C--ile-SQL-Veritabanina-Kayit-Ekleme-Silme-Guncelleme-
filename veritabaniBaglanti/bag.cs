using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _19350034
{
    class bag
    {
        public SqlConnection pcbaglanti()
        {

            SqlConnection asusbaglanti = new SqlConnection(@"Data Source=LAPTOP-TD022QE6\SQLEXPRESS;Initial Catalog=emlakOtomasyonu;Integrated Security=True");
            asusbaglanti.Open();
            return asusbaglanti;

        }
    }
}
