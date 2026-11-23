public class Player
{
   private Campus campus;
   private int hp = 0;
   private bool campusCard = false;
   private bool hasExam = false; 

   public Player(Campus campus)
   {
      this.campus = campus;
   }

   public int AddHp(int amount)
   {
      hp += amount;
      return hp;
   }

   public int LoseHp(int amount)
   {
      hp -= amount;
      return hp;
   }

   public bool HasCard(bool campusCard) //fixa sen?? method overload??
   {
      if(true)
      {
         return true;
      }
   }

   public bool FindExam(bool hasExam)
   {
      if(true)
      {
         return true;
      }
   }

   public Campus MoveTo(Campus campus)
   {
      return campus; //??
   }

   public bool HasWon(int hp, bool hasExam, bool campusCard)
   {
      if(hp == 180 && hasExam == true && campusCard == true)
      {
         Console.WriteLine("Congratulations!! You have won the game and attained a degree :)");
         return true; 
      }

      else
      {
         return false;
      }
   }





}