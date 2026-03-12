using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103082400029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kode = new KodePos();

            Console.Write("Masukkan kelurahan : ");
            string kelurahan = Console.ReadLine();

            int hasil = kode.getKodePos(kelurahan);

            if (hasil != -1)
            {
                Console.WriteLine("Kode Pos : " + hasil);
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan");
            }



            DoorMachine pintu = new DoorMachine();

            pintu.Buka();
            pintu.Kunci();

            Console.ReadLine();
        }
    }
}