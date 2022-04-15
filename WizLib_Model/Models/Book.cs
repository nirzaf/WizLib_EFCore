using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models;

public class Book
{
    [Key] public int Book_Id { get; set; }

    [Required] public string Title { get; set; }

    [Required] [MaxLength(15)] public string ISBN { get; set; }

    [Required] public double Price { get; set; }

    [ForeignKey("BookDetail")] public int? BookDetailId { get; set; }

    public BookDetail BookDetail { get; set; }

    [ForeignKey("Publisher")] public int PublisherId { get; set; }

    public Publisher Publisher { get; set; }

    public ICollection<BookAuthor> BookAuthors { get; set; }
}