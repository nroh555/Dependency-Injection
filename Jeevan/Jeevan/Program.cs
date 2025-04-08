namespace Jeevan

{
    class Program
    {
        static void Main(string[] args)
        {
            var jeevan = new Jeevan();
            var word = jeevan.GetPrice("Pokemon");
            Console.WriteLine(word);
        }
    }
}