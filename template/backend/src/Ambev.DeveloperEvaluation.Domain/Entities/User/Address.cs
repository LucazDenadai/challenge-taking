namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents the address of a user.
    /// Includes city, street, number, zipcode, and geolocation.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the city of the user's address.
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the street of the user's address.
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of the user's address.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the zipcode of the user's address.
        /// </summary>
        public string Zipcode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the geolocation of the user's address.
        /// Includes latitude and longitude.
        /// </summary>
        public Geolocation Geolocation { get; set; } = new Geolocation();
    }
}