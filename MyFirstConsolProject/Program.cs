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

/*
    Diziler (Arrays)
*/


string[] ogrenciler = new string[3];
int[] notlar = new int[3];

for(int i = 0; i < ogrenciler.Length; i++)
{
    Console.Write($"{i + 1}. ogrencinin adi:");
    ogrenciler[i] = Console.ReadLine() ?? string.Empty;
    Console.Write($"{i + 1}. ogrencinin notu:");
    notlar[i] = Convert.ToSByte(Console.ReadLine() ?? "0");
}


for(int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine($"{ogrenciler[i]} - {notlar[i]}");
}

var avgNot = notlar.Average();
Console.WriteLine("Ortalama Not: " + avgNot);

// or with Multidimensional Array

Console.WriteLine("\n-----------------------------\n");
string[,] ogrenciBilgileri = new string[3, 2];
for(int i = 0; i < ogrenciBilgileri.GetLength(0); i++)
{
    Console.Write($"{i + 1}. ogrencinin adi:");
    ogrenciBilgileri[i, 0] = Console.ReadLine() ?? string.Empty;
    Console.Write($"{i + 1}. ogrencinin notu:");
    ogrenciBilgileri[i, 1] = Console.ReadLine() ?? "0";
}

for(int i = 0; i < ogrenciBilgileri.GetLength(0); i++)
{
    Console.WriteLine($"{ogrenciBilgileri[i, 0]} - {ogrenciBilgileri[i, 1]}");

}

Console.WriteLine("\n-----------------------------\n");

/*
    Aritmetik Operatorler
*/
int a = 10;
int b = 5;
int c = 20;
Console.WriteLine("Toplama: " + (a + b));
Console.WriteLine("Cikarma: " + (a - b));
Console.WriteLine("Carpma: " + (a * b));
Console.WriteLine("Bolme: " + (a / b));
Console.WriteLine("Mod Alma: " + (a % b));

var sonuç = (c - a)  * b;
Console.WriteLine("Sonuc: " + sonuç);

int x = a--;
Console.WriteLine("x: " + x);
Console.WriteLine("a: " + a);

//odd and even numbers
int number = Convert.ToInt32(Console.ReadLine() ?? "0");
if(number % 2 == 0)
{
    Console.WriteLine("Cift sayi");
}
else
{    Console.WriteLine("Tek sayi");
}

Console.WriteLine("\n-----------------------------\n");

/*
    Karsilastirma Operatorleri

    Karsilastirma Operator Uygulamalari
    Klavyeden girilen yas bilgisine gore oy kullanabilme durumunu inceleyiniz. 
    Girilen bir sayinin isaretini kontrol ediniz. 
    Girilen bir sayinin tek/cift durumunu kontrol ediniz.
*/

Console.Write("Yas bilgisi giriniz:");
int yasBilgisi = Convert.ToInt32(Console.ReadLine() ?? "0");
var sonuc = yasBilgisi >= 18 ? "Oy kullanabilir" : "Oy kullanamaz";
Console.WriteLine(sonuc);

Console.Write("Bir sayi giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine() ?? "0");
var isaretSonuc = sayi > 0 ? "Pozitif" : (sayi < 0 ? "Negatif" : "Sifir");
Console.WriteLine(isaretSonuc);

Console.Write("Bir sayi giriniz:");
int tekCiftSayi = Convert.ToInt32(Console.ReadLine() ?? "0");
var tekCiftSonuc = tekCiftSayi % 2 == 0 ? "Cift sayi" : "Tek sayi";
Console.WriteLine(tekCiftSonuc);

Console.WriteLine("\n-----------------------------\n");

/*
    Mantiksal Operatérler Uygulamalari
    1- Yagi 18' den büyük ya da veli izni varsa bir iste calisabilir durumunu kontrol ediniz.
    2- Ders notu 50-100 arasindaysa gecti degilse kalsin bilgisini yazdiriniz.
    3- Ders ortalamasi en az 70 puan ve zayifi yoksa tesekkiir belgesi alabilme durumunu kontrol ediniz.
    4- ise girmek icin en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.
    5- Uygulamaya giris kontroliini username ya da parola icin yapalim.
*/

Console.Write("Yas bilgisi giriniz:");
int yasBilgisi2 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Veli izni var mi? (E/H):");
char veliIzni = Convert.ToChar(Console.ReadLine() ?? "H");
var calisabilirSonuc = (yasBilgisi2 > 18 || veliIzni == 'E') ? "Calisabilir" : "Calisamaz";
Console.WriteLine(calisabilirSonuc);

Console.Write("Ders notu giriniz:");
int dersNotu = Convert.ToInt32(Console.ReadLine() ?? "0");
var gectiKaldıSonuc = (dersNotu >= 50 && dersNotu <= 100) ? "Gecti" : "Kaldı";
Console.WriteLine(gectiKaldıSonuc);

Console.Write("Ders ortalamasi giriniz:");
int dersOrtalamasi = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Zayif var mi? (E/H):");
char zayifVar = Convert.ToChar(Console.ReadLine() ?? "H");
var tesekkurBelgesiSonuc = (dersOrtalamasi >= 70 && zayifVar == 'H') ? "Tesekkur belgesi alabilir" : "Tesekkur belgesi alamaz";
Console.WriteLine(tesekkurBelgesiSonuc);

Console.Write("Mezuniyet durumu (1-Önlisans, 2-Lisans):");
int mezuniyetDurumu = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Sigara kullanıyor musunuz? (E/H):");
char sigaraKullanimi = Convert.ToChar(Console.ReadLine() ?? "H");
var iseGirebilirSonuc = ((mezuniyetDurumu == 1 || mezuniyetDurumu == 2) && sigaraKullanimi == 'H') ? "Ise girebilir" : "Ise giremez";
Console.WriteLine(iseGirebilirSonuc);

Console.Write("Kullanici adi giriniz:");
string username = Console.ReadLine() ?? string.Empty;
Console.Write("Parola giriniz:");
string password = Console.ReadLine() ?? string.Empty;
var girisKontrolSonuc = (username == "admin" && password == "12345") ? "Giris basarili" : "Giris basarisiz";
Console.WriteLine(girisKontrolSonuc);

Console.WriteLine("\n-----------------------------\n");

