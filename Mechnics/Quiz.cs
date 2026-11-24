using System.IO;
public class Quiz
{
    public void ReadQuestions(Random random)
    {
        string[] questions = File.ReadAllLines("Mechnics/Questions.txt");

        int index = random.Next(questions.Length);

        string[] parts = questions[index].Split("|");

        string quizQuestion = parts[0];
        bool answer = bool.Parse(parts[1]);

        Console.WriteLine($"Fråga: {quizQuestion}");
        Console.WriteLine($"Svar: {answer}");
    }
}