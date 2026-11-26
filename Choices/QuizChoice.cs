class QuizChoice : IChoice
{
    private Quiz quiz;
    private Player player;
    private Random random;

    public QuizChoice(Quiz quiz, Random random, Player player)
    {
        this.quiz = quiz;
        this.player = player;
        this.random = random;
    }
    public void ActionOfChoice()
    {
        quiz.ShowQuestion(random);
        quiz.EvaluateAnswer(player);
    }

}