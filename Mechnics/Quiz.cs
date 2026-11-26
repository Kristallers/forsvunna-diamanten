using System.Formats.Asn1;
using System.IO;
public class Quiz
{
    private string question;
    private bool correctAnswer;
    public void ShowQuestion(Random random)
    {
        string[] questions = File.ReadAllLines("./Mechnics/Questions.txt");

        int index = random.Next(questions.Length);

        string[] parts = questions[index].Split("|");

        question = parts[0];
        correctAnswer = bool.Parse(parts[1]);

        Console.WriteLine("Du har kommit till en tenta!");
        Console.WriteLine($"Fråga: {question}");
    }

    public bool CheckAnswer(bool playerAnswer)
    {
        return playerAnswer == correctAnswer;
    }

}