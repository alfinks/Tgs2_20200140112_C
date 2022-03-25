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
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('2020001', 'Maulanaa', 'Sore')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('20200012', 'Alfiansyah', 'Siang')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('20200013', 'Alfin', 'Malam')"
                   + "insert into kasir(Id_kasir, Nama_Kasir, Bagian) values('20200014', 'Maul', 'Pagi')"


                   +"insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_Kasir,Tgl_Transaksi) values('T001','B001','C001', 'K001','Maulana','26-03-2021') "
                   +"insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_Kasir,Tgl_Transaksi) values('T002','B002','C002', 'K002','Alfiansyah','27-03-2021') "
                   +"insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_Kasir,Tgl_Transaksi) values('T003','B003','C003', 'K003','Alfin','28-03-2021') "
                   +"insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_Kasir,Tgl_Transaksi) values('T004','B004','C004', 'K004','Maul','29-03-2021') "
                   +"insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_Kasir,Tgl_Transaksi) values('T005','B005','C005', 'K005','alfian','30-03-2021') "

                   , 
                   
                   con);

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
        
        
    