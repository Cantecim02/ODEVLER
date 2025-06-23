using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ders25_AlisVeris.Data;
using Ders25_AlisVeris.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace Ders25_AlisVeris
{

    public class DbHelper
    {
        private AddDbContext _db = new AddDbContext();
        #region Kullanicilar
        //kullanıcı açma
        public string KullanıcıEkle(Kullanici data) //ile kullanıcı ekleme işlemi yapılır
        {

            _db.Kullanicilar.Add(data);
            _db.SaveChanges();
            return $"{data.AdSoyad} adlı kullanıcı başarıyla eklendi.";

        }
        //public string siparisolustur(Siparis data)
        //{
        //    _db.Siparisler.Add(data); //sipariş ekleme işlemi yapılır
        //    _db.SaveChanges(); //veritabanına kaydedilir
        //    return $"{data.Kullanici.AdSoyad} adlı kullanıcı için sipariş başarıyla oluşturuldu.";

        //}


        #endregion
        #region Urun Kategorileri

        public string UrunkategoriEkle(UrunKategori data)
        {

            _db.UrunKategoriler.Add(data);
            _db.SaveChanges();
            return $"{data.Adi}" + " adlı ürün kategorisi başarıyla eklendi.";
        }




        #endregion

        //Sıraya göre Listeleme

        public List<UrunKategori> UrunKategoriListele() //urunkategorileri listeleme işlemi yapılır ve bir metot oluşturulur
        {
            return _db.UrunKategoriler.OrderBy(P => P.Sira).ToList(); //orderby ile sıralama işlemi yapılır
            //tolist ile listeleme işlemi yapılır 
        }



        #region Urunler
        //kategori ıd sine göre o kategoriye ait ürünler lsitelenecek

        public List<Urun> GetUrunlerByKategori()
        {
            int kategoriId = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan kategori id si alınır
            return _db.Urunler.Where(p => p.KtegoriId == kategoriId).ToList(); //where ile kategori id sine göre filtreleme işlemi yapılır




        }




        #endregion











        //ürün tablosu örnekleri 


        //public List<int> TumUrunIdleri()
        //{
        //    return _db.Urunler.Select(u => u.Id).ToList();
        //}


        //urun listesindeki urunlerin adları 
        //public List<string> tumisimler()
        //{
        //    return _db.Urunler.Select(p => p.Adi).ToList(); //ürünlerin isimlerini listeleme işlemi yapılır

        //}


        //urun tablosundaki urunlerin birim fiyatları

        //public List<double> TumUrunBirimFiyatlari()
        //{
        //    return _db.Urunler.Select(p => p.BirimFiyat).ToList(); //ürünlerin birim fiyatlarını listeleme işlemi yapılır
        //}


        // urunlerin aktiflik durumunu sorgulama
        //public List<Urun> AktifUrunler()
        //{
        //    return _db.Urunler.Where(p => p.IsPassive == false).ToList(); //IsPassive false olan ürünleri listeleme işlemi yapılır


        //    public List<int> stoklar()
        //    {
        //        return _db.Urunler.Select(p => p.Stok).ToList(); //ürünlerin stoklarını listeleme işlemi yapılır
        //}
        //}



        //urunlerin barkod numarasını getirme işlemi 

        //public List<Urun> Urunbarkodları()
        //{
        //    return _db.Urunler.Include(u => u.Kategori).OrderBy(p => p.BarkodNo).ToList(); 
        //nclude ile kategori bilgisi de dahil edilerek barkod numarasına göre sıralama işlemi yapılır:not : 
        //}


        //urunleri kategori ıd sine göre sıralama 
        //public List<Urun> urunkategoriıd()
        //{ 
        //  return _db.Urunler.Include(u => u.Kategori).OrderBy(p => p.KtegoriId).ToList(); //ürünlerin kategori id sine göre sıralama işlemi yapılır
        //}



        //urunlerin sıra bilgisini alma 


        //public List<Urun> urunlerinsirasi()
        //{
        //    return _db.Urunler.OrderBy(p => p.Sira).ToList(); //ürünlerin sıra bilgisine göre sıralama işlemi yapılır
        //}


        //olusturulmatarihlerini alma

        //public List<DateTime> UrunOluşturulmaTarihi()
        //{
        //    return _db.Urunler.Select(p => p.OlsuturulmaTarihi).ToList(); //ürünlerin oluşturulma tarihine göre sıralama işlemi yapılır
        //}


        // urunkategori tablosundan ıd lerini çekme 

        //public List<int> UrunKategoriIdleri()
        //{
        //    return _db.UrunKategoriler.Select(p => p.Id).ToList(); //ürün kategorilerinin id'lerini listeleme işlemi yapılır
        //}


        //urunkategoriden adı(string) işlemi 


        //public List<UrunKategori> urunkategoriAdlari()
        //{
        //    return _db.UrunKategoriler.Select(p => new UrunKategori
        //    {
        //        Id = p.Id,
        //        Adi = p.Adi
        //    }).ToList(); //ürün kategorilerinin adlarını listeleme işlemi yapılır
        //}




        //urunlerkategoriden kategorilerin aktif pasif durumlarını alma işlemi


        //public List<UrunKategori> urunkategoridurumları()
        //{ 
        //    return _db.UrunKategoriler.Select(p => new UrunKategori
        //    {
        //        Id = p.Id,
        //        Adi = p.Adi,
        //        IsPassive = p.IsPassive
        //    }).ToList(); //ürün kategorilerinin aktif pasif durumlarını listeleme işlemi yapılır


        //}





        // UrunlerKategori Açıklama (string)

        //public List<UrunKategori> urunAcıklama()
        // {

        //     return _db.UrunKategoriler.OrderBy(p=>p.Aciklama).ToList(); //ürün kategorilerinin açıklamalarını listeleme işlemi yapılır


        // }



        //urunkategori Kategori No

        //public List<UrunKategori> urunkategorino()
        //{
        //    return _db.UrunKategoriler.ToList();

        //}


        //urunkategori Sira (int)

        //public List<UrunKategori> urunKategoriSira()
        //{
        //return _db.UrunKategoriler.OrderBy(p => p.Sira).ToList(); 
        //}





        //urunkategori OluşturulmaTarihi (datetime)

        //public List<UrunKategori> urunkategoridatetime()
        //{ 
        //  return _db.UrunKategoriler.OrderByDescending(p => p.OlsuturulmaTarihi).ToList(); 

        //}


        //--------------------------------------------------
        //kullanıcılar listesinden ıd leri alma işlemi 


        //public List<int > tumkullancıIdleri()
        //{

        //    return _db.Kullanicilar.Select(p => p.Id).ToList(); 



        //}




        // kullanıcılar AdSoyad alma işlemi 

        //public List<Kullanici> tumKullaniciAdlari()
        //{
        //    return _db.Kullanicilar.OrderBy(p =>p.AdSoyad).ToList(); //kullanıcıların adlarını sıralı bir şekilde listeleme işlemi yapılır

        //}



        // kullanıcılar mail alma işlemi 

        //public List<Kullanici> kullanıcımail()
        //{
        //    return _db.Kullanicilar.Select(p => new Kullanici
        //    {
        //        Id = p.Id,
        //        Email = p.Email
        //    }).ToList(); //kullanıcıların mail adreslerini listeleme işlemi yapılır

        //}


        //kullanıcılar Şifre alma işlemi


        //public List<Kullanici> kullanicisifre()
        //{
        //    return _db.Kullanicilar.Select(p => new Kullanici
        //    {
        //        Id = p.Id,
        //        Sifre = p.Sifre,
        //        AdSoyad = p.AdSoyad 
        //    }).ToList(); 
        //}



        //kullanıcılar IsPassive (bool) işlemi 


        //public List<Kullanici> kullaniciIsPassive()
        //{
        //    return _db.Kullanicilar.Select(p => new Kullanici
        //    {
        //        Id = p.Id,
        //        AdSoyad = p.AdSoyad,
        //        IsPassive = p.IsPassive
        //    }).ToList(); //kullanıcıların aktif pasif durumlarını listeleme işlemi yapılır
        //}


        // kullanıcılar OluşturulmaTarihi (datetime)


        //public List<Kullanici> kullanıcıtarih()
        //{ 
        //  return _db.Kullanicilar.Where(p => p.OluşturulmaTarihi > DateTime.Now.AddYears(-1)).ToList(); //son bir yılda oluşturulan kullanıcıları listeleme işlemi yapılır

        //}


        //--------------------------------------------------
        //siparisler tablosundan veri çekme metotları

        //public List<Siparis> siparisID()
        //{ 
        //  return _db.Siparisler.Select(p => new Siparis
        //  {
        //      Id = p.Id,
        //      SiparisNo = p.SiparisNo
        //  }).ToList(); 
        //}



        //siparişler tablosu Sipariş No (string)


        //public List<Siparis> siparisno()
        //{
        //    return _db.Siparisler.OrderByDescending(p => p.SiparisNo).ToList(); 


        //}



        //siparişler tablosu OluşturulmaTarihi (datetime)

        //public List<Siparis> siparisOluşturulmaTarihi()
        //{
        //    return _db.Siparisler
        //  .OrderByDescending(p => p.OlusturulmaTarihi)
        //  .ThenByDescending(p => p.Toplam) //toplam tutara göre büyükten küçüğe sıraladık 
        //  .ToList();

        //}

        //siparisler tablosu Kullanıcı Id (int)

        //public List<Siparis> kullanıcııd()
        // {
        //     return _db.Siparisler.Where(p => p.KUlllanıcıId > 0).ToList(); 


        // }


        //siparisler tablosu Toplam (double)

        //public List<Siparis> siparislerToplam()
        //{
        //    return _db.Siparisler
        //       .OrderByDescending(p => p.Toplam)
        //       .Include(p => p.Kullanici)
        //       .ToList();

        //}


        //---------------------------------------------


        //siparisitem işlemleri 

        //siparileri tabloya iletemedim 


      



    }
}
//linq sorgularına örnekler 
// bir kullanıcıya ait tüm alışverişlerin numaraları listeleme 

