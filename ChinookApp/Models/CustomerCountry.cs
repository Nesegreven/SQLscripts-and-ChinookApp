namespace ChinookApp.Models
{
    /// <summary>
    /// Represents the count of customers in a specific country.
    /// This class is used for reporting purposes, specifically for the 
    /// "Customer Count by Country" feature.
    /// </summary>
    public class CustomerCountry
    {
        /// <summary>
        /// Gets or sets the name of the country.
        /// This field cannot be null and represents a unique country name.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the number of customers in the country.
        /// This field represents the count of customers associated with the country.
        /// </summary>
        public int CustomerCount { get; set; }
    }
}
