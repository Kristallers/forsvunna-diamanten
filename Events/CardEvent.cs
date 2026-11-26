public class CardEvent : Event
{
    private readonly string cardName;

    public CardEvent(string cardName)
    {
        this.cardName = cardName;
    }

    public override void Trigger(Player player)
    {
        if (player.HasCard(cardName))
        {
            Console.WriteLine($"Du hittade {cardName}, men du har redan det :(, bättre lycka nästa gång!)");
            return;
        }

        player.GetCard(cardName);
        Console.WriteLine($"Du hittade ett campuskort! Du har nu tillgång till {cardName}.");
        Use();
    }
}