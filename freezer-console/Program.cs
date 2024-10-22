using freezer_console.Controllers;

namespace freezer_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length != 0) { Console.WriteLine(args[0]); }
            ActionController actionController = new ActionController(args);
            Console.WriteLine("Main Done.");
        }
    }
}
