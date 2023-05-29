using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tms.MysticShop.Service.Service;
using Tms.MysticShop.Web.Infrastructure.Core;
using Tms.MysticShop.Web.Models;

namespace Tms.MysticShop.Web.Controllers
{
    [RoutePrefix("api/UserRole")]
    public class UserRoleController : ApiController
    {
        
        private readonly IUserRoleService _userRoleService;
        public UserRoleController(IUserRoleService userRoleService)
        {
            this._userRoleService = userRoleService;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var check = _userRoleService.GetAll();
            var chec1 = Mapper.Map<List<UserRoleViewModel>>(check);
            return Request.CreateResponse(HttpStatusCode.OK, chec1);
        }
    }
}
