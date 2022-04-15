using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models;

[Table("Genre")]
public class Genre
{
    public int GenreId { get; set; }

    [Column("Name")] public string GenreName { get; set; }
    //public int DisplayOrder { get; set; }
}