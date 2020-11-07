using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            if (sayi == 0)
            {
                Console.WriteLine("0! = 1");
            }
            if (sayi < 0 )
            {
                Console.WriteLine("Faktöriyelde negatif tam sayı yazılamaz.");
            }
            else
            {
                for (int i = 1; i <= sayi; i++)
                {
                    f = i * f;
                }
                Console.WriteLine("Sonuç: " + f);
            }

            Console.ReadLine();

        }
    }
}
