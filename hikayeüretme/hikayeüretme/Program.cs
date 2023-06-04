using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace hikayeüretme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Random sayı üretme

            //Random rnd = new Random();
            //int sayi = rnd.Next(46, 88);
            //Console.WriteLine(sayi);

            //double sayi1 = rnd.NextDouble();
            //Console.WriteLine(sayi1);

            //Random rastgele = new Random();
            //Console.WriteLine(" ŞEHİR ATAMA ");
            //String[] Şehirler = { "KONYA", "İSTANBUL", "DENİZLİ", "SİVAS", " BURSA", "HAKKARİ", "SİNOP", "GÜMÜŞHANE", };
            //int şehir = rastgele.Next(0, Şehirler.Length);
            //Console.WriteLine(şehir); // 0'dan başlayarak kaçıncı sıradaki şehir geldiyse o şehrin normal numarasını yazdırdıgı yerdir 
            //Console.WriteLine(Şehirler[şehir]); // rastgele gelen şehir 
            //Console.Read();

            #endregion

            #region Hikaye Üretme

            string[] karakterler = { "Erkek", "Kadın", "Kız Çocuk", "Kedi", "Erkek Çocuk", "Palyaço", "Muz", "Saat", "Oyuncak Bebek" };
            string[] mekanlar = { "Ev", "Okul", "Deniz Kıyısı", "Seçtiğin Bir Yer", "Paralel Evren", "Gemi", "Uçak", "Orman" };
            string[] zamanlar = { "19.yy", "Orta Çağ", "3000 yılı", "50 Sene Önce ", "Günümüz", "Seçtiğin Bir Zaman" };
            string[] türler = { "Fantastik", "Bilim Kurgu", "Gotik", "Polisiye", "Romantik", "Macera" };
            string[] fanvegotisim = { "Vampir", "Cadı", "Kurt Adam", "Büyücü", "Wonder Woman", "Şeytan", "Konuşan Bir Hayvan", "Süperman" };

         
            Console.WriteLine("Hikaye Üretme Oyununa Hoşgeldiniz ♥");
            Console.WriteLine("");

            Console.Write("Oyuncu Sayısını Giriniz:");
            int oysayı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

          

            for (int e = 0; e < oysayı; e++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write((e + 1) + ".Oyuncunun İsmini Giriniz : ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string isim = Console.ReadLine();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write((e + 1) + ".Oyuncu ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write((isim));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" İçin Gerekli Malzemeler :)");
                Console.WriteLine("");

                Console.ForegroundColor= ConsoleColor.Green;
                Random rnd = new Random();
                int tür = rnd.Next(0, türler.Length);
                Console.WriteLine("Tür : " + türler[tür]);
                Console.WriteLine("");

                if (türler[tür] == "Fantastik" || türler[tür] == "Gotik")
                {
                    Random rnd1 = new Random();
                    int karakter = rnd1.Next(0, fanvegotisim.Length);
                    Console.WriteLine("Ana Karakter : " + fanvegotisim[karakter] + " ☺");
                    Console.WriteLine("");
                }

                else
                {
                    Random rnd2 = new Random();
                    int karakter = rnd2.Next(0, karakterler.Length);
                    Console.WriteLine("Ana Karakter : " + karakterler[karakter] + " ☺");
                    Console.WriteLine("");
                }


                if (türler[tür] == "Fantastik" || türler[tür] == "Gotik")

                {
                    Console.Write("Yan karakter sayısını giriniz: ");
                    int yankrtsayısı = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    for (int i = 0; i < yankrtsayısı; i++)
                    {
                        Random rnd3 = new Random();
                        int fanvegot = rnd.Next(0, fanvegotisim.Length);
                        Console.WriteLine((i + 1) + ". Yan karakter : " + fanvegotisim[fanvegot] + " ♦");

                    }
                }
                else

                {
                    Console.Write("Yan karakter sayısını giriniz: ");
                    int yankrtsayısı3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    for (int i = 0; i < yankrtsayısı3; i++)

                    {
                        
                        Random rnd4 = new Random();
                        int yankarakter = rnd.Next(0, karakterler.Length);
                        Console.WriteLine((i + 1) + ". Yan Karakter : " + karakterler[yankarakter] + " ♦");
                    }
                }

                Console.WriteLine("");

                Random rnd5 = new Random();
                int mekan = rnd5.Next(0, mekanlar.Length);
                Console.WriteLine("Mekan : " + mekanlar[mekan]);
                Console.WriteLine("");


                Random rnd6 = new Random();
                int zaman = rnd6.Next(0, zamanlar.Length);
                Console.WriteLine("Zaman : " + zamanlar[zaman]);
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Sevgili ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write((isim));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine( " Hikaye Üretme Oyununda Başarılar Dileriz ☻");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥");              
                Console.ReadLine();
                Console.ForegroundColor= ConsoleColor.White;
                
            }

            #endregion

        }


    }

}

