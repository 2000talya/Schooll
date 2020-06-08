using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bl;
using System.Web.Http.Cors;

namespace StatuSchool.Controllers
{
    [RoutePrefix("api/user")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register([FromBody] userDTO user)
        {
            if (UserBl.Register(user))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        [Route("login")]
        public IHttpActionResult Login([FromUri] string id, string password)
        {
            try
            {
                Dto.userDTO u = UserBl.Login(id, password);
                if (u != null)
                    return Ok(u);
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
