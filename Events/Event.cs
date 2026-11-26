// FALL #3
// VAD: Arv och beroendeinjektion.
// HUR: Event är en abstrakt basklass med en gemensam implementation av Announce() och en virtuell metod Trigger(). Olika händelser ärver basklassen och skriver över Trigger(). Händelseobjekten injiceras i EventSelector.
// VARFÖR: Vi använder arv här eftersom vi både behöver hierarkisk återanvändning av kod i Announce() och subtypspolymorifsm. DVS att vi vill kunna anväda subtyper av Event på alla ställen där vi förväntar oss supertypen Event.
public abstract class Event
{
    public bool IsUsedUp { get; private set; } //eventuellt ändra?? baskrav.
    public void Announce()
    {
        Console.WriteLine("Nu sker ett event!");
    }

    public virtual void Trigger(Player player)
    {
        Console.WriteLine("Ett event triggas och händelse triggas");
    }

    protected void Use()
    {
        IsUsedUp = true;
    }
}