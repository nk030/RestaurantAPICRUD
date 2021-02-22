using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantAPICRUD.Models
{
    // Model Class for EF Food Table
    public class Food
    {
        [Key] // identity column
        public int Id { get; set; }
        public string Name { get; set; } // name of the food
        public int Quantity { get; set; } // quanty available
        public int Price { get; set; } // price of the food item
        [DataType(DataType.Date)]
        public DateTime Expire { get; set; } // food expire date

    }
}