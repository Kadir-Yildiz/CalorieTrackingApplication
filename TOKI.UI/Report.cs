using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOKI.UI
{
    public class Report
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string MealType { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date { get; set; }
        public string FoodName { get; set; }
        public int Portion { get; set; }
        public double FoodCal { get; set; }
    }
}
