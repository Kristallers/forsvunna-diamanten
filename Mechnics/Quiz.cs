using System.Formats.Asn1;
using System.IO;
public class Quiz
{
    public void AnswerQuestion(Random random, Player player)
    {
        string[] questions = File.ReadAllLines("./Mechnics/Questions.txt");

        int index = random.Next(questions.Length);

        string[] parts = questions[index].Split("|");

        string quizQuestion = parts[0];
        bool answer = bool.Parse(parts[1]);

        Console.WriteLine($"Fråga: {quizQuestion}");
        bool playeranswer = CheckUserInput();

        if (answer == playeranswer)
        {
            Console.WriteLine("Rätt! Du får +20 hp");
            player.AddHp(20);
        }
        else
            Console.WriteLine("Fel! Plugga mer till nästa gång :)");
    }

    public bool CheckUserInput()
    {
        int answer;

        do
        {
            Console.WriteLine("Besvara frågan med '1' för true eller '2' för false.");
            int.TryParse((Console.ReadLine()), out answer);

            if (answer != 1 && answer != 2)
            {
                Console.WriteLine("Felaktig inmatning. Försök igen!");
            }
        }
        while (answer != 1 && answer != 2);

        if (answer == 1)
            return true;

        else
            return false;
    }

}