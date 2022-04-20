using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiArya
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan paijo = new Karyawan("1444444", "Paijo", 2000000);
            Karyawan jono = new Karyawan("1555555", "Jono", 3000000);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", paijo.NIK, paijo.Nama, paijo.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", jono.NIK, jono.Nama, jono.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Naikkan gaji sebesar 10%");
            Console.WriteLine();

            paijo.NaikkanGaji(10);
            jono.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", paijo.NIK, paijo.Nama, paijo.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", jono.NIK, jono.Nama, jono.GajiBulanan);
        }
    }
}
