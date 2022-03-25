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
                con = new SqlConnection("data source=ALFIN\\ALFINKS; database=Tugas2; " + " user ID = sa; Password = maulana");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into kasir(id_kasir, Nama_kasir, Bagian) values('202000000011', 'Maulana', 'Pagi')"
                   + "insert into kasir(id_kasir, Nama_kasir, Bagian) values('202000000001', 'Maulanaa', 'Sore')"
                   + "insert into kasir(id_kasir, Nama_kasir, Bagian) values('202000000012', 'Alfiansyah', 'Siang')"
                   + "insert into kasir(id_kasir, Nama_kasir, Bagian) values('202000000013', 'Alfin', 'Malam')"
                   + "insert into kasir(id_kasir, Nama_kasir, Bagian) values('202000000014', 'Maul', 'Pagi')"


                   + "insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_kasir,Tgl_Transaksi) values('T00000000001','B00000000011','C00000000021', '202000000011','Maulana','26-03-2021') "
                   + "insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_kasir,Tgl_Transaksi) values('T00000000002','B00000000022','C00000000032', '202000000001','Alfiansyah','27-03-2021') "
                   + "insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_kasir,Tgl_Transaksi) values('T00000000003','B00000000033','C00000000023', '202000000012','Alfin','28-03-2021') "
                   + "insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_kasir,Tgl_Transaksi) values('T00000000004','B00000000044','C00000000024', '202000000013','Maul','29-03-2021') "
                   + "insert into Transaksi(id_Transaksi, id_Barang, id_Costumer, id_kasir,Nama_kasir,Tgl_Transaksi) values('T00000000005','B00000000055','C00000000025', '202000000014','alfian','30-03-2021') "

                    + "insert into Barang(id_Barang, Nama_Barang,Harga, Stock) values('B00000000011', 'Bolu_Original', '20000', '20')"
                    +"insert into Barang(id_Barang, Nama_Barang,Harga, Stock) values('B00000000022', 'Bolu_Pandan', '25000', '10')"
                    +"insert into Barang(id_Barang, Nama_Barang,Harga, Stock) values('B00000000033', 'Bolu_Coklat', '20000', '40')"
                    +"insert into Barang(id_Barang, Nama_Barang,Harga, Stock) values('B00000000044', 'Bolu_Keju', '30000', '20')"
                    +"insert into Barang(id_Barang, Nama_Barang,Harga, Stock) values('B00000000055', 'Bolu_Coklat_Keju', '60000', '25')"

                    + "insert into Costumer(id_Costumer, Nama, Alamat, No_tlp) values('C00000000021', 'bagus', 'Sumedang', '085294395071')"
                    + "insert into Costumer(id_Costumer, Nama, Alamat, No_tlp) values('C00000000032', 'Fikri', 'Bandung', '085294395072')"
                    + "insert into Costumer(id_Costumer, Nama, Alamat, No_tlp) values('C00000000023', 'bagas', 'Majalengka', '085294395073')"
                    + "insert into Costumer(id_Costumer, Nama, Alamat, No_tlp) values('C00000000024', 'gisa', 'Bantul', '085294395074')"
                    + "insert into Costumer(id_Costumer, Nama, Alamat, No_tlp) values('C00000000025', 'gabus', 'Kuningan', '085294395075')",con);

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
        
        
    