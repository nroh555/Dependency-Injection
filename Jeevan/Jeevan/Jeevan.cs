namespace Jeevan;

public class Jeevan
{
    private IDeck _deck;

    public Jeevan(IDeck deck)
    {
        _deck = deck;
    }
    
    public string GetPrice(string game)
    {
        return _deck.GetCards(game);
    }
}