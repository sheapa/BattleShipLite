using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLite
{
    public class ConsoleMessage
    {
        public static string MessageAndResponseName(string message)
        {
            string output;
            Console.Write(message);
            output = Console.ReadLine().ToUpper();
            return output;
        }
        public static string MessageAndResponseLetter(string message)
        {
            string output;
            string isValid = null;

            Console.Write(message);
            output = Console.ReadLine().ToUpper();

            switch (output)
            {
                case "A":
                    isValid = output;
                    break;
                case "B":
                    isValid = output;
                    break;
                case "C":
                    isValid = output;
                    break;
                case "D": 
                    isValid = output;
                    break;
                case "E":
                    isValid = output;
                    break;
                default:
                    Console.WriteLine("Please enter a valid letter (A-E)");
                    MessageAndResponseLetter(message);
                    break;
            }


            return isValid;

        }

        public static int MessageAndResponseInt(string message)
        {
            int output;
            bool isNumber;
            int isValid = 0;

            Console.Write(message);
            isNumber = int.TryParse(Console.ReadLine(), out output);
            if (isNumber == false)
            {
                Console.WriteLine("Please enter a valid number. (1-5) ");
                MessageAndResponseInt(message);
            }
            else
            {
                switch (output)
                {
                    case 1:
                        isValid = output;
                        break;
                    case 2:
                        isValid = output;
                        break;
                    case 3:
                        isValid = output;
                        break;
                    case 4:
                        isValid = output;
                        break;
                    case 5:
                        isValid = output;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number. (1-5) ");
                        MessageAndResponseInt(message);
                        break;
                }
            }

            return isValid;

        }

        
    }
}
