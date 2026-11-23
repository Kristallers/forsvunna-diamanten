namespace Försvunna.examen;

class Program
{
    static void Main(string[] args)
    {
        Campus ekonomikum = new Campus("Ekonomikum");
        Campus blåsenhus = new Campus("Blåsenhus");
        Player player = new Player(ekonomikum);

        List<Campus> ekoconnections = [blåsenhus];
        ekonomikum.SetConnectedCampuses(ekoconnections);

        List<Campus> campusesForGame = [ekonomikum, blåsenhus];

        Board spelplan = new Board(campusesForGame, player);
        spelplan.ShowPlayerDestinations();

        player.GetCard();


        spelplan.MovePlayer(blåsenhus);

        Console.WriteLine("Ny position::::::");
        player.PrintPosition();
    }
}
