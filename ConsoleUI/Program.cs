﻿#region Değişkenler

// var yil = 2023; // Derlemede aşamasında veri tipini kendisi belirliyor

// Type safety, tip güvenli
// Bellekte kaplacayacağı alanı önceden ayırmış oluyoruz hem de, alabileceği değerleri ve aralığını belirlemiş oluyoruz.

// İlkel/Değer tip
//int yil = 2023; // 32-bit ~-2.1mr - ~2.1mr // default değeri: 0 (ondalik) // 00000000 (ikilik)
//short yil = 2023; // 16-bit ~-32bin - ~32bin // default: 0
ushort yil = 2023; // unsigned // 16-bit 0 - ~65bin // default: 0

byte yas = 25; // 0-255 // default: 0
long hesaplamaTamSayiSonucu = 9999999999999; // 64-bit // default: 0

//float dolarKuru = 29.06f; // 32-bit // default: 0.0
double dolarKuru = 29.06593; // 64-bit // default: 0.0
decimal hesaplamaSonucu = 29.06592312931290312903m; // 128-bit // default: 0.0

bool girisYaptiMi = true; // 1-bit // default: false

char karakter = 'A'; // 65 // Ek bilgi: Unicode ASCII tablolarına göre 65 // 16-bit // default: 0 // Unicode ASCII U+0000 (NULL)

// String aslında bir referans tip, İlkel/Değer tip
string isim = "Ahmet"; // 32-bit // 16mr-bit'e kadar genişleyebiliyor // default: null

string? takmaAd = null;
if(takmaAd != null)
    Console.WriteLine(takmaAd.ToUpper()); // takmaAd null ise ToUpper metodunu çalıştırmaya çalışmayacak ve null değerini bize verecek.

Console.WriteLine(takmaAd?.ToUpper()); // takmaAd null ise ToUpper metodunu çalıştırmaya çalışmayacak ve null değerini bize verecek.

Console.WriteLine(takmaAd ?? "Takma ismi bulunmuyor"); // takmaAd null ise sağdaki değeri bize verecek.

// ek bilgi: DRY - Do not Repeat Yourself
// ek bilgi: mccall software quality model

int sayi1 = 10;
int sayi2 = 20;
int sayi3 = 30;
int sayiSonuc = sayi1 + sayi2 * sayi3;

string isim2 = "Ahmet";
string soyad = "Çetinkaya";
string tamIsim = isim2 + " " + soyad;

bool durum1 = true;
bool durum2 = false;
bool sonucDurum = durum1 && durum2; // false
bool sonucDurum2 = durum1 || durum2; // true

int tamSayi = 10;
double ondalikLiSayi = tamSayi; // 10.0 // Implisit (biliçsiz) tür dönüşümü

double ondalikliSayi2 = 10.5;
//int tamSayi2 = ondalikliSayi2; // Veri kaybı olacağı için implist şekilde tür dönüşümü yapmayacaktır
int tamSayi2 = (int)ondalikliSayi2; // Casting // Explist (bilinçli) tür dönüşümü

long buyukTamSayi = long.MaxValue; // 64-bit
int normalTamSayi = (int)buyukTamSayi; // 64-bit -> 32-bit // Hata: -1

// Daha güvenli tür dönüşüm işlemleri için:
//int normalTamSayi2 = Convert.ToInt32(buyukTamSayi); // Error: değer int'e göre çok büyük
string metinselTamSayi = buyukTamSayi.ToString();

//double 2OndalıkSayı // Invalid
double ondalik_sayi = long.MaxValue; // Valid
//double double = double.MaxValue;
double @double = double.MaxValue;
//double ondalik sayi = long.MaxValue; // Invalid

#endregion


