using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DapperApi.Data;
using DapperApi.Models;

namespace DapperApi.Controllers
{
    [AllowAnonymous, EnableCors(origins: "http://localhost:9000", headers: "*", methods: "*")]
    public class ListTypeController : ApiController
    {
        // GET: api/ListType
        public IEnumerable<ListType> Get()
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            IEnumerable<ListType> retrievedListTypes = lrep.GetAll();
            return retrievedListTypes;
//            return new string[] { "value1", "value2" };
        }

        // GET: api/ListType/5
        public IEnumerable<dynamic> Get(int id)
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            ListType currentList = lrep.GetById(id);
            var tableName = currentList.Name;
            var columnList = currentList.Description;
            IEnumerable<dynamic> retrievedType = lrep.GetCurrentList(tableName, columnList);
            return retrievedType;
            //            return "value";
        }

        // POST: api/ListType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ListType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ListType/5
        public void Delete(int id)
        {
        }
    }
}
