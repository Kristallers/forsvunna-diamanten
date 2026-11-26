namespace Försvunna.examen;

class Program
{
        static void Main(string[] args)
        {
                Game game = new Game();

                game.Play();

                List<Event> cardEvents = new List<Event>
        {
            new CardEvent("Blåsenhus"),
            new CardEvent("Engelska parken"),
            new CardEvent("BMC"),
        };

                Quiz quiz = new Quiz();

                Random random = new Random();

                List<Event> events = new List<Event>
         {
            new StudyEvent(),
            new TeacherEvent(),
            new ExamEvent(),
            new CardEvent("Blåsenhus"),
            new NothingEvent(),
            new CardEvent("Engelska parken"),
            new CardEvent("BMC"),
         };

                EventSelector selector = new EventSelector(events, random);
                Campus ekonomikum = new Campus("Ekonomikum", new OpenAccessRule(), selector);
                Campus blåsenhus = new Campus("Blåsenhus", new CardAccessRule("Blåsenhus"), selector);
                Player player = new Player(ekonomikum);

                List<Campus> ekoconnections = new List<Campus> { blåsenhus };
                ekonomikum.SetConnectedCampuses(ekoconnections);
                EventSelector cardSelector = new EventSelector(events, random);

                QuizChoice quizChoice = new QuizChoice(quiz, random, player);
                NationChoice nationChoice = new NationChoice(cardEvents, player);

                List<Campus> campusesForGame = new List<Campus> { ekonomikum, blåsenhus };
                IChoice choice1 = new QuizChoice(quiz, random, player);

                player.ChooseOption(quizChoice, nationChoice);



                // IChoice choice2 = new NationChoice();


                // selector.SelectEvent(player);
                // selector.SelectEvent(player);
                // selector.SelectEvent(player);
                // List<Campus> blåsenhusConnections = new List<Campus> { ekonomikum };
                // blåsenhus.SetConnectedCampuses(blåsenhusConnections);

                // List<Campus> campusesForGame = new List<Campus> { ekonomikum, blåsenhus };

                // Board spelplan = new Board(campusesForGame, player);
                // spelplan.ShowPlayerDestinations();

                // player.GetCard("Blåsenhus");


                // spelplan.MovePlayer(blåsenhus);

                // Console.WriteLine("Ny position::::::");
                // player.PrintPosition();

                // selector.SelectEvent(player);
                // selector.SelectEvent(player);
                // selector.SelectEvent(player);

                // player.HasWon();

                // player.AddHp(180);
                // player.GetExam();
                // spelplan.MovePlayer(ekonomikum);
                // player.HasWon();
        }
}
