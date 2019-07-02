using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAgregasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek karyawan 1
            Karyawan karyawan1 = new Karyawan();
            karyawan1.Nama = "Kristian";

            //membuat objek karyawan 2
            Karyawan karyawan2 = new Karyawan();
            karyawan2.Nama = "Ugahari";

            //membuat objek karyawan 3
            Karyawan karyawan3 = new Karyawan();
            karyawan3.Nama = "Dwipa";

            //membuat objek perusahaan
            Perusahaan perusahaan = new Perusahaan();

            //hubungan agregasi
            perusahaan.DaftarKaryawan.Add(karyawan1);
            perusahaan.DaftarKaryawan.Add(karyawan2);
            perusahaan.DaftarKaryawan.Add(karyawan3);

            int noUrut = 1;

            Console.WriteLine("Daftar karyawan : "); //menampilkan data karyawan
            foreach (Karyawan karyawan in perusahaan.DaftarKaryawan)
            {
                Console.WriteLine("{0}. {1}", noUrut, karyawan.Nama);
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
