using System.Collections.Generic;                  // Provides List<T> and Dictionary<TKey, TValue>
using EventEase.Client.Models;                     // Imports the RegistrationModel class

namespace EventEase.Services
{
    /// <summary>
    /// A static service that keeps track of attendees registered for each event.
    /// Stores attendee data in memory using a dictionary, mapping event names to lists of emails.
    /// </summary>
    public static class AttendanceService
    {
        // Internal storage: maps event names to lists of registered email addresses
        private static Dictionary<string, List<string>> eventAttendance = new();

        /// <summary>
        /// Registers a new attendee's email for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event to register for.</param>
        /// <param name="model">The registration model containing user info (name and email).</param>
        public static void Register(string eventName, RegistrationModel model)
        {
            // If the event doesn't already exist in the dictionary, initialize it
            if (!eventAttendance.ContainsKey(eventName))
                eventAttendance[eventName] = new List<string>();

            // Add the user's email to the list of attendees for this event
            eventAttendance[eventName].Add(model.Email);
        }

        /// <summary>
        /// Gets the list of email addresses of attendees registered for a specific event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <returns>A list of email strings. Empty if no one is registered.</returns>
        public static List<string> GetAttendees(string eventName)
        {
            // Try to get the list; if not found, return an empty list
            return eventAttendance.TryGetValue(eventName, out var attendees)
                ? attendees
                : new List<string>();
        }
    }
}
