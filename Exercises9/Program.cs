using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Kullanici adi ve sifre alınarak bir sistemde login olunmasi ***

            //kullanicidan alinan kullanici adi ve sifreye gore login olunan sistemi olusturun
            //en az 2 method
            //kullanici adi ve sifre IstanbulBilisim, 123_abc
            //main methodu icerisinden sadece method cagiralicak

            string kullaniciAdi;
            string sifre;

            Console.WriteLine("Lütfen kullanici adinizi girin : ");
            kullaniciAdi = Console.ReadLine();

            Console.Write("Lutfen sifrenizi girin : ");
            sifre = Console.ReadLine();
            

            Login(kullaniciAdi, sifre); 

            Console.Read();
        }

        static void Login(string userName,string password)
        {
            string kullaniciAdi = "IstanbulBilisim";
            string sifre = "123_abc";

            if (kullaniciAdi == userName && sifre == password)
            {
                Console.WriteLine("KullaniciAdi ve sifre dogru");
            }
            else
            {
                Console.WriteLine("Kullanici adi ve sifre hatali");
            }
        }
    }
}
