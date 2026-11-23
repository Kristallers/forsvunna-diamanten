public class Campus
{
    private string name;

    public Campus(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        throw new ArgumentException("Name must not be empty.", nameof(name));

        this.name = name;
    }

    public void ConnectCampus(Campus[] connectedCampuses)
    {
        //En regel för att komma in -->
    }

}   