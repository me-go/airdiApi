using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Dapper;
using DapperApi.Models;

namespace DapperApi.Data
{
    public class SqLiteCustomerRepository:SqLiteBaseRepository, ICustomerRepository
    {
        public Customer GetCustomer(long id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Customer result = cnn.Query<Customer>(
                    @"SELECT Id, FirstName, LastName, BirthDate
                    FROM Customer
                    WHERE Id = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public void SaveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}