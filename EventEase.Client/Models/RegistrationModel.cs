using System.ComponentModel.DataAnnotations; // Enables validation attributes like [Required], [EmailAddress]

namespace EventEase.Client.Models
{
    /// <summary>
    /// Represents the data model for event registration.
    /// Used in the registration form to collect and validate user input.
    /// </summary>
    public class RegistrationModel
    {
        /// <summary>
        /// The user's full name.
        /// This field is required and must not be empty.
        /// </summary>
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = "";

        /// <summary>
        /// The user's email address.
        /// This field is required and must follow a valid email format.
        /// </summary>
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = "";
    }
}
