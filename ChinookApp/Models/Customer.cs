﻿namespace ChinookApp.Models
{
    /// <summary>
    /// Represents a simplified view of a customer in the Chinook database.
    /// This class contains only the essential customer information
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// This is typically auto-generated by the database.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the customer.
        /// This field is required and cannot be null.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the customer.
        /// This field is required and cannot be null.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the country where the customer resides.
        /// This field is optional and can be null.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the postal code of the customer's address.
        /// This field is optional and can be null.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the customer.
        /// This field is optional and can be null.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email address of the customer.
        /// This field is required and cannot be null.
        /// </summary>
        public string Email { get; set; }
    }
}
