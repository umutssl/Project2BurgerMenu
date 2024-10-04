using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Models.Entities
{
    public class Category
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}