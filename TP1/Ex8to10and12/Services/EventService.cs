public class EventService
{
    public Action<Event>? OnEventCreated { get; set; }


    public void CreateEvent(string title, DateTime date, string location)
    {
        Event newEvent = new Event
        {
            Title = title,
            Date = date,
            Location = location
        };

        OnEventCreated?.Invoke(newEvent);
    }
}
