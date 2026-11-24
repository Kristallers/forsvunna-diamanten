public class Turn
{
    Player player;
    Board board;
    Quiz quiz;
    Random quizindex;
    public Turn(Player player, Board board)
    {
        if (player == null)
        {
            throw new ArgumentNullException(nameof(player));
        }


        this.quizindex = new Random();

        this.player = player;
        this.board = board;
        quiz = new Quiz();
    }
    public void Execute()
    {
        Console.Clear();
        Console.WriteLine($"NY TUR!");
        Console.WriteLine($"Dags att ta ett steg!");
        player.PrintPlayerInfo();
        Campus destination = player.ChooseDestination();
        board.MovePlayer(destination);
        quiz.AnswerQuestion(quizindex, player);
    }
}