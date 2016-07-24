using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DapperApi.Data;
using DapperApi.Models;
using Microsoft.Owin.Security.Google;

namespace DapperApi.Controllers
{
    [AllowAnonymous, EnableCors(origins: "http://localhost:9000", headers: "*", methods: "*"), RoutePrefix("api/ListType")]
    public class ListTypeController : ApiController
    {
        // GET: api/ListType
        [Route("Get")]
        public IEnumerable<ListType> Get()
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            IEnumerable<ListType> retrievedListTypes = lrep.GetAll();
            return retrievedListTypes;
//            return new string[] { "value1", "value2" };
        }

        // GET: api/ListType/5
        [Route("GetById/{Id}")]
        public IEnumerable<dynamic> Get(int id)
        {
            if (id == 1 || id == 3)
            {
                var otherCall = GetGenericList(id);
            }
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            ListType currentList = lrep.GetById(id);
            var tableName = currentList.Name;
            var columnList = currentList.Description;
            IEnumerable<dynamic> retrievedType = lrep.GetCurrentList(tableName, columnList);
            return retrievedType;
            //            return "value";
        }

        [Route("GetGenericList/{Id}")]
        public IEnumerable<GenericList> GetGenericList(int id)
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            return lrep.GetGenericList(id);
        }

        [Route("GetActionTypeList")]
        public IEnumerable<ActionTypeList> GetActionTypeList()
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            return lrep.GetActionTypeList();
        }

        [Route("GetCaliberList")]
        public IEnumerable<CaliberList> GetCaliberList()
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            return lrep.GetCaliberList();
        }

        [Route("GetFirearmTypeList")]
        public IEnumerable<FirearmTypeList> GetFirearmTypeList()
        {
            IListTypeRepository lrep = new SqLiteListTypeRepository();
            return lrep.GetFirearmTypeList();
        }

        // POST: api/ListType
        public int[] Post([FromBody]IEnumerable<ActionTypeList> value)
        {
            var allIds= new int[2];
            var actionTypeLists = value as ActionTypeList[] ?? value.ToArray();
            for (int i = 0; i < actionTypeLists.Count(); i++)
            {
                allIds[i] = actionTypeLists[i].Id;
            }
            return allIds;
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
