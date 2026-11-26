public class InputControl
{
    public bool CheckQuizInput()
    {
        int playerAnswer;

        do
        {
            Console.WriteLine("Besvara frågan med '1' för sant eller '2' för falskt.");
            int.TryParse((Console.ReadLine()), out playerAnswer);

            if (playerAnswer < 1 || playerAnswer > 2)
            {
                Console.WriteLine("Felaktig inmatning. Försök igen!");
            }
        }
        while (playerAnswer != 1 && playerAnswer != 2);

        if (playerAnswer == 1)
            return true;

        else
            return false;

    }

    public int CheckChoiceInput()
    {
        int playerChoice;
        do
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("Alternativ 1: Ta ett quiz och få chansen att vinna hp!");
            Console.WriteLine("Alternativ 2: Gå på nation och få chansen att hitta någons borttappade nationskort!");
            Console.WriteLine("Välj nu alternativ '1' eller '2': ");
            int.TryParse(Console.ReadLine(), out playerChoice);

            if (playerChoice < 1 || playerChoice > 2)
            {
                Console.WriteLine("Felaktig inmatning. Välj '1' eller '2'!");
            }
        }
        while (playerChoice != 1 && playerChoice != 2);

        return playerChoice;
    }

}