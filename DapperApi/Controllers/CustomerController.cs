using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DapperApi.Data;
using DapperApi.Models;

namespace DapperApi.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public Customer Get()
        {
            ICustomerRepository rep = new SqLiteCustomerRepository();
            Customer retrievedCustomer = rep.GetCustomer(2);
            return retrievedCustomer;
//            return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }

        //public Customer GetCustomer()
        //{
        //    ICustomerRepository rep = new SqLiteCustomerRepository();
        //    Customer retrievedCustomer = rep.GetCustomer(2);
        //    return retrievedCustomer;
        //}
    }
}
