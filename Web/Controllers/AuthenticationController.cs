using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models.Authentication;

namespace Pitchtrack.Web.Controllers
{
    public class AuthenticationController : ApiController
    {
        // GET api/authentication
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/authentication/5
        public Account Get(string key)
        {
	        return new Account();
        }

        // POST api/authentication
        public HttpResponseMessage Post([FromBody]Account account)
        {
	        return Request.CreateResponse(HttpStatusCode.Created);
        }

        // PUT api/authentication/5
		public HttpResponseMessage Put(string key, [FromBody]Account account)
		{
			return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, "NOT IMPLEMENTED");
		}

        // DELETE api/authentication/5
		public HttpResponseMessage Delete(int id)
        {
			return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, "NOT IMPLEMENTED");
        }
    }
}
