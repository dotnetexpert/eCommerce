using eCommerce.DTO.Property_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Services.Interfaces
{
    // This is an Interface for Controller & Service
    public interface IeCommerce
    {
        object Login(Login login);        
        object GetProductsbyAllVendors();
        object SaveOrder(ConfirmOrder order);

        //object GetProducts(Vendors vendor);


    }
}
