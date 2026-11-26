public class Turn
{
    Player player;
    Board board;
    Quiz quiz;
    Random quizindex;
    InputController inputController = new InputController();
    List<Event> eventList;

    public Turn(Player player, Board board, Random quizindex, List<Event> events)
    {
        if (player == null)
        {
            throw new ArgumentNullException(nameof(player));
        }

        this.quizindex = quizindex;

        this.player = player;
        this.board = board;
        this.eventList = events;

        quiz = new Quiz();
    }
    public void Execute()
    {
        Console.WriteLine($"NY TUR!");
        Console.WriteLine($"Dags att ta ett steg!");
        Console.Write("Tryck på enter för att fortsätta...");
        Console.ReadLine();
        Console.Clear();
        player.PrintPlayerInfo();
        Campus destination = player.ChooseDestination();
        board.MovePlayer(destination);

        int choice = inputController.CheckChoiceInput();
        if (choice == 1)
        {
            quiz.ShowQuestion(quizindex);
            AnswerEvaluator answerEvaluator = new AnswerEvaluator(inputController, player, quiz);
            answerEvaluator.EvaluateQuizAnswer();
        }
        else if (choice == 2)
        {
            IChoice nationChoice = new NationChoice(eventList, player);
            AnswerEvaluator answerEvaluator = new AnswerEvaluator(inputController, player, quiz);
            IChoice quizChoice = new QuizChoice(quiz, quizindex, player, answerEvaluator);
            answerEvaluator.EvaluateChoiceOption(nationChoice, quizChoice);
        }
    }
}