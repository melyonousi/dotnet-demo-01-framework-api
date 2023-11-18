using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dotnet_demo_framework_api_04.Controllers
{
    //[Route("api/custom-name")] 
    //[RoutePrefix("api/controllers/custom-name")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return $"content galak {value}";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public HttpResponseMessage Archive(int year, int month = 0, int day = 0)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [Route("api/values/add-customer")]
        [HttpPost]
        public string AddCustomer(string customer)
        {
            return customer;
        }
    }
}
