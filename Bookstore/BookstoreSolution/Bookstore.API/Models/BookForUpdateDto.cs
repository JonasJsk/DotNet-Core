﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.Models
{
    public class BookForUpdateDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Title { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }
    }
}
