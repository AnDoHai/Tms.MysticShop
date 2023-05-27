using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tms.MysticShop.Web.Infrastructure.Core;

namespace Tms.MysticShop.Web.Controllers
{
    [RoutePrefix("api/UserRole")]
    public class UserRoleController : ApiControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "valie1", "valie2" };
        }

        [Route("GetAll")]
        public HttpResponseMessage Get1()
        {
            return new HttpResponseMessage();
        }
    }
}
