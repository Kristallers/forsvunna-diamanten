public abstract class Event
{
    public void Announce()
    {
        Console.WriteLine("Nu sker ett event!");
    }

    public virtual void Trigger(Player player)
    {
        Console.WriteLine("Ett event triggas och händelse triggas");
    }
}