using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanlıProgramlamaOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Console.WriteLine("isim giriniz");
            musteri.Ad = (Console.ReadLine());
            Console.WriteLine("soyisim giriniz");
            musteri.Soyad = Console.ReadLine();
            Console.WriteLine("varsa öğrenci no giriniz ");
            musteri.OgrNo =Console.ReadLine();
            Console.WriteLine("yaşınızı giriniz");
            musteri.Yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("varsa meslek giriniz");
            musteri.Meslek = Console.ReadLine();
            Console.WriteLine("varsa maaş girininz");
            musteri.Maas = (Console.ReadLine());

            if (musteri.Meslek == string.Empty)
            {
                Console.WriteLine(musteri.Ad +" "+ musteri.Soyad +" "+ musteri.Yas +" "+ musteri.OgrNo);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas + " " + musteri.Meslek+" "+musteri.Maas);
                Console.ReadLine();
            }
        }
    }
}
