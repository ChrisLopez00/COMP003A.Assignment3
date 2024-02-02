/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for Assignment 3
*/
namespace COMP003A.Assignment3
    {
        class Program
        {
            static void Main(string[] args)
            {
         
                // If-Else Section (Numeric to Letter Grade)
                Console.Write("Enter a numeric grade (0-100):");
                double numericGrade = Convert.ToDouble(Console.ReadLine());

                if (numericGrade >= 0 && numericGrade <= 100)
                {
                    if (numericGrade >= 90)
                    {
                        Console.WriteLine("Letter Grade: A");
                    }
                    else if (numericGrade >= 80)
                    {
                        Console.WriteLine("Letter Grade: B");
                    }
                    else if (numericGrade >= 70)
                    {
                        Console.WriteLine("Letter Grade: C");
                    }
                    else if (numericGrade >= 60)
                    {
                        Console.WriteLine("Letter Grade: D");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: F");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("******************************************");
                // Switch Section (Integer to String Day)
                Console.Write("Enter a integer day of the week (1-7):");
                int numericDay = Convert.ToInt32(Console.ReadLine());

                switch (numericDay)
                {
                    case 1:
                        Console.WriteLine("String Day: Monday");
                        break;
                    case 2:
                        Console.WriteLine("String Day: Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("String Day: Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("String Day: Thursday");
                        break;
                    case 5:
                        Console.WriteLine("String Day: Friday");
                        break;
                    case 6:
                        Console.WriteLine("String Day: Saturday");
                        break;
                    case 7:
                        Console.WriteLine("String Day: Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day!");
                        break;
                }
                
            }
        }
    }