namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents the geolocation of an address.
    /// Includes latitude and longitude.
    /// </summary>
    public class Geolocation
    {
        /// <summary>
        /// Gets or sets the latitude of the geolocation.
        /// </summary>
        public string Lat { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the longitude of the geolocation.
        /// </summary>
        public string Long { get; set; } = string.Empty;
    }
}