using LogLibrary;
using System;


namespace LogLibraryTestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            Console.WriteLine("Hello World!");

            logger.Log("Hello World!");
        }
    }
}
