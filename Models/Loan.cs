using System;
using System.ComponentModel.DataAnnotations;

namespace KütüphaneOtomasyon.Models
{
    public class Loan
    {
        public int Id { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        [Display(Name = "Alınan Tarih")]
        public DateTime BorrowDate { get; set; }

        [Display(Name = "İade Tarihi")]
        public DateTime? ReturnDate { get; set; }
    }
}


