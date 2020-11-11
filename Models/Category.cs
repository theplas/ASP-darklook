using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_darklook.Models
{

        public class Category
        {
            public int Id { get; set; }

            [DisplayName(" Category Name ")]
            [Required(ErrorMessage = " Category name cannot be left blank ")]
            [MinLength(3, ErrorMessage = " Category name must be at least 3 characters ")]
            public string CategoryName { get; set; }

            [DisplayName(" Description of category ")]

            public List<Posts> Posts { get; set; }
        }
    }

