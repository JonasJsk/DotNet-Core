﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.Entities
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string AuthorName { get; set; }

        override
        public string ToString()
        {
            return AuthorName;
        }

        public ICollection<Book> Book { get; set; }

        // Initialize an empty list to avoid Null reference exception when trying to manipulate 
        // list when points of interest have not loaded yet.
            = new List<Book>();
    }
}
