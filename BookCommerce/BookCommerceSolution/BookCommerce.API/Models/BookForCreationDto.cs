﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BookCommerce.API.Models
{
    public class BookForCreationDto
    {
        [Required(ErrorMessage = "You should provide a title value.")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "You should provide a genre value.")]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Required(ErrorMessage = "You should provide a description value.")]
        [MaxLength(400)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public DateTime PublishingDate { get; set; }
        
    }
}
