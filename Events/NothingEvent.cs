public class NothingEvent : Event
{
    public override void Trigger(Player player)
    {
        Console.WriteLine("Inget hände den här gången.");
    }
}