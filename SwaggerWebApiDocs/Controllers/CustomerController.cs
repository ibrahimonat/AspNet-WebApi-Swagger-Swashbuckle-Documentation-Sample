using System.Web.Http;
using SwaggerWebApiDocs.Models;

namespace SwaggerWebApiDocs.Controllers
{
    /// <summary>
    /// Sample Customer Controller
    /// </summary>
    public class CustomerController : ApiController
    {
        /// <summary>
        /// Getting Customer Model By Customer Name
        /// </summary>
        /// <param name="name">Name of the Customer as String</param>
        /// <returns>Customer Object</returns>
        [Route("api/v1/Customer/{name}")]
        public IHttpActionResult Get(string name)
        {
            return Ok(new Customer
            {
                Name = name,
                Address = "Canakkale"
            });
        }


        /// <summary>
        /// Adding Customer Model
        /// </summary>
        /// <param name="customer">Customer Object</param>
        /// <returns>Customer</returns>
        [Route("api/v1/Customer")]
        public Customer Post([FromBody] Customer customer)
        {
            return new Customer();
        }
    }
}
