// FALL #1
// VAD: Subtypspolymorfism och beroendeinjektion.
// HUR: Campus tar emot ett objekt som implementerar ICampusAccessRule. Två olika implementationer avgör om spelaren får komma in.
// VARFÖR: Vi kan lägga till nya tillträdesregler utan att behöva ändra klassen Campus.

public interface ICampusAccessRule
{
    bool CanEnter(Player player);
}