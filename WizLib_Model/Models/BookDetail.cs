using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models;

public class BookDetail
{
    [Key] public int BookDetail_Id { get; set; }

    [Required] public int NumberOfChapters { get; set; }

    public int NumberOfPages { get; set; }
    public double Weight { get; set; }

    public Book Book { get; set; }
}