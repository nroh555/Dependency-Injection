namespace Jeevan

{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            var jeevan = new Jeevan(deck);
            var word = jeevan.GetPrice("Pokemon");
            Console.WriteLine(word);
        }
    }
}