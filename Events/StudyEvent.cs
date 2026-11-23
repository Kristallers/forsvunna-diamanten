public class StudyEvent : Event
{
    public override void Trigger(Player player)
    {
        player.AddHp(15);
        Console.WriteLine("Du klarade tentan! +15 HP");
    }
}