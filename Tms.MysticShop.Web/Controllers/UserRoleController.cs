using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tms.MysticShop.Service.Service;
using Tms.MysticShop.Web.Infrastructure.Core;

namespace Tms.MysticShop.Web.Controllers
{
    [RoutePrefix("api/UserRole")]
    public class UserRoleController : ApiControllerBase
    {
        IUserRoleService _userRoleService;
        public UserRoleController(IUserRoleService userRoleService)
        {
            this._userRoleService = userRoleService;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var check = _userRoleService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, check);
        }
    }
}
