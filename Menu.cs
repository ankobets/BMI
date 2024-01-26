using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class Menu
    {
        public  void printMainMenu()
        {
            double yourHeight = 0;
            int yourWeight = 0;
            bool canExit = true;
            string answer = null;
            while (canExit)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("|BMI                             |");
                Console.WriteLine("|Menu:                           |\n" +
                                  "==================================");
                Console.WriteLine("|1 - Enter height and weight     |\n" +
                                  "|2 - Calculate                   |\n" +
                                  "|q - Exit                        |");
                Console.WriteLine("==================================\n");

                Console.Write("Your choice: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter height");
                            yourHeight = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter weight");
                            yourWeight = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case "2":
                        {
                            Bmi yourBmi = new Bmi(yourHeight, yourWeight);
                            Console.WriteLine($"BMI - {yourBmi.bmiResult()} ({(int)yourBmi.bmiVal}) ");
                        }
                        break;


                    case "q":

                        {
                            canExit = false;
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Wrong answer");
                        }
                        break;
                }
            }
        }
    }

}

