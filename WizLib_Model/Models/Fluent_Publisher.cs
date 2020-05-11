using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib_Model.Models
{
    public class Fluent_Publisher
    {
        public int Publisher_Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
        public List<Fluent_Book> Fluent_Book { get; set; }

    }
}
