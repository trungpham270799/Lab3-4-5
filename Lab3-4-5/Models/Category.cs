﻿using System.ComponentModel.DataAnnotations;

namespace Lab3_4_5.Models
{
    public class Category
    {

        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}