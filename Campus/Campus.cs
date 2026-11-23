public class Campus
{
    private string name;
    private Campus[] connectedCampuses;

    public Campus(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        throw new ArgumentException("Name must not be empty.", nameof(name));

        this.name = name;
    }

    public void SetConnectedCampuses(Campus[] connectedCampuses) //Settar vilka campus som ska vara kopplade till ett visst campus
    {
        this.connectedCampuses = connectedCampuses;
    }

    public Campus[] GetConnectedCampuses() //Returnerar campusen som är connected till ett visst campus
    {
        return connectedCampuses;
    }

}   