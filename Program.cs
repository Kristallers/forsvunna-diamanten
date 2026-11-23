namespace Försvunna.examen;

class Program
{
    static void Main(string[] args)
    {
        Campus ekonomikum = new Campus("Ekonomikum", new OpenAccessRule());
        Campus blåsenhus = new Campus("Blåsenhus", new CardAccessRule("Blåsenhus"));
        Player player = new Player(ekonomikum);

        List<Campus> ekoconnections = new List<Campus> { blåsenhus };
        ekonomikum.SetConnectedCampuses(ekoconnections);

        List<Campus> campusesForGame = new List<Campus> { ekonomikum, blåsenhus }   ;

        Board spelplan = new Board(campusesForGame, player);
        spelplan.ShowPlayerDestinations();

        player.GetCard("Blåsenhus");


        spelplan.MovePlayer(blåsenhus);

        Console.WriteLine("Ny position::::::");
        player.PrintPosition();

        Random random = new Random();

        List<Event> events = new List<Event>
        {
            new StudyEvent(),
            new TeacherEvent(),
            new ExamEvent(),
            new CardEvent("Blåsenhus"),
            new NothingEvent()
        };

        EventSelector selector = new EventSelector(events, random);

        selector.SelectEvent(player);
        selector.SelectEvent(player);
        selector.SelectEvent(player);
    }
}
