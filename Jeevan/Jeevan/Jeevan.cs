namespace Jeevan;

public class Jeevan
{
    public string GetPrice(string game)
    {
        return new Deck().GetCards(game);
    }
}