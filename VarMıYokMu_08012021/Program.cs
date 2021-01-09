using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMıYokMu_08012021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Eskisehir", "Ankara", "Izmir", "Diyarbakir", "Sinop" };
            Console.WriteLine("Bir şehir giriniz:");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            foreach(string sehir in sehirler)
            {
                if (sehir == girilenSehir)
                {
                    varMi = true;
                    break;
                }
            }
            if (varMi)
            {
                Console.WriteLine($"{girilenSehir} arrey'de var.");
            }
            else
            {
                Console.WriteLine($"{girilenSehir} arrey'de yok.");
            }
            Console.ReadKey();
        }
    }
}
