using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api/Person")]
    public class PersonController : ApiController
    {
        static List<Person> personList = new List<Person>()
        {
            new Person{ID=1,Name="Smith",City="NJ"},
            new Person{ID=2,Name="Dean",City="MI"},
            new Person{ID=3,Name="Yisel",City="FL"},
            new Person{ID=4,Name="Carlos",City="NJ"},
        };

        [HttpGet]
        public List<Person> Get()
        {
            return personList;
        }

        [HttpGet]
        [Route("{id}")]
        public Person GetPersonById(int id)
        {
            Person personObj = personList.Find(item => item.ID == id);
            return personObj;
        }

        [HttpGet]
        [Route("City/{city}")]
        public IEnumerable<Person> GetAllPersonByCityName(string city)
        {
            IEnumerable<Person> cityList = personList.Where(item => item.City.Equals(city));
            return cityList;
        }

        [HttpGet]
        [Route("Name/{name}")]
        public Person GetPersonByName(string name)
        {
            Person obj = personList.SingleOrDefault(item => item.Name.Equals(name));
            return obj;
        }

        [HttpGet]
        [Route("NameById/{id}")]
        public IHttpActionResult GetPersonName(int id)
        {
            Person personObj = personList.Find(item => item.ID == id);
            if (personObj != null)
            {
                return Ok(personObj.Name);
            }
            return NotFound();
        }


        [HttpPost]
        public List<Person> Post([FromBody]Person obj)
        {
            personList.Add(obj);
            return personList;
        }

        [HttpPut]
        [Route("{id}")]
        public void Put([FromBody]Person newObj)
        {
            Person oldObj = personList.Find(item => item.ID == newObj.ID);
            personList.Remove(oldObj);
            personList.Add(newObj);
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            Person obj = personList.Find(item => item.ID == id);
            if (obj != null)
            {
                bool isRemoved = personList.Remove(obj);
                if (isRemoved)
                {
                    return Ok(obj);
                }
            }
            return NotFound();
        }

    }
}
