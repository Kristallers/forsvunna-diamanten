public class StudyEvent : Event
{
    public override void Trigger(Player player)
    {
        Console.WriteLine("Du klarade tentan! +15 HP");
        player.AddHp(15);
    }
}