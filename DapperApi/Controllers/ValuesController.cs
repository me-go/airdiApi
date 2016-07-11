using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Dapper;

namespace DapperApi.Controllers
{
    [AllowAnonymous, EnableCors(origins: "http://localhost:9000", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<FirearmType> Get()
        {
            using (var connection = new SQLiteConnection(@"Data Source=E:\Documents\Sqlite\AIRD.db"))
            {
                var armsType = connection.Query<FirearmType>(@"select id, name from firearmType");
                return armsType;
            }
//            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public FirearmType Get(int id)
        {
            using (var connection = new SQLiteConnection(@"Data Source=E:\Documents\Sqlite\AIRD.db"))
            {
                var armsType = connection.Query<FirearmType>(@"select id, name from firearmType WHERE id = @id",new {id}).First();
                return armsType;
            }
//            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public class FirearmType
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
