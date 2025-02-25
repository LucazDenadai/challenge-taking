using System;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a shopping cart in the system with user and product information.
    /// This entity follows domain-driven design principles and includes business rules validation.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Gets or sets the unique identifier for the cart.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the user associated with the cart.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the date when the cart was created.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the collection of products in the cart.
        /// </summary>
        public List<CartProduct> Products { get; set; } = new List<CartProduct>();
    }

    /// <summary>
    /// Represents a product in the cart.
    /// Includes the product ID and the quantity.
    /// </summary>
    public class CartProduct
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}