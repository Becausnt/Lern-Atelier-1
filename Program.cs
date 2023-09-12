using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;
using System.IO;
using System.Runtime.CompilerServices;

namespace PrimesSoE
{
    internal class Program
    {
        public static List<int> CalculatePrimes(int limit)
        {
            bool[] isPrime = new bool[limit + 1];
            isPrime[1] = false;
            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i * i <= limit; i++)
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }

            List<int> primeNumbers = new List<int>();

            for (int i = 1; i <= limit; i++)
            {
                if (isPrime[i])
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }   

        static void Main()
        {
            Console.WriteLine("______     _                  _   _                 _                              _ _   _       _____       _____ ");
            Console.WriteLine("| ___ \\   (_)                | \\ | |               | |                            (_) | | |     /  ___|     |  ___|");
            Console.WriteLine("| |_/ / __ _ _ __ ___   ___  |  \\| |_   _ _ __ ___ | |__   ___ _ __ ___  __      ___| |_| |__   \\ `--.  ___ | |__  ");
            Console.WriteLine("|  __/ '__| | '_ ` _ \\ / _ \\ | . ` | | | | '_ ` _ \\| '_ \\ / _ \\ '__/ __| \\ \\ /\\ / / | __| '_ \\   `--. \\/ _ \\|  __| ");
            Console.WriteLine("| |  | |  | | | | | | |  __/ | |\\  | |_| | | | | | | |_) |  __/ |  \\__ \\  \\ V  V /| | |_| | | | /\\__/ / (_) | |___ ");
            Console.WriteLine("\\_|  |_|  |_|_| |_| |_|\\___| \\_| \\_/\\__,_|_| |_| |_|_.__/ \\___|_|  |___/   \\_/\\_/ |_|\\__|_| |_| \\____/ \\___/\\____/  \n\n");

            string filePath = "";
            int number;
            bool writeToConsole;
            while (true) 
            {
                Console.WriteLine("Calculate prime numbers up to:");
                string numberString = Console.ReadLine();
                if (int.TryParse(numberString, out number) && number >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number larger than 2.");
                }
            }
            Console.WriteLine("It is recommended to not print the numbers to the console when calculating large amounts of numbers(circa from 1'000'000), as the writing to the Console takes a LOT longer then the calculation.\n(You will be asked if you want to write the numbers to a file after the calculation)\n\n");

            while (true)
            {
                Console.WriteLine("Would you like to print your numbers to the Console? [y/N]");
                
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    writeToConsole = true;
                    break;
                }
                else if (answer == "n")
                {
                    writeToConsole = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer. ('y' for yes or 'n' for no)");
                }

            }
            Stopwatch calculationTimer = new Stopwatch();
            Stopwatch consoleWritingTimer = new Stopwatch();

            List<int> primeNumbers = new List<int>();
            calculationTimer.Start();
            primeNumbers = CalculatePrimes(number);
            calculationTimer.Stop();
            if (writeToConsole)
            {
                Console.WriteLine($"The prime numbers up to {number} are:");
            }
            
            consoleWritingTimer.Start();
            if (writeToConsole)
            {
                foreach (int i in primeNumbers)
                {
                    Console.WriteLine(i);
                }
            }
            consoleWritingTimer.Stop();
            Console.WriteLine($"\n\nCalculation of {primeNumbers.Count()} prime Numbers(up to {number}) took {calculationTimer.Elapsed}.");
            TimeSpan tspanCalc = calculationTimer.Elapsed;
            TimeSpan tspanWrite = consoleWritingTimer.Elapsed;
            if (writeToConsole)
            {
                Console.WriteLine($"The Console.WriteLine() of {primeNumbers.Count()} prime Numbers took {consoleWritingTimer.Elapsed}.");
                Console.WriteLine($"The Writing took {tspanWrite.TotalSeconds / tspanCalc.TotalSeconds} times longer than the calculation\n\n");
            }
            
            bool writeToFile = false;
            while (true)
            {
                Console.WriteLine("Do you want to write the numbers to a file?[y/N]");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    writeToFile = true;
                    break;
                }
                else if (answer == "n")
                {
                    writeToFile = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            if (writeToFile)
            {
                Console.WriteLine("Please wait, generating...");
                string primeNumbersString = "";
                foreach (int i in primeNumbers)
                {
                    primeNumbersString = primeNumbersString + i + "\n";
                }


                while (true)
                {
                    Console.WriteLine("Enter file Path: ");
                    filePath = Console.ReadLine();
                    if (filePath != null && filePath != "" && filePath != " ")
                    {
                        break;
                    }
                }
                if (File.Exists(filePath))
                { 
                    System.IO.File.WriteAllText(filePath, primeNumbersString);
                }
                else
                {
                    Console.WriteLine("The file was not found, Creating...");
                    System.IO.File.WriteAllText(filePath, primeNumbersString);
                }
            }
            Console.WriteLine("Finished!");

        }
    }
}
