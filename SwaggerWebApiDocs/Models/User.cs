namespace SwaggerWebApiDocs.Models
{
    /// <summary>
    /// Sample User Slass
    /// </summary>
    public class User : Person
    {
        /// <summary>
        /// Email of the User. For example, name@email.com
        /// </summary>
        public string Email { get; set; }
    }

    /// <summary>
    /// Person is humanbeing
    /// </summary>
    public class Person : Humanbeing
    {
        /// <summary>
        /// Name of the Person
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Humanbeing is a live being
    /// </summary>
    public class Humanbeing
    {
        /// <summary>
        /// Age of the Humanbeing
        /// </summary>
        public byte Age { get; set; }
    }
}