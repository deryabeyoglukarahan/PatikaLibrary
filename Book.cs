namespace PatikaLibray
{
    // Class (Sınıf): Book adında bir sınıf tanımlanıyor.
    // Sınıf, kitap nesnesine ait bilgileri ve davranışları (metotları) içerir.
    internal class Book
    {
        // Constructor (Yapıcı Metot) - Parametresiz:
        // Book sınıfından bir nesne oluşturulduğunda, bu constructor çalışır
        // ve varsayılan değerleri atar.
        public Book()
        {
            BookName = "X Kitabı";
            AuthorName = "Ahmet";
            AuthorSurname = "Yılmaz";
            Page = 320;
            Publisher = "Alfa Yayınları";
            RegistrationDate = DateTime.Now;
        }

        // Constructor (Yapıcı Metot) - Parametreli:
        // Kitap bilgileri dışarıdan verildiğinde bu constructor kullanılır.
        public Book(string bookname, string authorname, string authorsurname, int page, string publisher)
        {
            BookName = bookname;
            AuthorName = authorname;
            AuthorSurname = authorsurname;
            Page = page;
            Publisher = publisher;
            RegistrationDate = DateTime.Now;
        }

        // Property (Özellik): Kitaba ait bilgileri tutan değişkenlerdir.
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int Page { get; set; }
        public string Publisher { get; set; }
        public DateTime RegistrationDate { get; set; }

        // Metot: Kitap bilgilerini ekrana yazdıran bir fonksiyon.
        public void BookInfo()
        {
            Console.WriteLine("Kitap Adı:" + BookName);
            Console.WriteLine("Yazar Adı:" + AuthorName);
            Console.WriteLine("Yazar Soyadı:" + AuthorSurname);
            Console.WriteLine("Sayfa Sayısı:" + Page);
            Console.WriteLine("Yayın Evi:" + Publisher);
            Console.WriteLine("Kayıt Tarihi:" + RegistrationDate.ToString("dd.MM.yyyy"));
        }
    }
}