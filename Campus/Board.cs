using System.Net;

public class Board
{
    private Campus[] campuses;
    private Player player;

    public Board(Campus[] campuses, Player player)
    {
        this.campuses = campuses;
        this.player = player;
    }

    public void MoveToCampus(Campus nextCampus)
    {
        player.CanEnterCampus(nextCampus);
    }
}