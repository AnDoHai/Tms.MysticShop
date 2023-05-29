using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tms.MysticShop.Model.Models;
using Tms.MysticShop.Service.Service;
using Tms.MysticShop.Web.Infrastructure.Core;
using Tms.MysticShop.Web.Models;

namespace Tms.MysticShop.Web.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request,int page,int pageSize)
        {
            int totalRow = 0;
            var users = _userService.GetAll();
            var usersRef = new List<UserViewModel>();

            if (users.Any() && users.Count() > 0)
            {
                totalRow = users.Count();
                var query = users.OrderByDescending(c=>c.UserID).Skip(page * pageSize).Take(pageSize);
                usersRef = Mapper.Map<List<UserViewModel>>(query);

            }
            var paginationSet = new PaginationSet<UserViewModel>()
            {
                Items = usersRef,
                Page = page,
                TotalCount = totalRow,
                TotalPages = (int)Math.Ceiling((decimal)totalRow/pageSize),
            };

            return Request.CreateResponse(HttpStatusCode.OK, paginationSet);
        }
    }
}
