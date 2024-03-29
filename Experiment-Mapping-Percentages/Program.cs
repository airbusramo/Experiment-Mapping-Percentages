﻿using System;
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
            double min = 0, max = 0, axisPosition = 0;
            bool invert = false;

            try
            {
                Console.WriteLine("This is an experiment to see if my mapping idea will work.");
                Console.WriteLine("Enter Minimum Value:");
                min = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Maximum Value:");
                max = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Position Value:");
                axisPosition = Convert.ToDouble(Console.ReadLine());
                invert = Invert();
            }
            
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Input");
                Restart();
            }

            //Adjusting input range to be positive.
            if (min < 0)
            {
                min = Math.Abs(min);
                max += min;
                axisPosition += min;
                min = 0;
            }
            
            //Inverting the min value to create an inverted percentage.
            if (invert == true)
            {
                axisPosition = max - axisPosition;
            }

            //Math
            double result = (axisPosition / max) * 100;

            Console.WriteLine();
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(invert);
            Console.WriteLine(result + "%");
            Restart();

        }

        //Method that receives the input for inverting the percentage calculation.
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
