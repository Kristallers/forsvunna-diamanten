using System.Formats.Asn1;
using System.IO;
public class Quiz
{
    private bool correctAnswer;
    public void ShowQuestion(Random random)
    {
        string[] questions = File.ReadAllLines("./Mechnics/Questions.txt");

        int index = random.Next(questions.Length);

        string[] parts = questions[index].Split("|");

        string quizQuestion = parts[0];
        this.correctAnswer = bool.Parse(parts[1]);

        Console.WriteLine("Du har kommit till en tenta!");
        Console.WriteLine($"Fråga: {quizQuestion}");
    }

    public bool CheckPlayerInput()
    {
        int playerAnswer;

        do
        {
            Console.WriteLine("Besvara frågan med '1' för sant eller '2' för falskt.");
            int.TryParse((Console.ReadLine()), out playerAnswer);

            if (playerAnswer != 1 && playerAnswer != 2)
            {
                Console.WriteLine("Felaktig inmatning. Försök igen!");
            }
        }
        while (playerAnswer != 1 && playerAnswer != 2);

        if (playerAnswer == 1)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public void EvaluateAnswer(Player player)
    {
        bool playerAnswer = CheckPlayerInput();

        if (correctAnswer == playerAnswer)
        {
            Console.WriteLine("Rätt! Du får +20 hp");
            player.AddHp(20);
        }
        else
        {
            Console.WriteLine("Fel! Plugga mer till nästa gång...");
        }

    }

}