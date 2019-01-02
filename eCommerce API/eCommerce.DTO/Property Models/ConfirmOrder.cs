using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DTO.Property_Models
{
    public class ConfirmOrder
    {
        public int OrderID { get; set; }
        public int Amount { get; set; }
        public int ProductPrice { get; set; }
        public int ProductID { get; set; }
        public int ProductCategory { get; set; }
        public int UserID { get; set; }
    }
}
