using eCommerce.DAL.Models;
using eCommerce.DTO.Property_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repository
{
    // Repository class that interacts with database
    public class eCommerceRepo
    {
        Context _context = new Context();
        public eCommerceRepo()
        {
            this._context = new Context();
        }
        public object Login(Login login)
        {
            try {
                var user = _context.user.Where(x => x.Username == login.Username).FirstOrDefault();
                if (user != null)
                {
                    if (user.Username == login.Username && user.Password == login.Password)
                    {
                        return new { IsLogin = true, Message = "User Exists" };
                    }
                    else
                    {
                        return new { IsLogin = false, Message = "Invalid Password" };
                    }
                }
                else
                {
                    return new { IsLogin = false, Message = "Invalid User" };
                }
            }
            catch(Exception ex)
            {
                return new { ExceptionMessage = ex.Message.ToString() };
            }
            
        }
        //public object GetProducts(Vendors vendor)
        //{
        //    try
        //    {
        //        return _context.products.Where(y => y.VendorID == vendor.VendorID).Select(x => new { x.ProductID, x.ProductName, x.ProductPrice, x.ProductCatID }).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        return new { ExceptionMessage = ex.Message.ToString() };
        //    }
            
        //}

        public object GetProductsbyAllVendors()
        {
            try
            {
                return _context.products.ToList();
            }
            catch (Exception ex)
            {
                return new { ExceptionMessage = ex.Message.ToString() };
            }
            
        }

        public object SaveOrder(ConfirmOrder order)
        {
            try
            {
                Orders co = new Orders();
                co.Amount = order.Amount;
                co.OrderID = order.OrderID;
                co.ProductCategory = order.ProductCategory;
                co.ProductID = order.ProductID;
                co.ProductPrice = order.ProductPrice;
                co.UserID = order.UserID;
                _context.orders.Add(co);
                _context.SaveChanges();
                return new { Status = "Saved" };
            }
            catch (Exception ex)
            {
                return new { Status = "Not Saved", Message=ex.Message.ToString() };
            }
        }


    }
}
