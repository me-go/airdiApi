﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Dapper;
using DapperApi.Models;

namespace DapperApi.Data
{
    public class SqLiteListTypeRepository : SqLiteBaseRepository, IListTypeRepository
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

        public IEnumerable<GenericList> GetGenericList(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<GenericList>(@"SELECT * FROM BasicLists WHERE ListTypeId = @ListTypeId;", new { ListTypeId = id });
                //                return result;
            }
        }

        public IEnumerable<ActionTypeList> GetActionTypeList()
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<ActionTypeList>(@"SELECT Id, ListTypeId, Name, Description FROM ActionType;");
                //                return result;
            }
        }

        public IEnumerable<CaliberList> GetCaliberList()
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CaliberList>(@"SELECT Id, ListTypeId, CaliberInches, CaliberMetricDiameter, CaliberMetricLength FROM Caliber;");
                //                return result;
            }
        }

        public IEnumerable<FirearmTypeList> GetFirearmTypeList()
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<FirearmTypeList>(@"SELECT Id, ListTypeId, Name, Description FROM FirearmType;");
                //                return result;
            }
        }
        public IEnumerable<dynamic> UpSertActionTypeList(int id, string name, string description)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                if (id == -1)
                {
                    return cnn.Query<dynamic>(@"INSERT OR REPLACE INTO ActionType(ListTypeId, Name, Description) VALUES ((SELECT Id FROM ListTypes WHERE Name = 'ActionType'),'" + name + "','" + description + "');");
                }
                else
                {
                    return cnn.Query<dynamic>(@"INSERT OR REPLACE INTO ActionType(Id, ListTypeId, Name, Description) VALUES ("+id+",(SELECT Id FROM ListTypes WHERE Name = 'ActionType'),'" + name + "','" + description + "');");
                }
            }
        }
        public string DeleteTable(string tableName)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Query<dynamic>(@"DELETE FROM " + tableName + ";");
                cnn.Query<dynamic>(@"DELETE FROM sqlite_sequence WHERE name = '" + tableName + "';");
            }
            return "Success";
        }
    }
}