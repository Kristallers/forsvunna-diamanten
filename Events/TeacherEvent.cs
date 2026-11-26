public class TeacherEvent : Event
{
    public override void Trigger(Player player)
    {
        Console.WriteLine("Läraren underkände dig! -15 HP");
        player.LoseHp(15);
    }
}