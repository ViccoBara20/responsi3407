using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResponsiPemrograman3407
{
    4references
    class Karyawan
    {
        4references
        public int NIK { get; set; }
        4references
        public string nama { get; set; }
        6references
        public string gajibulanan { get; set; }

        2references
        public void bulanan()
        {
            Console.WriteLine("{0}{1}\t{2}", NIK, nama, gajibulanan);
        }

        2references
        public void kenaikan ()
        {
            Console.WriteLine("{0}{1}\t{2}", NIK, nama, gajibulanan);
        }
    }
}