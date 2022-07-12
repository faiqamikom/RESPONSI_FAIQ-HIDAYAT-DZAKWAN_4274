using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan");
            Penjualan jual = new Penjualan();
            Console.WriteLine();
            Console.Write("Nota : ");
            jual.Nota = Console.ReadLine());
            Console.Write("Tanggal : ");
            jual.Tanggal = Console.ReadLine();
            Console.Write("Customer : ");
            jual.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            jual.Jenis = Console.ReadLine();
            Console.Write("Total Nota : ");
            jual.Total_Nota = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan");
            int number = 1;
            foreach (Penjualan data in daftarPenjualan)
            {
                string text = ((data.Jenis == "T") ? "Tunai" : "Kredit");
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", number, data.Nota, data.Tanggal, data.Customer, data.Jenis, data.Total_Nota);
                number++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
