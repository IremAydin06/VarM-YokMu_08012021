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
             /* foreach(string sehir in sehirler)
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
            */
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == girilenSehir)
                {
                    Console.WriteLine($"{girilenSehir} arrayde vardır. İndeks numarası: {i} ' dir.");
                    varMi = true;
                    break;
                }
            }
            if(!varMi)
                Console.WriteLine("Aradığınız şehir arrayde yoktur.");
            Console.ReadKey();
        }
    }
}
