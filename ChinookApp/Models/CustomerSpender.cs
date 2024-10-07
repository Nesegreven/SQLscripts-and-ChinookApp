namespace ChinookApp.Models
{
    /// <summary>
    /// Represents a customer's spending information.
    /// This class is used for reporting purposes, specifically for the
    /// "Top Spenders" feature.
    /// </summary>
    public class CustomerSpender
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
        /// Gets or sets the total amount spent by the customer.
        /// This represents the sum of all invoice totals for the customer.
        /// </summary>
        public decimal TotalSpent { get; set; }
    }
}
