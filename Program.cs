using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;

namespace ArrayListÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList degerler = new ArrayList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------Menü---------------");
                Console.WriteLine("1 ---> değer ekleme");
                Console.WriteLine("2 ---> değer listele");
                Console.WriteLine("3 ---> değer ara");
                Console.WriteLine("4 ---> değer düzenle");
                Console.WriteLine("5 ---> değer silme");
                Console.Write("seçiminizi giriniz : ");
                string secim = Console.ReadLine();




                switch (secim)
                {
                    case "1":
                        Console.Write("kaç değer eklemek istiyorsunuz : ");
                        int intdegerekleme = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < intdegerekleme; i++)
                        {

                            Console.Write((i + 1) + ". değeri giriniz : ");
                            string strdegergiris = Console.ReadLine();
                            Console.Clear();
                            degerler.Add(strdegergiris);
                            Console.WriteLine();
                            Console.WriteLine("değer girişi onaylandı.");
                            Console.WriteLine();

                        }
                        Console.WriteLine("tüm değer girişleri başarılı.");
                        break; //değer ekleme işlemi

                    case "2":
                        Console.WriteLine("Değerler listeleniyor...");

                        for (int i = 0; i < degerler.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". degeriniz : " + degerler[i]);
                        }

                        Console.WriteLine("tüm değerleriniz listelendi.");

                        break; //değer listeleme işlemi

                    case "3":
                        Console.WriteLine();
                        Console.Write("Aramak istediğiniz değeri giriniz : ");
                        string strdegerarama = Console.ReadLine();

                        bool degervarmi = degerler.Contains(strdegerarama);

                        if (degervarmi == true)
                        {
                            Console.WriteLine("değeriniz listede kayıtlı");


                        }
                        else
                        {
                            Console.WriteLine("değeriniz listede kayıtlı değil");

                            Console.Write("Değerinizi listeye eklemek istermisiniz(e/h) : ");
                            string degereklemesecim = Console.ReadLine().ToLower();

                            if (degereklemesecim == "e")
                            {
                                degerler.Add(strdegerarama);
                                Console.WriteLine("değer eklendi");
                            }
                            else Console.WriteLine("değer eklenmedi.");

                        }

                        break; //değer arama işlemi

                    case "4":
                        Console.WriteLine();
                        Console.Write("Kayıtlı listenizdeki değiştirmek istediğiniz değeri giriniz : ");
                        string strdegerdegistirme = Console.ReadLine();
                        bool kayıtlıdeger = degerler.Contains(strdegerdegistirme);

                        if (kayıtlıdeger == true)
                        {
                            int degistirmeindex = degerler.IndexOf(strdegerdegistirme);
                            Console.WriteLine();
                            Console.Write("eklemek istediğiniz değeri giriniz : ");
                            string eklemedeger = Console.ReadLine();
                            Console.WriteLine();
                            degerler[degistirmeindex] = eklemedeger;

                            Console.WriteLine("değer düzenlendi.");
                        }
                        else Console.WriteLine("kayıtlı değer bulunamadı...");
                        break; //değer düzenleme işlemi 

                    case "5":
                        Console.WriteLine();
                        Console.Write("Silmek istediğiniz değeri giriniz : ");
                        string strsilme = Console.ReadLine();

                        int silmeindex = degerler.IndexOf(strsilme);

                        degerler.RemoveAt(silmeindex);

                        Console.WriteLine("değer silindi.");

                        break;








                }

                Console.Write("başka işlem yapmak istiyormusunuz(e/h) : ");
                string baskaislem = Console.ReadLine();

                if (baskaislem == "e") continue;
                else break;


            }

            Console.WriteLine("işleminiz sonlandı.");

        }
    }
}
