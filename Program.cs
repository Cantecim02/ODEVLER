using System.Data.Common;
using System.Diagnostics.Contracts;
using Ders25_AlisVeris.Models;

namespace Ders25_AlisVeris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbHelper dbHelper = new DbHelper();

            //Siparis siparis = new Siparis();
            //siparis.SiparisNo = "#25645";
            //siparis.Id = 1; // Kullanıcı ID'si, örneğin 1 numaralı kullanıcı için sipariş oluşturuluyor
            //siparis.Toplam = 150.75; // Sipariş toplam tutarı
            //siparis.KUlllanıcıId = 1; // Siparişi oluşturan kullanıcının ID'si
            ////Kullanici kullanıcı = new Kullanici();

            //kullanıcı.AdSoyad = "Ahmet Yılmaz";
            //kullanıcı.Sifre= "123456";
            //kullanıcı.Email = "ahmetyılmaz@outlook.com";


            //string sonuc = dbHelper.KullanıcıEkle(kullanıcı);
            //Console.WriteLine(sonuc);

            //---------------------------------

            //UrunKategori Kategori= new UrunKategori();
            //Kategori.Adi = "Elektronik";
            //Kategori.Sira = 1;
            //Kategori.UrunNo = "ELK-001";



            //string sonuc = dbHelper.UrunkategoriEkle(Kategori);
            //Console.WriteLine(sonuc);
            //----------------------------------






            //------------------------------------


            // var listeUrunKategorileri = dbHelper.UrunKategoriListele();
            //foreach (var item in listeUrunKategorileri)
            //{
            //    Console.WriteLine($"Kategori Adı: {item.Adi}, Sıra: {item.Sira}, Ürün No: {item.UrunNo}, Oluşturulma Tarihi: {item.OlsuturulmaTarihi}");

            //}


            //--------------------------------


            //var urunler =dbHelper.GetUrunlerByKategori(); //kategori id sine göre ürünleri listeleme işlemi yapılır
            //// var ile urunler adında bir değişken tanımlanır ve dbHelper sınıfından GetUrunlerByKategori metodu çağrılır
            //foreach (var item in urunler) //foreach döngüsü ile urunler listesindeki her bir ürüne erişilir
            //{

            //    Console.WriteLine(item.Adi);
            //}


            //var tumUrunIdleri = dbHelper.TumUrunIdleri();
            //foreach (var id in tumUrunIdleri)
            //{
            //    Console.WriteLine(id);
            //}



            //urun tablosundaki urunlerin adları 
            //var tumurunadlari = dbHelper.tumisimler();
            //foreach(var adi in tumurunadlari)
            //{
            //    Console.WriteLine(adi);
            //}

            //urun tablosundaki BİRİMFİYAT  ları double yazma 

            //var tumUrunFiyatlari = dbHelper.TumUrunBirimFiyatlari();
            //foreach (var item in tumUrunFiyatlari)
            //{

            //    Console.WriteLine(item);
            //}



            //tum urunlerin durumu 
            //var tumUrunDurumlari = dbHelper.AktifUrunler();
            //foreach(var item in tumUrunDurumlari)
            //{
            //    Console.WriteLine($"Ürün Adı: {item.Adi}, Durumu: {(item.IsPassive ? "Pasif" : "Aktif")}, Stok: {item.Stok}, Barkod No: {item.BarkodNo}, Oluşturulma Tarihi: {item.OlsuturulmaTarihi}"); // IsPassive true ise Pasif, false ise Aktif olarak gösterilir
            //}

            //urunlerin stokları 

            //var urunstokları = dbHelper.stoklar();
            //foreach (var item in urunstokları)
            //{
            //    Console.WriteLine($" Urunlerin Stok durumu : {item}  ");
            //}


            //var barkodno = dbHelper.Urunbarkodları(); // 1 numaralı ürünün barkod numarasını getirir
            //foreach(var item in barkodno)
            //{
            //    Console.WriteLine($"Ürün Barkod No: {item.BarkodNo}, Ürün Adı: {item.Adi}, Kategori: {item.Kategori.Adi}, Oluşturulma Tarihi: {item.OlsuturulmaTarihi}");
            //}



            //urunleri kategori İD sine göre sıralama 

            //var urunkategoriId = dbHelper.urunkategoriıd(); //ürünlerin kategori id sine göre sıralama işlemi yapılır
            // foreach (var item in urunkategoriId)
            //{
            //    Console.WriteLine($"Ürün Adı: {item.Adi}, Kategori ID: {item.KtegoriId}");
            //}



            //urunkerin sıra bilgisini alma 

            //var urunlerinsirasi = dbHelper.urunsırabilgisi(); //ürünlerin sıra bilgilerini listeleme işlemi yapılır
            //foreach (var item in urunlerinsirasi)
            //{
            //    Console.WriteLine($"Ürün Sırası: {item}"); //ürünlerin sıra bilgilerini yazdırma işlemi yapılır
            //}



            //urunlerin sırası 


            //var urunlersirasi = dbHelper.urunlerinsirasi(); //ürünlerin sıra bilgisine göre sıralama işlemi yapılır
            //foreach (var item in urunlersirasi)
            //{
            //    Console.WriteLine($"Ürün Sırası: {item.Sira}"); //ürünlerin sıra bilgilerini yazdırma işlemi yapılır



            //}



            //olusuturulma tarihi alma 
            //var olusturulmatarihi = dbHelper.UrunOluşturulmaTarihi(); //ürünlerin oluşturulma tarihini listeleme işlemi yapılır
            //foreach (var item in olusturulmatarihi)
            //{
            //    Console.WriteLine(item);

            //}

            //urunkategoriye açıklama çekme işlemi

            //var urunkategoriId = dbHelper.UrunKategoriIdleri();
            //foreach (var item in urunkategoriId)
            //{
            //    Console.WriteLine(item);






            //}




            // urunkategoriden adı(string) işlemi 

            //var urunkategoriadi = dbHelper.urunkategoriAdlari();
            //foreach (var item in urunkategoriadi)
            //{
            //    Console.WriteLine($"{item.Adi} , {item.Id}");

            //}

            //urunkategoriden aktif pasif durumlarını alma işlemi 

            //var urunkategoriıspassive = dbHelper.urunkategoridurumları();
            //foreach (var item in urunkategoriıspassive)
            //{
            //   Console.WriteLine($"{item.IsPassive}"); 

            //}





            // UrunlerKategori Açıklama (string)



            //var urunaAciklamalari = dbHelper.urunAcıklama();
            //foreach (var item in urunaAciklamalari)
            //{
            //    Console.WriteLine($"Ürün Adı: {item.Adi}, Açıklama: {item.Aciklama}");
            //}


            //urunkategori Kategori No


            //var urunkategorino = dbHelper.urunkategorino();
            //foreach (var item in urunkategorino)
            //{
            //    Console.WriteLine($"Kategori Adı: {item.Adi}, Kategori No: {item.UrunNo}");
            //}










            //urunkategori Sira (int)


            //var urunkategoriSira = dbHelper.urunKategoriSira();
            //foreach (var item in urunkategoriSira)
            //{
            //    Console.WriteLine($"Kategori Adı: {item.Adi}, Sıra: {item.Sira}");
            //}





            //urunkategori OluşturulmaTarihi (datetime)


            //var kategoritarihleri = dbHelper.urunkategoridatetime();
            //foreach (var item in kategoritarihleri)
            //{
            //    Console.WriteLine($"{item.OlsuturulmaTarihi}");
            //}




            //--------------------------------------------------
            //kullanıcılar listesinden ıd leri alma işlemi 



            //var kullanıcılarID = dbHelper.tumkullancıIdleri();
            //foreach (var item in kullanıcılarID)
            //{
            //    Console.WriteLine($"Kullanıcı ID: {item} "); 
            //}

            // kullanıcılar AdSoyad alma işlemi 

            //var tumkullancıad =dbHelper.tumKullaniciAdlari();

            //foreach (var item in tumkullancıad)
            //{
            //    Console.WriteLine($"Kullanıcı Adı: {item.AdSoyad}");
            //}


            // kullanıcılar mail alma işlemi 


            //var kullanıcılarmail = dbHelper.kullanıcımail();
            //foreach (var item in kullanıcılarmail)
            //{
            //    Console.WriteLine($"Kullanıcı Mail: {item.Email}");
            //}




            //kullanıcılar Şifre alma işlemi

            //var kullanıcısifre = dbHelper.kullanicisifre();
            //foreach (var item in kullanıcısifre)
            //{
            //    Console.WriteLine($"{item.AdSoyad}  Kullanıcısının Şifresi: {item.Sifre}"); 
            //}

            //kullanıcılar IsPassive (bool) işlemi 

            //var kullanıcıdurumu =dbHelper.kullaniciIsPassive();

            //foreach (var item in kullanıcıdurumu)
            //{
            //    Console.WriteLine($"Kullanıcı Adı: {item.AdSoyad}, Durumu: {(item.IsPassive ? "Pasif" : "Aktif")}"); 
            //}



            //var kullanıcıTrih =dbHelper.kullanıcıtarih();
            //foreach (var item in kullanıcıTrih)
            //{
            //    Console.WriteLine($"Kullanıcı Adı: {item.AdSoyad}, Oluşturulma Tarihi: {item.OluşturulmaTarihi}"); 
            //}


            //--------------------------------------------------
            //siparisler tablosundan veri çekme metotları


            //var siparislerıd = dbHelper.siparisID();
            //foreach (var item in siparislerıd)
            //{
            //    Console.WriteLine($"Sipariş ID: {item.Id}"); 
            //}


            //siparişler tablosu Sipariş No (string)



            //var siparisNo = dbHelper.siparisno();
            //foreach (var item in siparisNo)
            //{
            //    Console.WriteLine($"Sipariş No: {item.SiparisNo}"); 
            //}


            //siparişler tablosu OluşturulmaTarihi (datetime)


            //var siparisolusturmatarihi = dbHelper.siparisOluşturulmaTarihi();
            //foreach (var item in siparisolusturmatarihi)
            //{

            //  Console.WriteLine($"Sipariş Oluşturulma Tarihi: {item.OlusturulmaTarihi}  Sipariş Toplamı : {item.Toplam}"); 

            //}


            //siparisler tablosu Kullanıcı Id (int)

            //var kullanıcııd =dbHelper.kullanıcııd();
            //foreach (var item in kullanıcııd)
            //{
            //    Console.WriteLine($"Kullanıcı ID: {item.KUlllanıcıId}");
            //}


            //siparisler tablosu Toplam (double)

            //var siparisToplam = dbHelper.siparislerToplam();
            //foreach (var item in siparisToplam)
            //{
            //    Console.WriteLine($"  {item.Id} Id'li Kullanıcının Sipariş Toplamı: {item.Toplam}"); 
            //}

            //---------------------------------------------


            //siparisitem işlemleri 





        }
    }
}
