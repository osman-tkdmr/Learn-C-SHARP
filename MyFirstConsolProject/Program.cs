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

Console.WriteLine("\n-----------------------------\n");

/*
Data Types (Veri Tipleri)
*/
int sayi1 = 10;
double sayi2 = 20.5;
string metin = "Merhaba";
bool kontrol = true;

Console.WriteLine("Sayi1: " + sayi1);
Console.WriteLine("Sayi2: " + sayi2);
Console.WriteLine("Metin: " + metin);
Console.WriteLine("Kontrol: " + kontrol);

Console.WriteLine("\n-----------------------------\n");

/*
String Uygulamalari
*/
string kursAdi = ".NET 7 ile C# Programlama Dili";
/*
    1 - Kaç karaktere sahiptir ?
    2 - Hepsini kiictk harf yapiniz.
    3 - '.' ile mi baslamaktadir?
    4 - C# bilgisi hangi konumda bulunmaktadir?
    5 - String 'C#' bilgisini iceriyor mu?
    6 - 'Dili' kelimesi yerine 'Dersleri' yaziniz. (replace)
*/


kursAdi = kursAdi.ToLower();
var karakterSayisi = kursAdi.Length;
var baslangicKontrol = kursAdi.StartsWith(".");
var cSharpKonum = kursAdi.IndexOf("c#");
var cSharpKontrol = kursAdi.Contains("c#");
var newKursAdi = kursAdi.Replace("dili", "dersleri");

Console.WriteLine("Kurs Adi: " + kursAdi);
Console.WriteLine("Karakter Sayisi: " + karakterSayisi);
Console.WriteLine("Baslangic Noktasi: " + baslangicKontrol);
Console.WriteLine("C# Konumu: " + cSharpKonum);
Console.WriteLine("C# Kontrol: " + cSharpKontrol);
Console.WriteLine("Yeni Kurs Adi: " + newKursAdi);

Console.WriteLine("\n-----------------------------\n");

/*
    DateTime Uygulamalari
*/
var simdi = DateTime.Now;
var bugun = DateTime.Today;
var dogumTarihi = new DateTime(2001, 4, 21);
var yas = simdi.Year - dogumTarihi.Year;

var dun = simdi.AddDays(-1);

Console.WriteLine("Simdi: " + simdi);
Console.WriteLine("Bugun: " + bugun);
Console.WriteLine("Dun: " + dun);
Console.WriteLine("Dogum Tarihi: " + dogumTarihi);
Console.WriteLine("Yas: " + yas);

Console.WriteLine("\n-----------------------------\n");