using System.Web.Http;
using SwaggerWebApiDocs.Models;

namespace SwaggerWebApiDocs.Controllers
{
    /// <summary>
    /// Sample User Controller
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// Getting User Model By User Name
        /// </summary>
        /// <param name="name">Name of the User as String</param>
        /// <returns>User Object</returns>
        [HttpGet]
        [Route("api/v1/GetUser/{name}")]
        public IHttpActionResult GetUserByName(string name)
        {
            return Ok(new User
            {
                Name = name,
                Email = string.Concat(name, "@mail.com")
            });
        }


        /// <summary>
        /// Adding User Model
        /// </summary>
        /// <param name="user">User Object</param>
        /// <returns>Name of the User as String</returns>
        [HttpPost]
        [Route("api/v1/AddUser")]
        public IHttpActionResult AddUser([FromBody] User user)
        {
            return Ok(user.Name);
        }
    }
}
