using PatikaLibray;

Console.WriteLine("Patika Kütüphanesi");
Console.WriteLine("------------------");

// new anahtar kelimesi ile Book sınıfından bir nesne oluşturuluyor.
Book book1 = new Book(); // Parametresiz constructor çalışır.
book1.BookInfo(); // BookInfo metodu çağrılarak bilgileri ekrana yazdırılır.

Console.WriteLine("******************");

// new anahtar kelimesi ile bu sefer parametreli constructor kullanılarak Book sınıfından yeni bir nesne oluşturuluyor.
Book newBook = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
newBook.BookInfo(); // Oluşturulan nesnenin bilgileri yazdırılır.
