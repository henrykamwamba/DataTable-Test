using System.ComponentModel.DataAnnotations;

namespace DataTable.Models
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        public string Gender { get; set; }
    }
}
