using System.Security.Cryptography.X509Certificates;

public class Player
{
   private Campus startCampus;
   private int hp = 0;
   private List<string> campusCard = new List<string>();
   private bool hasExam = false;
   private Campus position;

   public Player(Campus campus)
   {
      startCampus = campus;
      position = campus;
   }

   public int AddHp(int amount)
   {
      hp += amount;
      if (hp > 180)
      {
         Console.WriteLine("Du har tillräckligt HP för att vinna!");
         Console.WriteLine("Hitta examen och återvänd till startcampuset för att vinna spelet.");
      }
      Console.WriteLine($"Du har nu {hp} hp");
      return hp;
   }

   public int LoseHp(int amount)
   {
      hp -= amount;
      if (hp < 0)
      {
         hp = 0;
      }

      Console.WriteLine($"Du har nu {hp} hp");
      return hp;
   }

   public void GetCard(string card) //Anropas när en spelare får ett campuskort
   {
      campusCard.Add(card);
   }

   public bool HasCard(string requiredCard) //För att se om spelaren har rätt campuskort
   {
      return campusCard.Contains(requiredCard);
   }
   public void GetExam() //Anropas när en spelare hittat examen
   {
      hasExam = true;
   }

   public bool HasExam() //Anropas för att se att en spelare har en examen
   {
      if (hasExam)
      {
         return true;
      }
      else
      {
         return false;
      }
   }

   public void MoveTo(Campus campus)
   {
      position = campus;
      Console.WriteLine($"================================");
      Console.WriteLine($"Du anländer till {campus.ShowName()}!");
      Console.WriteLine($"================================");
   }

   public bool HasWon()
   {
      if (hp == 180 && hasExam == true && position == startCampus)
      {
         Console.WriteLine("================================");
         Console.WriteLine("Du hittade den försvunna examen!");
         Console.WriteLine($"Du samlade {hp} HP.");
         Console.WriteLine($"Du har återvänt till {startCampus.ShowName()}.");
         Console.WriteLine("DU HAR TAGIT DIN EXAMEN!");
         Console.WriteLine("================================");
         return true;
      }
      else if (hp < 180)
      {
         Console.WriteLine("Du har inte tillräckligt med HP för att vinna spelet.");
         Console.WriteLine("HP som behövs: 180, du har: " + hp);
         Console.WriteLine($"Du behöver samla {180 - hp} HP för att kunna ta examen.");
         return false;
      }
      else if (!hasExam)
      {
         Console.WriteLine("Du har inte hittat examen än.");
         return false;
      }
      else if (position != startCampus)
      {
         Console.WriteLine("Du måste återvända till startcampuset för att vinna spelet.");
         return false;
      }
      return false;
   }

   public void PrintPosition()
   {
      Console.WriteLine($"Du befinner dig på {position.ShowName()}");
   }

   public Campus GetPosition()
   {
      return position;
   }

   public void ShowDestinations()
   {
      position.PrintConnectedCampuses();
   }

   public Campus ChooseDestination(int choice)
   {
      return position.ChooseDestination(choice);
   }

   public bool IsConnectedTo(Campus nextCampus)
   {
      return position.IsConnectedTo(nextCampus);
   }
   public void ChooseOption(IChoice nationChoice, IChoice quizChoice)
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

      if (playerChoice == 1)
         quizChoice.ActionOfChoice();

      else if (playerChoice == 2)
         nationChoice.ActionOfChoice();
   }
}