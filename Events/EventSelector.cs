public class EventSelector
{
    private readonly List<Event> events;
    private readonly Random random;

    public EventSelector(List<Event> events, Random random)
    {
        if (events.Count == 0)
        {
            throw new InvalidOperationException("EventSelector behöver minst ett event.");
        }

        this.events = events;
        this.random = random;
    }

    public Event SelectEvent(Player player)
    {
        int index = random.Next(events.Count);
        Event selectedEvent = events[index];

        selectedEvent.Announce();
        selectedEvent.Trigger(player);

        return selectedEvent;
    }
}