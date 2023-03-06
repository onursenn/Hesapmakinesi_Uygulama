using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesapmakinesi_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float s1, s2, sonuc;
            char islem;
            
            Console.WriteLine("*******Hesap Makinesi*******");
            Console.WriteLine("");

            Console.Write("Sayı Girin: ");
            s1 = float.Parse(Console.ReadLine());

            Console.Write("İşlem Seçin(+|-|*|/): ");
            islem = Convert.ToChar(Console.ReadLine());

            Console.Write("Sayı Girin: ");
            s2 = float.Parse(Console.ReadLine());

            if (islem == '+')
            {
                sonuc = s1 + s2;
                Console.WriteLine("Sonuç:" + sonuc);

            }
            if (islem == '-')
            {
                sonuc = s1 - s2;
                Console.WriteLine("Sonuç:" + sonuc);

            }
            if (islem == '/')
            {
                sonuc = s1 / s2;
                Console.WriteLine("Sonuç:" + sonuc);

            }
            if (islem == '*')
            {
                sonuc = s1 * s2;
                Console.WriteLine("Sonuç:" + sonuc);

            }

            Console.Read();


        }
    }
}
