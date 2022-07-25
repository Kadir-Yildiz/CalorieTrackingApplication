using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOKI.UI
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public string CategoryName { get; set; }

        [Column(TypeName = "image")]
        public byte[] FoodImage { get; set; }
    }
}
