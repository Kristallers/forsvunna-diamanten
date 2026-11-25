public class NationChoice : IChoice
{
    private List<Event> cardEvents;
    private Player player;
    private Random random = new Random();

    public NationChoice(List<Event> events, Player player)
    {
        cardEvents = events;
        this.player = player;
    }

    public void ActionOfChoice()
    {
        if (random.Next(3) == 0)
        {
            new EventSelector(cardEvents, random).SelectEvent(player);

        }
        else
        {
            Console.WriteLine("Tyvärr hittade du inget campuskort på nationen. Studenterna håller hårt i sina campuskort ikväll...");
        }
    }
}