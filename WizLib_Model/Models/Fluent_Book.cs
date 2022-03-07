using System.Collections.Generic;

namespace WizLib_Model.Models;

public class Fluent_Book
{
    public int Book_Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }

    public int BookDetail_Id { get; set; }
    public Fluent_BookDetail Fluent_BookDetail { get; set; }

    public int Publisher_Id { get; set; }
    public Fluent_Publisher Fluent_Publisher { get; set; }

    public ICollection<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }
}