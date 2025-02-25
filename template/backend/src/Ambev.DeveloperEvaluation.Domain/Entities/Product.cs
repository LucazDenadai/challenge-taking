using System;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a product in the system with details and rating information.
    /// This entity follows domain-driven design principles and includes business rules validation.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the product.
        /// Must not be null or empty.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the product.
        /// Must be a positive value.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// Provides detailed information about the product.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the category of the product.
        /// Must not be null or empty.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the image URL of the product.
        /// Must be a valid URL format.
        /// </summary>
        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the rating of the product.
        /// Includes rate and count of ratings.
        /// </summary>
        public Rating Rating { get; set; } = new Rating();
    }

    /// <summary>
    /// Represents the rating of a product.
    /// Includes the rate and the count of ratings.
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Gets or sets the rate of the product.
        /// Must be a value between 0 and 5.
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the count of ratings.
        /// Must be a non-negative integer.
        /// </summary>
        public int Count { get; set; }
    }
}