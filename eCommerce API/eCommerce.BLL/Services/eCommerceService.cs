using eCommerce.BLL.Services.Interfaces;
using eCommerce.DAL.Repository;
using eCommerce.DTO.Property_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Services
{
    // This is a service class that helps to access repository class
    public class eCommerceService: IeCommerce
    {
        public readonly eCommerceRepo repository;
        public eCommerceService()
        {
            this.repository = new eCommerceRepo();
        }

        public object Login(Login login)
        {
            return repository.Login(login);
        }
        //public object GetProducts(Vendors vendor)
        //{
        //    return repository.GetProducts(vendor);
        //}

        public object GetProductsbyAllVendors()
        {
            return repository.GetProductsbyAllVendors();
        }
        public object SaveOrder(ConfirmOrder order)
        {
            return repository.SaveOrder(order);
        }



    }
}
