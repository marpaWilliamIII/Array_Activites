using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MARPA_ACT3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===============================================\n" +
                              "||           Highest VALUE FINDER            ||\n" +
                              "===============================================");





            start();


            void start()
            {
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("\n\n\nInput the quantity of numbers to be checked: ");

                try
                {
                    int num = int.Parse(Console.ReadLine());//-----------------------------accepts the number of elements in the array


                    int[] numbers = new int[num];//----------------------------------------initialize the array with its user inputed array size
                    for (int i = 0; i < num; i++)//----------------------------------------loops through the number of elements of the array
                    {
                        again();



                        void again()
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Order(i);//----------------------------------------------------calls the method for the sequence

                            try//----------------------------------------------------------evaluates the user input for the elements
                            {
                                numbers[i] = int.Parse(Console.ReadLine());//--------------will accept the intiger input from the user

                                for (int j = 0; j < i; j++)
                                {
                                    if (numbers[j] == numbers[i]) //----------------------checks if the inputted value is distinct
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Value already exist, please try again!!!");//-------if true this will let the user know that the inputted number is not distinct



                                        again();//---------------------------------------will call this method and asks for the correct input for the current element number
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("===============Invalid input!!!!!================\n" +
                                                  "||        Only numbers are allowed             ||\n" +
                                                  "||             Please try again.               ||\n" +
                                                  "================================================");
                                again();

                            }
                        }

                    }


                    Console.WriteLine("========================================================");
                    int max = numbers.Max();//--------------------------------------------gets the maximum value among the elements
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("THE HIGHEST VALUE IS: " + max);//-----------------will display the highest value
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Do You want to try again? enter y if yes/ enter n if no.");
                   string tryagain = Console.ReadLine();
                    if (tryagain == "y") 
                    {
                    start();

                    
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=======================THANK YOU====================");
                    }







                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("===============Invalid input!!!!!================\n" +
                                      "||        Only numbers are allowed             ||\n" +
                                      "||             Please try again.               ||\n" +
                                      "================================================");


                    start();
                }

            }




            void Order( int num)//----------------------------------------------will make the sequence and ask the users for the elements value
            {
                
              

                switch (num)
                {
                    case 0:
                        Console.Write("Enter 1st number: ");
                        break;
                    case 1:
                        Console.Write("Enter 2nd number: ");
                        break;
                    case 2:
                        Console.Write("Enter 3rd number: ");
                        break;

                    //for integers  4 to 20 which uses the th extension
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:

                        Console.Write($"Enter {num + 1}th number: ");
                        break;




                    case 20:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 21:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 22:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;

                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;


                    case 30:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 31:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 32:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;



                    case 33:
                    case 34:
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;





                    case 40:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 41:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 42:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;


                    case 43:
                    case 44:
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;



                    case 50:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 51:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 52:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;



                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;


                    case 60:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 61:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 62:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;




                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 69:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;


                    case  70:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 71:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 72:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;


                    case 73:
                    case 74:
                    case 75:
                    case 76:
                    case 77:
                    case 78:
                    case 79:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;




                    case 80:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 81:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 82:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;


                    case 83:
                    case 84:
                    case 85:
                    case 86:
                    case 87:
                    case 88:
                    case 89:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;


                    case 90:
                        Console.Write($"Enter {num + 1}st number: ");
                        break;
                    case 91:
                        Console.Write($"Enter {num + 1}nd number: ");
                        break;
                    case 92:
                        Console.Write($"Enter {num + 1}rd number: ");
                        break;
                    case 93:
                    case 94:
                    case 95:
                    case 96:
                    case 97:
                    case 98:
                    case 99:
                        Console.Write($"Enter {num + 1}th number: ");
                        break;














                }
            }







            Console.ReadKey();

        }

    }
}
