namespace Jeevan;

public class Deck : IDeck
{
    private readonly int _number = new Random().Next(1, 100);
    
    public int GetCards(string game)
    {
        return _number;
    }
}