using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_Mapping_Percentages
{
    class Program
    {
        static void Main()
        {
            //Inputs
            Console.WriteLine("This is an experiment to see if my mapping idea will work.");
            Console.WriteLine("Enter Minimum Value:");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Maximum Value:");
            double max = Convert.ToDouble(Console.ReadLine());
            bool invert = Invert();

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(invert);
            Restart();

        }

        //Method for restarting the program.
        private static bool Invert()
        {
            Console.WriteLine();
            Console.WriteLine("Invert? (y/n)");

            try
            {
                char invertInput = Convert.ToChar(Console.ReadLine());

                switch (char.ToLower(invertInput))
                {
                    case 'y':
                        return true;
                    case 'n':
                        return false;
                    default:
                        Console.WriteLine("Invaild Invert Input");
                        return Invert();
                }
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Invaild Invert Input");
                return Invert();
            }
        }

        //Method for restarting the program.
        private static void Restart()
        {
            Console.WriteLine();
            Console.WriteLine("Restart? (y/n):");

            try
            {
                char restartInput = Convert.ToChar(Console.ReadLine());

                switch (char.ToLower(restartInput))
                {
                    case 'y':
                        Main();
                        break;
                    case 'n':
                        End();
                        break;
                    default:
                        Console.WriteLine("Invaild Input");
                        Restart();
                        break;
                }
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Invaild Input");
                Restart();
            }

        }

        //Method for ending the program.
        private static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
