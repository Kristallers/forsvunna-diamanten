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
   public void PrintPlayerInfo()
   {
      Console.WriteLine($"Du har {hp} HP.");
      Console.WriteLine($"Du har {campusCard.Count} campuskort.");
      campusCard.ForEach(card => Console.WriteLine($"- {card}"));
      PrintPosition();
      if (hasExam)
      {
         Console.WriteLine("Du har examen!");
      }
      else
      {
         Console.WriteLine("Du har inte examen än.");
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
      if (hp >= 180 && hasExam == true && position == startCampus)
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
   public Campus ChooseDestination()
   {
      position.PrintConnectedCampuses();
      List<Campus> connectedCampuses = position.GetConnectedCampuses();

      while (true)
      {
         string? choice = Console.ReadLine();

         if (int.TryParse(choice, out int choiceNumber)
             && choiceNumber >= 1
             && choiceNumber <= connectedCampuses.Count)
         {
            return connectedCampuses[choiceNumber - 1];
         }

         Console.WriteLine("Ogiltigt val. Välj ett nummer från listan:");
         position.PrintConnectedCampuses();
      }
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