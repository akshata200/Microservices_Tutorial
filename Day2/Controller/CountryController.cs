using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countryList = new List<Country>()
        {
            new Country{ID=1,Name="India",Capital="Delhi"},
            new Country{ID=2,Name="Japan",Capital="Tokyo"},
            new Country{ID=3,Name="America",Capital="Washington DC"},
            new Country{ID=4,Name="England",Capital="London"},
        };

        // GET Methods
        [HttpGet]
        public List<Country> Get()
        {
            return countryList;
        }


        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetCountryById(int id)
        {
            Country countryObj = countryList.Find(item => item.ID == id);
            if(countryObj == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, id);
            }
            return Request.CreateResponse(HttpStatusCode.OK, countryObj);
        }

        [HttpGet]
        [Route("CountryName/{name}")]
        public HttpResponseMessage GetByCountryName(string name)
        {
            Country countryObj = countryList.Find(item => item.Name.Equals(name));
            if (countryObj == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, name);
            }
            return Request.CreateResponse(HttpStatusCode.OK, countryObj);
        }

        [HttpGet]
        [Route("Capital/{capital}")]
        public HttpResponseMessage GetByCapitalName(string capital)
        {
            Country countryObj = countryList.Find(item => item.Capital.Equals(capital));
            if (countryObj == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, capital);
            }
            return Request.CreateResponse(HttpStatusCode.OK, countryObj);
        }

        [HttpGet]
        [Route("NameById/{id}")]
        public IHttpActionResult GetCountryNameById(int id)
        {
            Country obj = countryList.Find(item => item.ID == id);
            if (obj != null)
            {
                return Ok(obj.Name);
            }
            return NotFound();
        }


        [HttpPost]
        public List<Country> Post([FromBody] Country obj)
        {
            countryList.Add(obj);
            return countryList;
        }

        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult Put([FromBody] Country newObj)
        {
            Country oldObj = countryList.Find(item => item.ID == newObj.ID);
            if(oldObj != null)
            {
                int index = countryList.IndexOf(oldObj);
                countryList.Remove(oldObj);
                countryList.Insert(index, newObj);
                return Ok();

            }
            return NotFound();
            
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            Country obj = countryList.Find(item => item.ID == id);
            if (obj != null)
            {
                bool isRemoved = countryList.Remove(obj);
                if (isRemoved)
                {
                    return Ok(obj);
                }
            }
            return NotFound();
        }
    }
}
