﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models;

public class Publisher
{
    [Key] public int Publisher_Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string Location { get; set; }

    public List<Book> Books { get; set; }
}