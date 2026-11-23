using System.Net;

public class Board
{
    private List<Campus> campuses;
    private Player player;

    public Board(List<Campus> campuses, Player player)
    {
        this.campuses = campuses;
        this.player = player;
    }

    public void MoveToCampus(Campus nextCampus)
    {
        Campus currentPosition = player.GetPosition();
        currentPosition.EnterCampus(nextCampus, player);
    }

    public void MovePlayer(Campus nextCampus)
    {
        Campus currentPosition = player.GetPosition();
        if (currentPosition.IsConnectedTo(nextCampus))
        {
            MoveToCampus(nextCampus);
        }
        else
        {
            Console.WriteLine("Du kan inte flytta till ett campus som inte är connected till nuvarande campus");
        }
    }

    public void ShowPlayerDestinations()
    {
        Campus currentCampus = player.GetPosition();
        currentCampus.PrintConnectedCampuses();
    }

    public Campus ChooseDestination(Player player, int choice)
    {
        return player.ChooseDestination(choice);
    }
}