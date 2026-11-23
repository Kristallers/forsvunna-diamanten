// FALL #2
// Arv och beroendeinjektion
// VAD: Arv och beroendeinjektion.
// HUR: Event är en abstrakt basklass med en gemensam implementation av Announce() och en virtuell metod Trigger(). Olika händelser ärver basklassen och skriver över Trigger(). Händelseobjekten injiceras i EventSelector.
// Arv och beroendeinjektion
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