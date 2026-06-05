/*
    annotation: 2026-06-05
    author: Osman Tekdamar
    description: Degiskenler ve veri tipleri uygulamalari
*/


/*
    Uygulama 1: Bir ogrencinin asagidaki bilgileri icin gerekli degiskenleri olusturunuz.
    Ogrenci adi
    Ogrenci soyad1 Ogrenci ad ve soyad Ogrenci numarasi 
    Ogrenci cinsiyet 
    Ogrenci tc kimlik 
    Ogrenci dogum y1li 
    Ogrenci adres bilgisi 
    Ogrenci yasi
    Uygulama 2: Asagidaki urunlerin toplam bilgisini hesaplayiniz.
    Urun 1 => 50 TL 
    Urun 2 => 60.5 TL 
    Urun 3 => 356.45 TL
*/


var ogrenciAdi = "Osman";
var ogrenciSoyadi = "Tekdamar";
var ogrenciAdSoyad = ogrenciAdi + " " + ogrenciSoyadi;
var ogrenciNumarasi = "123456";
var ogrenciCinsiyet = 'E';
var ogrenciTcKimlik = "12345678901";
var ogrenciDogumYili = 1990;
var ogrenciAdresBilgisi = "Istanbul, Turkey";
var ogrenciYasi = DateTime.Now.Year - ogrenciDogumYili;


Console.WriteLine("Ogrenci Adi: " + ogrenciAdi);
Console.WriteLine("Ogrenci Soyadi: " + ogrenciSoyadi);
Console.WriteLine("Ogrenci Ad Soyad: " + ogrenciAdSoyad);
Console.WriteLine("Ogrenci Numarasi: " + ogrenciNumarasi);
Console.WriteLine("Ogrenci Cinsiyet: " + ogrenciCinsiyet);
Console.WriteLine("Ogrenci TC Kimlik: " + ogrenciTcKimlik);
Console.WriteLine("Ogrenci Dogum Yili: " + ogrenciDogumYili);
Console.WriteLine("Ogrenci Adres Bilgisi: " + ogrenciAdresBilgisi);
Console.WriteLine("Ogrenci Yasi: " + ogrenciYasi);

var urun1 = 50;
var urun2 = 60.5;
var urun3 = 356.45;
var toplam = urun1 + urun2 + urun3;

Console.WriteLine("Toplam Urun Fiyati: " + toplam);

