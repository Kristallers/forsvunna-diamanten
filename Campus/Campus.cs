// FALL #1
// Subtypspolymorfism och beroendeinjektion
// VAD: Subtypspolymorfism och beroendeinjektion.
// HUR: Campus tar emot ett objekt som implementerar ICampusAccessRule. Två olika implementationer avgör om spelaren får komma in.
// VARFÖR: Vi kan lägga till nya tillträdesregler utan att behöva ändra klassen Campus.

public class Campus
{
    private string name;
    private List<Campus>? connectedCampuses;
    private ICampusAccessRule accessRule;
    private EventSelector selector;

    public Campus(string name, ICampusAccessRule accessRule, EventSelector selector)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name must not be empty.", nameof(name));

        this.name = name;
        this.accessRule = accessRule;
        this.selector = selector;
    }

    public void SetConnectedCampuses(List<Campus> connectedCampuses) //Settar vilka campus som ska vara kopplade till ett visst campus
    {
        this.connectedCampuses = connectedCampuses;
    }

    public void PrintConnectedCampuses()
    {
        for (int i = 0; i < connectedCampuses?.Count; i++)
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
    public bool CanEnter(Player player)
    {
        return accessRule.CanEnter(player);
    }

    public void EnterCampus(Campus nextCampus, Player player)
    {
        if (nextCampus.CanEnter(player))
        {
            player.MoveTo(nextCampus); //Kolla om vi kan göra detta bättre
            selector.SelectEvent(player);
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