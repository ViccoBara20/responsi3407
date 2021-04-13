using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3407
{
    0references
    class Program;

        0references
        static void Main(string[] args)
    {
        Karyawan paijo = new Karyawan();
        Karyawan jono = new Karyawan();

        paijo.nama = "Paijo";
        paijo.NIK = 190302123;
        paijo.gajibulanan = "3,000,000";

        jono.nama = "Jono";
        jono.NIK = 190302124;
        jono.gajibulanan = "2,000,000";

        Console.WriteLine("NIK/Nama\tGajibulanan");
        Console.WriteLine("-----------------------------")

        paijo.bulanan();
        jono.bulanan();


        Console.ReadKey();
    }
}