using KütüphaneOtomasyon.Models;

namespace KütüphaneOtomasyon.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } // Kitap adı
        public string Author { get; set; } // Yazar adı

        public List<Loan> Loans { get; set; } // Bu kitapla ilgili ödünçler
    }
}

