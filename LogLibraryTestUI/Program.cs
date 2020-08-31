using LogLibrary;
using System;
using System.ComponentModel;

namespace LogLibraryTestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            Console.WriteLine("Hello World!");

            try
            {
                logger.Log("Hello World!");
                throw new Exception("ERROR TESTING ERROR");
            }
            catch(Exception ex)
            {
                logger.Log("ERROR", ex);
            }


            try
            {
                logger.Log("Hello World!");
                throw new WarningException("Warning Testing Warning");
            }
            catch (Exception ex)
            {
                logger.Log("Warning", ex);
            }

        }
    }
}
