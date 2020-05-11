using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib_Model.Models
{
    public class Fluent_BookAuthor
    {
        //[Key]
        public int Book_Id { get; set; }
        //[Key]
        public int Author_Id { get; set; }
        public Fluent_Book Fluent_Book { get; set; }
        public Fluent_Author Fluent_Author { get; set; }

    }
}
