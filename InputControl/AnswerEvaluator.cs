public class AnswerEvaluator
{
    private InputController inputController;
    private Quiz quiz;
    private Player player;
    public AnswerEvaluator(InputController inputController, Player player, Quiz quiz)
    {
        this.inputController = inputController;
        this.player = player;
        this.quiz = quiz;
    }
    public void EvaluateQuizAnswer()
    {
        bool playerAnswer = inputController.CheckQuizInput();

        if (quiz.CheckAnswer(playerAnswer))
        {
            Console.WriteLine("Rätt! Du får +20 hp");
            player.AddHp(20);
        }
        else
        {
            Console.WriteLine("Fel! Plugga mer till nästa gång...");
        }

    }
    public void EvaluateChoiceOption(IChoice nationChoice, IChoice quizChoice)
    {
        int playerChoice = inputController.CheckChoiceInput();

        if (playerChoice == 1)
            quizChoice.ActionOfChoice();

        else if (playerChoice == 2)
            nationChoice.ActionOfChoice();
    }

}
