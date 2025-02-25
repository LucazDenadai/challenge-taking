namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents the name of a user.
    /// Includes first name and last name.
    /// </summary>
    public class Name
    {
        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        public string LastName { get; set; } = string.Empty;
    }
}