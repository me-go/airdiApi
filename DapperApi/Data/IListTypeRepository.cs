using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Razor;
using DapperApi.Models;

namespace DapperApi.Data
{
    public interface IListTypeRepository
    {
        IEnumerable<ListType> GetAll();
        ListType GetById(int id);
        void SaveNewListType(ListType listType);
        IEnumerable<dynamic> GetCurrentList(string tableName, string columnList);
        IEnumerable<GenericList> GetGenericList(int id);
        IEnumerable<ActionTypeList> GetActionTypeList();
        IEnumerable<CaliberList> GetCaliberList();
        IEnumerable<FirearmTypeList> GetFirearmTypeList();
        IEnumerable<dynamic> UpSertActionTypeList(string name, string description);
        string DeleteTable(string tableName);
    }
}
