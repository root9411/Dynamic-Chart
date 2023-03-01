using System.ComponentModel.DataAnnotations;

namespace Daynamic_Chart.Models
{
    public class SalesEntity
    {
        [Key]
        public int Id { get; set; }
        public string Monthname { get; set; }
        public int TotalSales { get; set; }
    }
}
