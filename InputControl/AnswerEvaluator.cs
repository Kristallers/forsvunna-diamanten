public class AnswerEvaluator
{
    private InputControl inputControl;
    public AnswerEvaluator(InputControl inputControl)
    {
        this.inputControl = inputControl;
    }
    public void EvaluateQuizAnswer(Player player, Quiz quiz)
    {
        bool playerAnswer = inputControl.CheckQuizInput();

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
        int playerChoice = inputControl.CheckChoiceInput();

        if (playerChoice == 1)
            quizChoice.ActionOfChoice();

        else if (playerChoice == 2)
            nationChoice.ActionOfChoice();
    }

}
