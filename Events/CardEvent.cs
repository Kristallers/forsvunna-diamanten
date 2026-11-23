public class CardEvent : Event
{
    private readonly string cardName;

    public CardEvent(string cardName)
    {
        this.cardName = cardName;
    }

    public override void Trigger(Player player)
    {
        player.GetCard(cardName);
        Console.WriteLine($"Du hittade ett campuskort! Du har nu tillgång till {cardName}.");
    }
}