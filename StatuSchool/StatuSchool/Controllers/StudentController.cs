using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Dto;
using Bl;
namespace StatuSchool.Controllers
{
    [RoutePrefix("api/student")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {
        [HttpPost]
        [Route("commitstudent")]
        public IHttpActionResult CommitStudent([FromBody] studentDTO student)
        {
            try
            {
                bool b = Bl.StudentBl.CommitStudent(student);
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
        [Route("getmarksbyid")]
        public IHttpActionResult GetMarksById([FromUri]string id)
        {
            try
            {
                List<marksDTO> marks = Bl.MarkBl.GetMarksById(id);
                if (marks != null)
                    return Ok();
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("getpresencebyid")]
        public IHttpActionResult GetPresenceById([FromUri]string id)
        {
            try
            {
                List<presenceDTO> presences = Bl.PresenceBl.GetPresenceById(id);
                if (presences != null)
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
