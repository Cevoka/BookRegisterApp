using System;

// Kitap Class'ı - Bir kitabın özelliklerini ve davranışlarını tanımlar
public class Kitap
{
    // Property'ler - Kitap nesnesinin özelliklerini tanımlar
    public string Ad { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string Yayinevi { get; set; }
    public DateTime KayitTarihi { get; set; }

    // Constructor 1 - Default constructor (parametresiz)
    public Kitap()
    {
        // Nesne oluşturulduğunda kayıt tarihi otomatik olarak şu anki tarih olarak atanır
        KayitTarihi = DateTime.Now;
    }

    // Constructor 2 - Parametreli constructor
    public Kitap(string kitapAdi, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
    {
        Ad = kitapAdi;
        YazarAdi = yazarAdi;
        YazarSoyadi = yazarSoyadi;
        SayfaSayisi = sayfaSayisi;
        Yayinevi = yayinevi;
        // Her iki constructor için de kayıt tarihi otomatik atanır
        KayitTarihi = DateTime.Now;
    }

    // Kitap bilgilerini ekranda göstermek için metot
    public void KitapBilgileriniGoster()
    {
        Console.WriteLine("--- Kitap Bilgileri ---");
        Console.WriteLine($"Kitap Adı: {Ad}");
        Console.WriteLine($"Yazar: {YazarAdi} {YazarSoyadi}");
        Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
        Console.WriteLine($"Yayınevi: {Yayinevi}");
        Console.WriteLine($"Kayıt Tarihi: {KayitTarihi:dd/MM/yyyy HH:mm}");
        Console.WriteLine("----------------------");
    }
}

// Program class'ı - Uygulamanın ana sınıfı
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Patika Kütüphanesi Kitap Kayıt Uygulaması ===\n");

        // Örnek 1: Default constructor kullanarak kitap oluşturma
        Kitap kitap1 = new Kitap(); // New anahtar kelimesi ile yeni nesne oluşturulur
        kitap1.Ad = "Adı Aylin";
        kitap1.YazarAdi = "Ayşe";
        kitap1.YazarSoyadi = "Kulin";
        kitap1.SayfaSayisi = 398;
        kitap1.Yayinevi = "Remzi Kitabevi";

        // Örnek 2: Parametreli constructor kullanarak kitap oluşturma
        Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

        // Kitap bilgilerini ekranda göster
        Console.WriteLine("1. Kitap (Default Constructor ile oluşturuldu):");
        kitap1.KitapBilgileriniGoster();

        Console.WriteLine("\n2. Kitap (Parametreli Constructor ile oluşturuldu):");
        kitap2.KitapBilgileriniGoster();

        Console.WriteLine("\nProgram tamamlandı. Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}