public class Turn
{
    Player player;
    Board board;
    public Turn(Player player, Board board)
    {
        if (player == null)
        {
            throw new ArgumentNullException(nameof(player));
        }

        this.player = player;
        this.board = board;
    }
    public Campus ChooseDestination()
    {
        player.ShowDestinations();
        List<Campus> connectedCampuses = player.GetPosition().GetConnectedCampuses();

        while (true)
        {
            string? choice = Console.ReadLine();

            if (int.TryParse(choice, out int choiceNumber)
                && choiceNumber >= 1
                && choiceNumber <= connectedCampuses.Count)
            {
                return connectedCampuses[choiceNumber - 1];
            }

            Console.WriteLine("Ogiltigt val. Välj ett nummer från listan:");
            player.ShowDestinations();
        }
    }
    public void Execute()
    {
        Console.WriteLine($"Dags att ta ett steg!");
        player.HasWon();
        player.PrintPosition();
        Campus destination = ChooseDestination();
        board.MovePlayer(destination);
    }
}