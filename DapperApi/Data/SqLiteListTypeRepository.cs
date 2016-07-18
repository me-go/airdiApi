using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Dapper;
using DapperApi.Models;

namespace DapperApi.Data
{
    public class SqLiteListTypeRepository:SqLiteBaseRepository, IListTypeRepository
    {
        public IEnumerable<ListType> GetAll()
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
               IEnumerable<ListType> result = cnn.Query<ListType>(@"select Id, Name, Description from listTypes;");
                return result;
            }
        }

        public ListType GetById(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
               ListType result = cnn.Query<ListType>(@"select Id, Name, Description from listTypes WHERE Id = @id;", new { id }).First();
                return result;
            }
        }

        public void SaveNewListType(ListType listType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> GetCurrentList(string tableName, string columnList)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                IEnumerable<ListType> result = cnn.Query<ListType>(@"select " + columnList + " from " + tableName + ";");
                return result;
            }
        }

        public GenericList[] GetGenericList(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<GenericList>(@"SELECT * FROM BasicLists WHERE ListTypeId = @ListTypeId;", new {ListTypeId = id }).ToArray();
//                return result;
            }
        }
    }
}