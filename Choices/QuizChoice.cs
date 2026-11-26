class QuizChoice : IChoice
{
    private Quiz quiz;
    private Player player;
    private Random random;
    private AnswerEvaluator answerEvaluator;

    public QuizChoice(Quiz quiz, Random random, Player player, AnswerEvaluator answerEvaluator)
    {
        this.quiz = quiz;
        this.player = player;
        this.random = random;
        this.answerEvaluator = answerEvaluator;
    }
    public void ActionOfChoice()
    {
        quiz.ShowQuestion(random);
        answerEvaluator.EvaluateQuizAnswer();
    }

}