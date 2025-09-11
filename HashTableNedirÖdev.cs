using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace HashTableNedirÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable Yeni Hashtable Yapımı ve Veri Ekleme İşlemi
            Hashtable A1 = new Hashtable();

            A1.Add("house", "ev"); //index house , veri ev gibi düşün. bir keye karşılık veri gelir.
            A1.Add("door", "kapı");
            A1.Add("taxi","taksi");
            #endregion


            #region Hashtable Yardımcı Metotlar
            bool kontrol1  = A1.Contains("house"); // house adlı key varmı diye bakılır.
            bool kontrol2 = A1.ContainsKey("water");  // water adlı key varmı diye bakılır.
            //Biri Contains diğeri ContainsKey arasında fark yok ikiside key istiyor.

            bool kontrol3 = A1.ContainsValue("ev"); //ContainsValue de veri ister-key istemez.

            A1.Remove("door"); //door adlı key var ise keyi ve veriyi siler.

            int countsayisi = A1.Count; //Count sayısını int e çevirmek için kullanılır.

           string doorkarsılık = A1["house"].ToString(); //door keyine karşılık gelen veriyi string olarak aktarır.

            A1["house"] = "villa"; //house adlı keye karşılık gelen veriyi değiştirir.

            A1.Clear(); // A1 in içerisindeki tüm veriyi siler.

            #endregion



            //Ödev İstenilen
            //Kullanıcı ENG - TR şeklinde data ekleyecek
            //İşlem bittiğinde yeni data eklemek isteyip istemediğini soracağız.
            //işlemleri bittiğinde en sonra datayı eng-tr şeklinde kullanıcıya liste şeklinde vereceğiz.
            //Var olan keyi eklediğinde veri tabanında bu key var ve karşılığında bu var diyeceğiz.
            Hashtable tümdata = new Hashtable();
            ArrayList arraydata = new ArrayList();
            ArrayList arraykey = new ArrayList();
            while (true)
            {
                Console.Write("Kaç data eklemek istiyorsunuz : ");
                int datasayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("yönlendiriliyor...");
                System.Threading.Thread.Sleep(1000);
                for (int i = 0; i < datasayi; i++)
                {
                    Console.Clear();
                    Console.Write((i + 1) + ". eng kelimeyi giriniz : ");
                    string data = Console.ReadLine();

                    Console.Write("türkçe karşılığını giriniz : ");
                    string veri = Console.ReadLine();


                    bool datakontrol = tümdata.Contains(data);

                    if (datakontrol == false)
                    {
                        arraydata.Add(data);
                        arraykey.Add(veri);

                        tümdata.Add(data, veri);

                        Console.WriteLine("eng-tr dataya eklendi ");
                    }
                    else
                    {
                        Console.WriteLine("böyle bir eng verisi bulunmaktadır.");
                        i--;
                    }

                    System.Threading.Thread.Sleep(1250);

                }
                Console.Write("yeni data eklemek istiyormusunuz(e/h) : ");
                string ekleme = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine("yönlendiriliyorsunuz...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

                if (ekleme == "e") continue;
                else break;

            }

            Console.WriteLine();
            Console.WriteLine("Tüm eng-tr karşılıkları");

            for (int i = 0;i < arraydata.Count ; i++)
            {
                Console.WriteLine();
                Console.WriteLine((i +1) +". ENG-TR  : " + arraydata[i] +" - " + arraykey[i] );
            }



        }
    }
}
