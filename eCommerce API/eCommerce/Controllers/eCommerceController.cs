using eCommerce.BLL.Services;
using eCommerce.BLL.Services.Interfaces;
using eCommerce.DTO.Property_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eCommerce.Controllers
{
    [RoutePrefix("api/eCommerce")]
    public class eCommerceController : ApiController
    {
        private readonly IeCommerce eCommerce;
        public eCommerceController()
        {
            this.eCommerce = new eCommerceService();
        }
        // POST method to Login
        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login(Login login)
        {
            return Ok(eCommerce.Login(login));
        }

        // GET method to fetch products by all vendors
        [HttpGet]
        [Route("GetProductsbyAllVendors")]
        public IHttpActionResult GetProductsbyAllVendors()
        {
            return Ok(eCommerce.GetProductsbyAllVendors());
        }

        // POST method to save orders
        [HttpPost]
        [Route("ConfirmOrder")]
        public IHttpActionResult SaveOrder(ConfirmOrder order)
        {
            return Ok(eCommerce.SaveOrder(order));
        }


        // POST method to fetch products by selected vendors.  ** Currently not in use
        //[HttpPost]
        //[Route("GetProductsbyVendor")]
        //public IHttpActionResult GetProductsbyVendor(Vendors vendor)
        //{
        //    return Ok(eCommerce.GetProducts(vendor));
        //}




    }
}
