namespace EventEase.Client.Models
{
    // Represents an event with basic details such as name, date, and location
    public class EventModel
    {
        // Name of the event (e.g., "Blazor Workshop")
        public string Name { get; set; } = string.Empty;

        // Date and time when the event will occur
        public DateTime Date { get; set; }

        // Location where the event will take place (e.g., "Edmonton, AB")
        public string Location { get; set; } = string.Empty;
    }
}
