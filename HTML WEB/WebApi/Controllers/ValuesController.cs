using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {

        LocacaoDB locacaoDB = new LocacaoDB();
        // GET api/values
        [EnableCors(origins:"*", headers:"*",methods:"*")]

            public List<Carros> Get()
        {
            return locacaoDB.Carros.ToList<Carros>();
        }

        // GET api/values/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(int id)
        {
            return new string[] { "café", "value2" }[id];
        }

        // POST api/values
        public void Post(Usuarios value)
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
    }
}
