using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using WizLib_Model.Models;

namespace WizLib_Model.ViewModels;

public class BookAuthorVM
{
    public BookAuthor BookAuthor { get; set; }
    public Book Book { get; set; }
    public IEnumerable<BookAuthor> BookAuthorList { get; set; }
    public IEnumerable<SelectListItem> AuthorList { get; set; }
}