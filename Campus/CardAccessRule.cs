public class CardAccessRule : ICampusAccessRule
{
    private string requiredCard;

    public CardAccessRule(string requiredCard)
    {
        this.requiredCard = requiredCard;
    }
    public bool CanEnter(Player player)
    {
        return player.HasCard(requiredCard);
    }
}