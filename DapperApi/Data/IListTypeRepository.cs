using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperApi.Models;

namespace DapperApi.Data
{
    public interface IListTypeRepository
    {
        IEnumerable<ListType> GetAll();
        ListType GetById(int id);
        void SaveNewListType(ListType listType);
        IEnumerable<dynamic> GetCurrentList(string tableName, string columnList);
    }
}
