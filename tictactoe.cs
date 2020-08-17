using System;
using System.Threading;
namespace Tic
{
    class Program
    {             
        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int choice;     
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();
                Console.WriteLine("TIC_TAC_TOE_GAME\n");
                Console.WriteLine("Player1 is X and Player2 is O\n");                
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                tictac();
                string a;
                int ok;
                do
                {
                    a = Console.ReadLine();
                    ok = validate(a);
                } while (ok != 1);
                int validate(String s)
                {
                    try
                    {
                        choice = int.Parse(s);
                        if(choice <1 || choice >9)
                        {
                            throw new Exception("Exception provide 1-9");
                        }
                        return 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Enter a valid number");
                        return 0;
                    }
                    
                }       
                                
                if (array[choice] != 'X' && array[choice] != 'O')
                {

                    if (player % 2 == 0) 
                    {
                        array[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        array[choice] = 'X';
                        player++;
                    }
                }

                else
                {
                    Console.WriteLine("Enter a tictac number that is not filled yet");
                    Thread.Sleep(2000);
                }

                flag = Result(); 

            } while (flag != 1 && flag != -1); 
                Console.Clear();
                tictac(); 
            if (flag == 1)  
            {
                Console.WriteLine("Player {0} has won the game", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("The match has tied");
            }
            Console.ReadLine();

        }       
        private static void tictac()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);

            Console.WriteLine("     |     |      ");
        }      
        private static int Result()
        {          
            if (array[1] == array[2] && array[2] == array[3])
            {
                return 1;
            }            
            else if (array[4] == array[5] && array[5] == array[6])
            {
                return 1;
            }             
            else if (array[6] == array[7] && array[7] == array[8])
            {
                return 1;
            }      
                            
            else if (array[1] == array[4] && array[4] == array[7])
            {
                return 1;
            }            
            else if (array[2] == array[5] && array[5] == array[8])
            {
                return 1;
            }            
            else if (array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }

            
            else if (array[1] == array[5] && array[5] == array[9])
            {
                return 1;
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }
                       
            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')
            {
                return -1;
            }

            else
            {
                return 0;
            }

        }

    }

}