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

                SqlCommand cm = new SqlCommand("insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('2020001', 'Maulana', 'Pagi')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('2020001', 'Maulana', 'Sore')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('20200012', 'Alfiansyah', 'Siang')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('20200013', 'Alfin', 'Malam')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('20200014', 'Maul', 'Pagi')", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}     
        
        
    