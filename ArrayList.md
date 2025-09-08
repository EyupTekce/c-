c# ArrayList  öğrenilenler ;
Array List öğrendiklerim NetFramework 4.7 de çalışıyor.
Array List object veri tipinde olduğu için str int boolean vb. türleri yazabiliriz.
Otomatik kütüphaneye eklenmediği için kendimiz System.Collections; olarak eklememiz gerek.


--------------------------------------------Özellikler----------------------------------------------
ArrayList A1 = new ArrayList(); ile yeni koleksiyon oluşur
A1.Add("STRİNG"); ile koleksiyona veri yüklenebilir.

A1.AddRange(); ile çoklu veri yüklenir.

ArrayList in üzerindeki count içerisinde kaç eleman olduğunu belirtir
ArrayList içerisindeki Capacity ise kapasitesini belirtir. Otomatik artıyor zaten

Koleksiyon içerisindeki değere nasıl ulaşılır...
object veri tipi ile içerisindeki her veri çekilebilir. ama str veya int de kullanılabilir.

object O1 = A1[2]

---Yukarıda yazanların bilgilendirilmesi;

object = her veri tipini kanul edebilirim.
O1 = Aldığım veriyi neye atamak istediğimi belirtiyorum.
"=" = atama operatörü.
A1[2] = A1 koleksiyonundaki elemandan bahsediyorum. 


Notlar : (Bunlar bilinçsiz tür dönüşümü olduğundan hataya sebebiyet verebilir!!!)

eğer ben illaki string olarak çağırmak istiyorsam string S1 = A1[2].ToString(); şeklinde çağırmalıyım.

eğer ben illaki int olarak çağırmak istiyorsam int i1 = (int)A1[1]; şeklinde çağırmalıyım.

----------------------------------------------------------------------------------------------------

Koleksiyondaki veriyi değiştirme işlemi : 

A1[2] = "Eyüp Tekçe";
veyahut
A1[3] = 55;


-----------------------------------------------------------------------------------------------------
------------------ArrayList koleksiyonu içerisindeki bir değeri silme işlemi

A1.Remove(33);

---Yukarıda yazanların bilgilendirilmesi;

Ben A1 koleksiyonunu çağırıp remove işlemi ile bir silme işlemi yapacağımı belirtiyorum.
parantez içinde koleksiyondaki hangi veriyi silmek istediğimi soruyor "33" yazıyorum.
33 ün olduğu indexi buluyor 33 ü siliyor ve indexleri düzeltiyor.

---------------------------Alternatif silme işlemleri

A1.RemoveRange(3 , 2);

---Yukarıda yazanların bilgilendirilmesi;

RemoveRange komutu : 3. indexten başla ve 2 üst indexi sil (yani 4 ve 5. indexleri sil)

---------------------------Alternatif silme işlemleri

A1.RemoveAt(6);

---Yukarıda yazanların bilgilendirilmesi;

Burada RemoveAt komutu parantez içerisinde index bekler. Örnekte yazan 6 --> 6. indexi bul ve sil demektir.


-----------------------------------------------------------------------------------------------------

A1.Reverse();      --------------> en üsttekini en alta atar ters çevirme işlemi uygular.

A1.Sort();         --------------> diziyi A-Z ye sıralama işlemini yapar.   Not : string dizide yapılabilir yoksa hata alırız...



---------------------------------------> Koleksiyonlar Yardımcı elemanlar <--------------------------------------------

bool kontrol1 = A1.Contains("Eyüp Tekçe")  -------> A1 koleksiyonunda "Eyüp Tekçe" adında bir veri varmı diye bakar. varsa bool ile true olarak döner.

int indexdegeri = A1IndexOf("Eyüp Tekçe")  -------> A1 koleksiyonunda ilk önce "Eyüp Tekçe" değerini bulur ve karşılık gelen indexi int olarak aktarır. 

A1.Clear(); ------> A1 koleksiyonundaki tüm değerleri siler.

A1.TrimToSize(); -----> kapasiite arttığında ram harcanması artar. TrimToSize komutu kapasiteyi otomatik düzenler.

