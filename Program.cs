namespace Försvunna.examen;

class Program
{
        static void Main(string[] args)
        {
                Game game = new Game();
                Quiz quiz = new Quiz();
                Random random = new Random();

                List<Event> cardEvents = new List<Event> //eventuellt dubbelkolla så checken för om du har kampuskort gäller för båda listor????
        {
            new CardEvent("Blåsenhus"),
            new CardEvent("Ångströms"),
            new CardEvent("BMC"),
        };

                List<Event> events = new List<Event>
         {
            new StudyEvent(),
            new TeacherEvent(),
            new ExamEvent(),
            new NothingEvent(),
            new CardEvent("Blåsenhus"),
            new CardEvent("Ångströms"),
            new CardEvent("BMC"),
            new NothingEvent(),
            new StudyEvent(),
         };

                EventSelector selector = new EventSelector(events, random);
                Campus ekonomikum = new Campus("Ekonomikum", new OpenAccessRule(), selector);
                Campus engelskaParken = new Campus("Engelska parken", new OpenAccessRule(), selector);
                Campus blåsenhus = new Campus("Blåsenhus", new CardAccessRule("Blåsenhus"), selector);
                Campus bmc = new Campus("BMC", new CardAccessRule("BMC"), selector);
                Campus ångströms = new Campus("Ångströms", new CardAccessRule("Ångströms"), selector);

                Player player = new Player(ekonomikum);

                List<Campus> ekoConnections = new List<Campus> { engelskaParken };
                ekonomikum.SetConnectedCampuses(ekoConnections);

                List<Campus> epConnections = new List<Campus> { ekonomikum, blåsenhus, bmc };
                engelskaParken.SetConnectedCampuses(epConnections);

                List<Campus> blåsenConnections = new List<Campus> { engelskaParken, bmc, ångströms };
                blåsenhus.SetConnectedCampuses(blåsenConnections);

                List<Campus> bmcConnections = new List<Campus> { engelskaParken, blåsenhus, ångströms };
                bmc.SetConnectedCampuses(bmcConnections);

                List<Campus> ånganConnections = new List<Campus> { blåsenhus, bmc };
                ångströms.SetConnectedCampuses(ånganConnections);

                InputController controller = new InputController();
                AnswerEvaluator answerEvaluator = new AnswerEvaluator(controller, player, quiz);

                IChoice nationChoice = new NationChoice(cardEvents, player);
                IChoice quizChoice = new QuizChoice(quiz, random, player, answerEvaluator);

                GameRules gameRules = new GameRules();
                game.Play(gameRules);


                // selector.SelectEvent(player);
                // selector.SelectEvent(player);
                // selector.SelectEvent(player);

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
