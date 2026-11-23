public class Campus
{
    private string name;
    private List<Campus>? connectedCampuses;

    public Campus(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name must not be empty.", nameof(name));

        this.name = name;
    }

    public void SetConnectedCampuses(List<Campus> connectedCampuses) //Settar vilka campus som ska vara kopplade till ett visst campus
    {
        this.connectedCampuses = connectedCampuses;
    }

    public void PrintConnectedCampuses()
    {
        for (int i = 0; i < connectedCampuses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {connectedCampuses[i].ShowName()}");
        }
    }

    public string ShowName()
    {
        return name;
    }

    public List<Campus> GetConnectedCampuses() //Returnerar campusen som är connected till ett visst campus
    {
        return connectedCampuses;
    }

    public Campus ChooseDestination(int choice)
    {
        if (choice < 1 || choice > connectedCampuses.Count)
        {
            Console.WriteLine($"Välj en siffra mellan 1 och {connectedCampuses.Count}");
            return null;
        }

        return connectedCampuses[choice - 1];
    }

    public void EnterCampus(Campus nextCampus, Player player)
    {

        if (player.HasCard())
        {
            player.MoveTo(nextCampus); //Kolla om vi kan göra detta bättre
        }
        else
        {
            Console.WriteLine("Du har inte nyckeln som krävs, välj ett annat campus");
        }

    }

    public bool IsConnectedTo(Campus nextCampus)
    {
        for (int i = 0; i < connectedCampuses?.Count; i++)
        {
            if (connectedCampuses[i] == nextCampus)
            {
                return true;
            }
        }

        return false;
    }

}