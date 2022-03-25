using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2_pabd
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ALFIN\\ALFINKS; database=Tugas2; Integrated Security = TRUE");
                con.Open();


            }
        }
        
        
    }
}
