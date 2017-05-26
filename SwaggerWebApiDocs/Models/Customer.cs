using System.Collections.Generic;
using Swashbuckle.Swagger;

namespace SwaggerWebApiDocs.Models
{
    /// <summary>
    /// Sample Class for Customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Name of the Customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address of the Customer
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// AdditionalArgs of the User
        /// </summary>
        public AdditionalArgs AdditionalArgs { get; set; }
    }

    /// <summary>
    /// Additional informations for User
    /// </summary>
    public class AdditionalArgs
    {
        /// <summary>
        /// Additional information property for User
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }
    }
}