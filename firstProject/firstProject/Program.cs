using System;
using System.Linq;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //==================Exercise 1=========================//
            /*            Console.WriteLine("Hello World!");
                        string myName = "Roisin";
                        int i = 35;
                        Console.WriteLine("Hello I am " + myName + " aged " + i);*/



            //==================Exercise 2=========================//
            /*            int life = 42;
                        long milli = 1_234_567_890L;
                        float dot = 2.0f;
                        double many = 3.00;
                        var yes = true;
                        var cookie = "chococlate chip";
                        var letter = 'a';

                        Console.WriteLine(life);
                        Console.WriteLine(milli);
                        Console.WriteLine(dot);
                        Console.WriteLine(many);
                        Console.WriteLine(yes);
                        Console.WriteLine(cookie);
                        Console.WriteLine(letter);*/


            //==================Exercise 3=========================//
            /*            int big = 1312;
                        int small = 2;
                        bool booy = true;

                        if (booy != true)
                        {
                            Console.WriteLine(big + small);
                        }
                        else
                        {
                            Console.WriteLine(big * small);
                        }*/


            //==================Exercise 4=========================//

/*
            Console.WriteLine("Hello World!");

            Console.WriteLine("Please enter your name:");
            string inputName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            string inputAge = Console.ReadLine();
            int numericalInput = Convert.ToInt32(inputAge);
            Console.WriteLine("Please enter your favorite animal:");
            string inputAnimal = Console.ReadLine();

            Console.WriteLine($"Hi {inputName}, you are {inputAge} years old and your favourite animal is {inputAnimal}");


*/

            //==================Exercise 5=========================//

            /*            int day = 3;

                        if (day == 1)
                        {
                            Console.WriteLine("Monday");
                        }
                        else if (day == 2)
                        {
                            Console.WriteLine("Tuesday");
                        }
                        else if (day == 3)
                        {
                            Console.WriteLine("Wednesday");
                        }
                        else if (day == 4)
                        {
                            Console.WriteLine("Thursday");
                        }
                        else if (day == 5)
                        {
                            Console.WriteLine("Friday");
                        }
                        else if (day == 6)
                        {
                            Console.WriteLine("Saturday");
                        }
                        else if (day == 7)
                        {
                            Console.WriteLine("Sunday");
                        }*/
            //==================Exercise 5 switch=========================//
            /*            int daySwitch = 7;

                        switch (daySwitch)
                        {
                            case 1:
                                Console.WriteLine("Monday");
                                break;
                            case 2:
                                Console.WriteLine("Tuesday");
                                break;
                            case 3:
                                Console.WriteLine("Wednesday");
                                break;
                            case 4:
                                Console.WriteLine("Thursday");
                                break;
                            case 5:
                                Console.WriteLine("Friday");
                                break;
                            case 6:
                                Console.WriteLine("Saturday");
                                break;
                            case 7:
                                Console.WriteLine("Sunday");
                                break;
                        }*/



            //==================Exercise 6=========================//
            /*           int some = 7;
                       var someVar = (some > 5) ? "This is the way" : "This is NOT the way";
                       Console.WriteLine(someVar);*/





            //==================Exercise 7=========================//
            /*            int num = 1;

                        while (num <= 10)
                        {
                            Console.WriteLine(num);
                            num++;
                        }
            */


            //==================Exercise 8=========================//
            /*            bool cond = true;
                        int inputTyped = 0;

                        do
                        {
                            Console.WriteLine("Hi! Please type:");
                            string typed = Console.ReadLine();
                            inputTyped++;

                            switch (typed)
                            {
                                case "t":
                                    Console.WriteLine(DateTime.Now.ToString());
                                    break;
                                case "q":
                                    cond = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }

                        } while (cond == true);*/

            //==================Exercise 9=========================//
            /*
                        for (int A = 100; A <= 200; A++)
                        {
                            Console.WriteLine(A);
                        }

            */

            //==================Exercise 10=========================//

            /*            for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.WriteLine(j);
                            }
                        }*/


            //==================Exercise 11=========================//
            /*
                        for (int i = 1; i <= 10; i++) 
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (j == i - 1)
                                {
                                    Console.Write(i);
                                } else
                                {
                                    Console.Write(i + ",");
                                }

                            }
                            Console.WriteLine();
                        }
            */
            //==================Exercise 12=========================//

            /*            String Hello = "Hello World";
                        foreach (char c in Hello)
                        {
                            if (c.ToString() == " ")
                            {
                                Console.WriteLine("#");
                            } else
                            {
                                Console.WriteLine(c);
                            }

                        }*/

            //can refactor with terniary:
            /*
                        String Hello = "Hello World";
                        foreach (char c in Hello)
                        {
                            char toPrint = char.IsWhiteSpace(c) ? '#' : c;
                            Console.WriteLine(toPrint);
                        }*/



            //==================Exercise 13=========================//

            /*            int[] myArray = { 1, 2, 3, 4, 5 };

                        for (int i =0; i < myArray.Length; i++)
                        {
                            Console.WriteLine(myArray[i] * 2);
                        }
            */
            //==================Exercise 14=========================//
            /*
                        string[,] twoDimArray = new string[3, 2]
                        {
                            {"hi", "you"},
                            {"yes", "no"},
                            {"if", "and"},
                        };


                        for (int i = 0; i < twoDimArray.GetLength(0); i++)
                        {
                            for (int j = 0; j < twoDimArray.GetLength(1); j++)
                            {
                                Console.WriteLine(twoDimArray[i, j]);
                            }
                        }*/

            //==================Exercise 15=========================//

            /*            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

                        for (int i = 0; i < myArray.Length; i++)
                        {
                            Console.WriteLine(myArray[i]);
                        }

                        //squared:
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            myArray = Math.Pow()
                            // myArray[i] = myArray[i] * myArray[i];
                            Console.WriteLine(myArray[i]);
                        }

                        //square root with comment:
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            Console.WriteLine($"The square root of { myArray[i]} is { Math.Sqrt(myArray[i]) }");
                        }


                        // min/max/sum 
                        Console.WriteLine(myArray.Min());
                        Console.WriteLine(myArray.Max());
                        Console.WriteLine(myArray.Sum());

            */

            //==================Exercise 16=========================//
            WriteGreeting();
            WriteGreeting("Hi");
            WriteGreeting("Hello", " Person");

            Console.WriteLine(Add(3, 10));


        }


        public static void WriteGreeting()
        {
            Console.WriteLine("I pity the fool");
        }

        public static void WriteGreeting(string greeting)
        {
            Console.WriteLine(greeting);
        }


        public static void WriteGreeting(string greeting, string name)
        {
            Console.WriteLine(greeting + name);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }







    }
}
