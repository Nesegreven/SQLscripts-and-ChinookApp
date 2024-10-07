namespace ChinookApp.Models
{
    /// <summary>
    /// Represents a customer's favorite music genre.
    /// This class is used for reporting purposes, specifically for the
    /// "Most Popular Genre for Customer" feature.
    /// </summary>
    public class CustomerGenre
    {
        /// <summary>
        /// Gets or sets the unique identifier of the customer.
        /// This corresponds to the CustomerId in the Customer table.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the full name of the customer.
        /// This is typically a concatenation of FirstName and LastName.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer's favorite music genre.
        /// This represents the genre with the most purchases for this customer.
        /// </summary>
        public string GenreName { get; set; }

        /// <summary>
        /// Gets or sets the number of purchases the customer has made in this genre.
        /// This count helps determine which genre is the most popular for the customer.
        /// </summary>
        public int PurchaseCount { get; set; }
    }
}
