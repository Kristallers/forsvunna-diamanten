public class Game
{
    private Player player;
    private Board board;
    public Game()
    {
        Random random = new Random();

        List<Event> events = new List<Event>
        {
            new StudyEvent(),
            new TeacherEvent(),
            new ExamEvent(),
            new CardEvent("Blåsenhus"),
            new CardEvent("Ekonomikum"),
            new NothingEvent()
        };
        EventSelector selector = new EventSelector(events, random);

        Campus ångström = new Campus("Ångström", new OpenAccessRule(), selector);
        player = new Player(ångström);
        Campus ekonomikum = new Campus("Ekonomikum", new OpenAccessRule(), selector);
        Campus blåsenhus = new Campus("Blåsenhus", new CardAccessRule("Blåsenhus"), selector);

        List<Campus> ekoconnections = new List<Campus> { blåsenhus, ångström };
        ekonomikum.SetConnectedCampuses(ekoconnections);
        List<Campus> blåsenhusConnections = new List<Campus> { ekonomikum };
        blåsenhus.SetConnectedCampuses(blåsenhusConnections);
        List<Campus> ångströmConnections = new List<Campus> { ekonomikum };
        ångström.SetConnectedCampuses(ångströmConnections);

        List<Campus> campusesForGame = new List<Campus> { ångström, ekonomikum, blåsenhus };

        board = new Board(campusesForGame, player);
    }

    public void Play()
    {
        while (!player.HasWon())
        {
            Turn turn = new Turn(player, board);
            turn.Execute();
        }
    }
}