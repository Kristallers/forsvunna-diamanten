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
      Console.WriteLine($"Du har nu {hp} hp.");
      return hp;
   }

   public int LoseHp(int amount)
   {
      hp -= amount;
      Console.WriteLine($"Du har nu {hp} hp.");
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

   public bool HasWon(int hp, bool hasExam, bool campusCard)
   {
      if (hp == 180 && hasExam == true && campusCard == true)
      {
         Console.WriteLine("Congratulations!! You have won the game and attained a degree :)");
         return true;
      }

      else
      {
         return false;
      }
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

}