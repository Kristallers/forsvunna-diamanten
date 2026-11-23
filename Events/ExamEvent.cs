public class ExamEvent : Event
{
    public override void Trigger(Player player)
    {
        player.GetExam();
        Console.WriteLine("DU HITTADE EXAMEN!");
    }
}