using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class ValueController : ApiController
    {
        static List<string> pracStr = new List<string>() {"Value1", "Value2", "Value3" };
        public IEnumerable<string> Get()
        {
            return pracStr;
        }
        public string Get(int id)
        {
            return "valueSomething";
        }

        public IEnumerable<string> Post([FromBody]string val)
        {
            pracStr.Add(val);
            return pracStr;
        }
    }
}
