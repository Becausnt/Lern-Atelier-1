using System.ComponentModel;

namespace ConsoleGame
{
    internal class Program
    {
        static int numberofTurns = 0;
        static char playerTurn = 'X';
        static char field1 = '1';
        static char field2 = '2';
        static char field3 = '3';
        static char field4 = '4';
        static char field5 = '5';
        static char field6 = '6';
        static char field7 = '7';
        static char field8 = '8';
        static char field9 = '9';
        
        public static bool TestAndPlaceOnField(string fieldNumber)
        {
            switch (fieldNumber)
            {
                case "1":
                    if (field1 != '1')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field1 = playerTurn;
                        return true;
                    }
                case "2":
                    if (field2 != '2')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field2 = playerTurn;
                        return true;
                    }
                case "3":
                    if (field3 != '3')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field3 = playerTurn;
                        return true;
                    }
                case "4":
                    if (field4 != '4')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field4 = playerTurn;
                        return true;
                    }
                case "5":
                    if (field5 != '5')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field5 = playerTurn;
                        return true;
                    }
                case "6":
                    if (field6 != '6')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field6 = playerTurn;
                        return true;
                    }
                case "7":
                    if (field7 != '7')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field7 = playerTurn;
                        return true;
                    }
                case "8":
                    if (field8 != '8')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field8 = playerTurn;
                        return true;
                    }
                case "9":
                    if (field9 != '9')
                    {
                        Console.WriteLine("Invalid Input.");
                        return false;
                    }
                    else
                    {
                        field9 = playerTurn;
                        return true;
                    }

                default:
                    Console.WriteLine("Invalid Input");
                    return false;
                    

            }
            

        }
        public static bool TestIfWon()
        {
            if (field1 == 'X' &&  field2 == 'X' && field3 == 'X') //1 ---
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field4 == 'X' && field5 == 'X' && field6 == 'X')//2 ---
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field7 == 'X' && field8 == 'X' && field9 == 'X')//3 ---
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field1 == 'X' && field4 == 'X' && field7 == 'X')//4 |||
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field2 == 'X' && field5 == 'X' && field8 == 'X')//5 |||
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field3 == 'X' && field6 == 'X' && field9 == 'X')//6 |||
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field7 == 'X' && field5 == 'X' && field3 == 'X')//7 ///
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }
            else if (field1 == 'X' && field5 == 'X' && field9 == 'X')//8 \\\
            {
                Console.WriteLine("Player X has Won.");
                return true;
            }


            //Check Player O



            if (field1 == 'O' &&  field2 == 'O' && field3 == 'O') //1 ---
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field4 == 'O' && field5 == 'O' && field6 == 'O')//2 ---
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field7 == 'O' && field8 == 'O' && field9 == 'O')//3 ---
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field1 == 'O' && field4 == 'O' && field7 == 'O')//4 |||
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field2 == 'O' && field5 == 'O' && field8 == 'O')//5 |||
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field3 == 'O' && field6 == 'O' && field9 == 'O')//6 |||
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field7 == 'O' && field5 == 'O' && field3 == 'O')//7 ///
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }
            else if (field1 == 'O' && field5 == 'O' && field9 == 'O')//8 \\\
            {
                Console.WriteLine("Player O has Won.");
                return true;
            }

            if (numberofTurns >= 9) 
            {
                Console.WriteLine("It's a draw!");
                return true;
            }


            return false;
        }
        public static void PrintPlayingField()
        {
            Console.Clear();
            Console.WriteLine($"{field1}|{field2}|{field3}");
            Console.WriteLine($"-----");
            Console.WriteLine($"{field4}|{field5}|{field6}");
            Console.WriteLine($"-----");
            Console.WriteLine($"{field7}|{field8}|{field9}");

        }

        static void Main(string[] args)
        {
            Console.Title = "TicTacToe";
            
            string fieldNumber;
            Console.WriteLine("\nTicTacToe\n");
            PrintPlayingField();
            while (!TestIfWon())
            {
                if (playerTurn == 'X')
                {

                    Console.WriteLine("Enter Field Number: ");
                    while (true)
                    {
                        if (TestAndPlaceOnField(Console.ReadLine()))
                        {
                            break;
                        }
                    }

                    PrintPlayingField();


                    numberofTurns++;
                    playerTurn = 'O';
                }
                else
                {
                    Console.WriteLine("Enter Field Number: ");
                    while (true)
                    {
                        if (TestAndPlaceOnField(Console.ReadLine()))
                        {
                            break;
                        }
                    }


                    PrintPlayingField();
                    numberofTurns++;
                    playerTurn = 'X';
                }
            }



        }
    }
}
