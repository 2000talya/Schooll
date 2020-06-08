using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bl;
using Dto;
namespace StatuSchool.Controllers
{
    [RoutePrefix("api/teacher")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TeacherController : ApiController
    {
        [HttpGet]
        [Route("committeacher")]
        public IHttpActionResult CommitTeacher([FromBody] teacherDTO teacher)
        {
            try
            {
                bool b = Bl.TeacherBl.CommitTeacher(teacher);
                if (b)
                    return Ok();
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("getstudentbyid")]
        public IHttpActionResult GetStudentById([FromUri]string id)
        {
            try
            {
                userDTO student = TeacherBl.GetStudentById(id);
                if (student != null)
                    return Ok();
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("getstudentbyname")]
        public IHttpActionResult GetStudentByName([FromUri] string firstname, string lastname)
        {
            try
            {
                List <userDTO> students = TeacherBl.GetStudentByName(firstname,lastname);
                if (students != null)
                    return Ok();
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

