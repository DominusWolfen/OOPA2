using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please decide the first file for Comparison:");
            Console.WriteLine("1a");
            Console.WriteLine("1b");
            Console.WriteLine("2a");
            Console.WriteLine("2b");
            Console.WriteLine("3a");
            Console.WriteLine("3b");
            string fileone = Console.ReadLine();
            string textone = File.ReadAllText(@"GitRepositories_"+fileone+".txt");
            Console.WriteLine(textone);
            Console.WriteLine("" +
                "Press any key to Continue...");
            Console.ReadKey();


            Console.WriteLine("Please decide the second file for Comparison:");
            Console.WriteLine("1a");
            Console.WriteLine("1b");
            Console.WriteLine("2a");
            Console.WriteLine("2b");
            Console.WriteLine("3a");
            Console.WriteLine("3b");
            string filetwo = Console.ReadLine();
            string texttwo = File.ReadAllText(@"GitRepositories_" + filetwo + ".txt");
            Console.WriteLine(texttwo);
            Console.WriteLine("" +
                "Press any key to Continue...");
            Console.ReadKey();

            if(textone == texttwo)
            {
                Console.WriteLine("The two files are the same");
            }
            else
            {
                Console.WriteLine("The two files are different");
            }
            Console.WriteLine("Program Complete" +
                "Press any key to Continue...");
            Console.ReadKey();
        }
    }
}
