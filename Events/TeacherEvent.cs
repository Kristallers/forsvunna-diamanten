public class TeacherEvent : Event
{
    public override void Trigger(Player player)
    {
        player.LoseHp(15);
        Console.WriteLine("Läraren underkände dig! -15 HP");
    }
}