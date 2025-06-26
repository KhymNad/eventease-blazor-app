namespace EventEase.Services
{
    /// <summary>
    /// A simple service to store user information during their session.
    /// Used for session state management in a Blazor WebAssembly app.
    /// 
    /// This is an in-memory service and does not persist data between page reloads.
    /// Register as a singleton in Program.cs to maintain state across components.
    /// </summary>
    public class SessionState
    {
        /// <summary>
        /// The user's display name or full name.
        /// This is typically set upon login or registration.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// A helper property to check if a user is considered "logged in".
        /// This is true if UserName is not null or empty.
        /// </summary>
        public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);
    }
}
