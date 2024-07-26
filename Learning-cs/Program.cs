using Learning_cs;
using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;


namespace Learningcs
{
    // class = A bundle of related code.
    //         Can be used as a blueprint to create objects (OOP)
    class Program
    {
        static void Main(string[] args)
        {
            //Beep();
            //PrintConsole("Hello World!");
            //UserInput();
            //HypotenuseFinder();
            //IfStatements();
            //Switches();
            //LogicalOperators();
            //WhileLoop();
            //ForLoop();
            //NestedLoops();
            //NumberGuessingGame();
            //RockPaperScissorsGame();
            //SimpleCalculator();
            //Arrays();   
            //Console.WriteLine(ReturnARandomColor());
            //Console.WriteLine(Multiply(4, 5));
            //Console.WriteLine(Multiply(4, 5, 7));
            //Console.WriteLine(ParamsKeyword(1, 2, 5, 4, 2, 87, 4, 23, 43, 4, 5, 20));
            //ExceptionHandlers();
            //ConditionalOperator();
            //StringInterpolation();
            //MultidimensionalArrays();
            Messages.Hello();
            Messages.Error();
            Messages.Warning();
        }
        static void Beep()
        {
            Console.Beep();
        }
        static void PrintConsole(string s)
        {
            Console.WriteLine(s);
        }
        static void Variables()
        {
            String firstName = "Osama";
            String lastName = "Siran";
            String fullName = firstName + lastName;
            int age = 19;
            double height = 5.7;
            char symbol = 'M';
            bool isOk = true;
        }
        static void Constants()
        {
            const String nationalId = "123456789";
        }
        static void TypeCasting()
        {
            // to"data type": String, Int32, Boolean, Char, Double.


            String ageInString = "19";
            int stringToInt = Convert.ToInt32(ageInString);

            int idInInt = 123456789;
            String intToString = Convert.ToString(idInInt);
        }
        static void UserInput()
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("your name is " + name);
        }
        static void ArthmiticOperators()
        {
            int age = 19;


            //shortcut for this is:
            age = age + 2;
            age += 2;

            // + for sum,
            age += 2;
            // - for sub,
            age -= 2;
            // * for multiply,
            age *= 2;
            // for division,
            age /= 2;
            // & for modulus: the remaining of a division.\
            int remainder = age % 2;
        }
        static void MathClass()
        {
            int integer = 9;
            double decimalNum = 3.3;


            // Pow for number power to number,
            Math.Pow(integer, 2);
            // Sqrt for square root number,
            Math.Sqrt(integer);
            // Abs for absolute number,
            Math.Abs(integer);
            // Round for rounding a number, only works for double
            Math.Round(decimalNum);
            // Ceiling for always rounding a number up, only works for double
            Math.Ceiling(decimalNum);
            // Floor for always rounding a number down, only works for double
            Math.Floor(decimalNum);
            // Max for comparing two numbers and displying the maximum number,
            Math.Max(integer, decimalNum);
            // Min for comparing two numbers and displying the minimum number 
            Math.Min(integer, decimalNum);
        }
        static void RandomObject()
        {
            Random random = new Random();

            // Next for random integer, example from 1-6
            int num = random.Next(1, 7);
            // NextDouble for random double from 0 to 1 only. 
            double num2 = random.NextDouble();
        }
        static void HypotenuseFinder()
        {
            Console.WriteLine("Hello, this is a simple hypotenuse calculator.");
            Console.WriteLine("Enter side A:");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side B");
            double sideB = Convert.ToDouble (Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            Console.WriteLine("The hypotenuse is " + hypotenuse); 
        }
        static void StringMethods()
        {
            String myName = "Osama Siran";

            // ToUpper for capitalizaing all characters,
            String capitalName = myName.ToUpper();
            // ToLower for lowercasing all characters,
            String lowercaseName = myName.ToLower();
            // Replace for replacing a character with a character or nothing,
            String removeSpaceFromName = myName.Replace(" ", "");
            // Insert for inserting a string at a specific index
            String userName = myName.Insert(0, "@");
        }
        static void IfStatements()
        {
            bool isAdult = false;
            
            if(!isAdult)
            {
                Console.WriteLine("This page is 18+.");
                return;
            }
            Console.WriteLine("Welcome to our page!");
        }
        static void Switches()
        {
            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch(day)
            {
                case "Sunday":
                    Console.WriteLine("Hey today is a work day!");
                    break;
                case "Monday":
                    Console.WriteLine("Hey today is a work day!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Hey today is a work day!");
                    break;
                case "Wednesday":
                    Console.WriteLine("Hey today is a work day!");
                    break;
                case "Thursday":
                    Console.WriteLine("Hey today is a work day!");
                    break;
                case "Friday":
                    Console.WriteLine("Now it is the weekend 😎");
                    break;
                case "Saturday":
                    Console.WriteLine("Now it is the weekend 😎");
                    break;
                default:
                    Console.WriteLine("Error, enter correct input.");
                    break;
            }
        }
        static void LogicalOperators()
        {
            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE");
            }
        }
        static void WhileLoop()
        {
            int i = 0;
            while(i <= 1200)
            {
                Console.Write("I LOVE YOU ");
                i++;
            }
        }
        static void ForLoop()
        {
            for (int i = 10; i > 0; i-- )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPPY NEW YEAR!!!");
        }
        static void NestedLoops()
        {
            Console.WriteLine("How many columns?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many rows?");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol do you want?");
            char symbol = Convert.ToChar(Console.ReadLine());

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            
        }   
        static void NumberGuessingGame()
        {
            Console.WriteLine("Hello this is a Number guessing game.");
                        
            bool playAgain = true;        
            while (playAgain)
            {
                Random random = new Random();
                int theNum = random.Next(1, 101);
                int guesses = 0;

                Console.WriteLine("Pick a number between 1-100.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                while (theNum != userNum)
                {
                    if (userNum < theNum)
                    {
                        if (theNum - userNum < 10)
                        {
                            Console.WriteLine("No, higher");
                            userNum = Convert.ToInt32(Console.ReadLine());
                            guesses++;
                        }
                        else
                        {
                            Console.WriteLine("No, way higher");
                            userNum = Convert.ToInt32(Console.ReadLine());
                            guesses++;
                        }
                    }
                    if (userNum > theNum)
                    {
                        if (userNum - theNum < 10)
                        {
                            Console.WriteLine("No, lower");
                            userNum = Convert.ToInt32(Console.ReadLine());
                            guesses++;
                        }
                        else
                        {
                            Console.WriteLine("No, way lower");
                            userNum = Convert.ToInt32(Console.ReadLine());
                            guesses++;
                        }
                    }
                }
                Console.WriteLine("That's right!! You did it in {0} guesses", guesses);
                Console.WriteLine("do you want to play again? (y or n)");
                char userPlayAgain = Convert.ToChar(Console.ReadLine());
                if (userPlayAgain == 'n')
                {
                    playAgain = false;
                }
            }
        }
        static void RockPaperScissorsGame()
        {
            Console.WriteLine("Hello this is a Rock-Paper-Scissors game!");

            bool playAgain = true;
            Random random = new Random();
            while (playAgain)
            {
                Console.WriteLine("What will you do? (Rock, Paper, Scissors)");
                String[] array = { "rock", "paper", "scissors" };
                int arrayIndex = random.Next(0, array.Length - 1);
                String computerPick = array[arrayIndex];
                String userPick = Convert.ToString(Console.ReadLine());
                userPick = userPick.ToLower();

                if (userPick != "rock" && userPick != "paper" && userPick != "scissors")
                {
                    Console.WriteLine("incorrect input, Make sure you spell it right.");
                }

                if (userPick == computerPick)
                {
                    Console.WriteLine("Your pick: " + userPick);
                    Console.WriteLine("Computer pick: " + computerPick);
                    Console.WriteLine("DRAW");
                }
                // user winning logic
                else if (userPick == "rock" && computerPick == "scissors" || userPick == "scissors" && computerPick == "paper" || userPick == "paper" && computerPick == "rock")
                {
                    Console.WriteLine("Your pick: " + userPick);
                    Console.WriteLine("Computer pick: " + computerPick);
                    Console.WriteLine("YOU WIN!!");
                }
                // computer winning logic 
                else if (computerPick == "rock" && userPick == "scissors" || computerPick == "scissors" && userPick == "paper" || computerPick == "paper" && userPick == "rock")
                {
                    Console.WriteLine("Your pick: " + userPick);
                    Console.WriteLine("Computer pick: " + computerPick);
                    Console.WriteLine("COMPUTER WINS!!.");
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (Y/N)");
                String userPlayAgain = Console.ReadLine();
                userPlayAgain = userPlayAgain.ToUpper();
                if (userPlayAgain != "Y")
                {
                    playAgain = false;
                }
            }
        }
        static void SimpleCalculator()
        {
            Console.WriteLine("Hello this is a calculator program, it can do sum, sub, multiply, and divide.");
            Console.Write("First number:");
            double userFirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number:");
            double userSecondNum = Convert.ToDouble(Console.ReadLine());

            String userOp = "";
            while (userOp != "+" && userOp != "-" && userOp != "*" && userOp != "/")
            {
            Console.WriteLine("What operation would you like? (sum: +, sub: -, multiply: *, divide: /)");
            userOp = Console.ReadLine();
            }
            double result = 0;
            switch (userOp)
            {
                case "+":

                    result = userFirstNum + userSecondNum;
                    break;
                case "-":
                    result = userFirstNum - userSecondNum;
                    break;
                case "*":
                    result = userFirstNum * userSecondNum;
                    break;
                case "/":
                    result = userFirstNum / userSecondNum;
                    break;
            }
            Console.Write(userFirstNum + " " + userOp + " " + userSecondNum + " = " + result );
        }
        static void Arrays()
        {
            // There are two ways to create an array,

            // first way is to do everything in one line,
            String[] array1 = { "hello", "world", "!!" };

            // second way is to declare the arr ay and then assign values to it.
            String[] array2 = new string[3]; //3 is how many spots will the array have
            array2[0] = "hello";
            array2[1] = "world";
            array2[2] = "!!";



            
            // there are two ways to loop every item the array has,
            
            // first way is the classic way,
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            // second way is to do the built in method foreach loop.
            foreach (String array in array2)
            {
                Console.Write(array);
            }
        }
        static String ReturnARandomColor()
        {
            Random random = new Random();
            String[] colors = { "Red", "Pink", "Black", "White", "Blue", "Green", "Yellow" };
            int randomNum = random.Next(0, colors.Length);
            return colors[randomNum];
        }
        static double Multiply(double a, double b)
        {
            //this is an example of method overloading
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            //this is an example of method overloading
            return a * b * c;
        }
        static double ParamsKeyword(params double[] nums)
        {
            double result = 0;
            foreach (double num in nums)
            {
                result += num;
            }
            return result;
        }
        static void ExceptionHandlers()
        {
            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT!");
            } 
            catch (Exception e)// will handle all exceptions not mentioned above.
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
        }
        static void ConditionalOperator()
        {
            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);
        }
        static void StringInterpolation()
        {
            // there are two ways to string interpolate a string,
            String firstName = "Osama";
            String lastName = "Siran";
            int age = 19;

            // first way is the classic way,
            Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            Console.WriteLine("You are " + age + " years old.");

            // second way is to put a $ before the string and {} are placeholders for variables
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age, -10} years old.");
        }
        static void MultidimensionalArrays()
        {
            //I will organize the data like so: "name", "color1", "color2", "color3"...
            String[,] colorLovers = { 
                { "Osama", "Pink", "White", "Blue" },
                { "Osama Zahrani", "Blue", "Black", "White"},
                { "Muath", "Green", "Skyblue", "Violet" }
            };
            colorLovers[2, 3] = "White";
            //foreach will inteligently loop every item, not customizable though.
            foreach (String elements in colorLovers)
            { 
                //Console.WriteLine(elements);
            }
            //I will use nested for loops so I can have more control of the outcome.
            for (int i = 0; i < colorLovers.GetLength(0); i++) 
                //GetLength(num) num means the dimension,
                //so the first dimension is 0 (just like a regular .length),
                //the second dimension is 1...
            {  
                for (int j = 0; j < colorLovers.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        String name = colorLovers[i, 0];
                        Console.WriteLine($"{name} Loves:");
                    } else
                    {
                        String color = colorLovers[i, j];
                        Console.Write(color + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}