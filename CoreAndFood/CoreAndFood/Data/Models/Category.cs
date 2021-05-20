﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Category Name Not Empty")] //Gerekli
        [StringLength(20, ErrorMessage = "Please only enter 4-20 characters", MinimumLength = 4)]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Food> Foods { get; set; }

    }
}
