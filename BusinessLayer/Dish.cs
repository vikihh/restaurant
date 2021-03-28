using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Dish : Product
    {
        public string Ingredients { get; set; }

        public bool IsAvailableAtKitchen { get; set; }

        public bool IsVegetarian { get; set; }
    }
}
