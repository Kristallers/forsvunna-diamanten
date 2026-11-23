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
        player.CanEnterCampus(nextCampus);
    }

    public void ShowPlayerDestinations()
    {
        Campus currentCampus = player.GetPosition();
        currentCampus.PrintConnectedCampuses();
    }
}