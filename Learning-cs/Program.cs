using Learning_cs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace Learningcs
{


    // class = A bundle of related code.
    //         Can be used as a blueprint to create objects (OOP)


    // object = An instance of a class
    //          A class can be used as a blueprint to create objects (OOP)
    //          objects can have fields & methods (characteristics & actions)\


    // constructor = A special method in a class
    //               Same name as the class name
    //               Can be used to assign arguments to fields when creating an object


    // static = modifier to declare a static member, which belongs to the class itself
    //          rather than to any specific object  \
    //                                    NOTE: if you put static to a class you will not be able to
    //                                    create objects from it


    // interface = defines a "contract" that all the classes inheriting from should follow
    //             An interface declares "what a class should have"
    //             An inheriting class defines "how it should do it"
    //             Benefit = security + multiple inheritance + "plug-and-play"


    //getters & setters = add security to fields by encapsulation
    //                    They're accessors found within properties

    // properties = combine aspects of both fields and methods (share name with a field)
    // get accessor = used to return the property value
    // set accessor = used to assign a new value
    // value keyword = defines the value being assigned by the set (parameter)

    // enums = special "class" that contains a set of named integer constants.
    //         Use enums when you have values that you know will not change,
    //         To get the integer value from an item, you must explicitly convert to an int

    // generic =  "not specific to a particular data type"
    //            add <T> to: classes, methods, fields, etc.
    //            allows for code reusability for different data types

    // thread = an execution path of a program
    //          We can use multiple threads to perform,
    //          different tasks of our program at the same time.
    //          Current thread running is "main" thread
    //          using System.Threading;

    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8
    }
    enum PlanetRadius 
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622
    }


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
            //Messages.Hello();
            //Messages.Error();
            //Messages.Warning();
            //Console.WriteLine(Cat.numberOfCats);
            /*
            Cat cat1 = new Cat("Lily", 7, "black");
            Cat cat2 = new Cat("Mirai", 5, "orange");
            Cat cat3 = new Cat("Milky", "white dotted black");
            Cat cat4 = new Cat("Losty");
            */
            //Console.WriteLine(Cat.numberOfCats);
            //cat1.Meow();
            //cat1.Sleep();

            //cat2.Meow();
            //cat2.Sleep();

            //cat3.GetAge();

            //NaughtyCat naughty1 = new NaughtyCat("nono", 3, "orange", "grew up without a family", 1);
            //naughty1.GetAge();

            /*
            Animal animal1 = new Animal();
            Human human1 = new Human();
            Plant plant1 = new Plant();
            */
            //animal1.Breathe();
            //human1.Breathe();
            //plant1.Breathe();

            //Console.WriteLine(cat1.ToString());
            //Console.WriteLine(cat2);

            /*
            Creature[] creatures = { animal1, human1, plant1 };

            foreach (Creature creature in creatures)
            {
                creature.Breathe();
            }
            */

            //Lists();
            /*
            TryingGetSet test1 = new TryingGetSet(20, "idk");
            test1.Age = 24;
            test1.Age = -21;
            test1.Age = 2421;
            Console.WriteLine(test1.Age);
            */

            /*
            String planetName = Planets.Mars.ToString();            // if you assign the value to a variable using an enum, you have to type ToString()
            
            Console.WriteLine("Planet: " + planetName + " and is the #" + (int)Planets.Mars);
            
            Console.WriteLine("Radius: " + (int)PlanetRadius.Mars);

            double volume = Volume(PlanetRadius.Earth);
            Console.WriteLine("Volume: " + volume);
            */

            /*
            String[] favColors = { "Pink", "White", "Blue" };
            int[] favNums = { 4, 7, 44 };
            bool[] bools = { true, true, false, true, false, false, false, true, true };

            DisplayElements(favColors);
            DisplayElements(favNums);
            DisplayElements(bools);
            */


            /*

            //I will practice multithreading here 
            
            static void CountDown()
            {
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Timer #1 : " + i + " seconds");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Timer #1 is complete!");
            }
            static void CountUp()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Timer #2 : " + i + " seconds");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Timer #2 is complete!");
            }
            static void CountUpWithParameter(String name) 
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Timer #2 : " + i + " seconds");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Timer #2 is complete!");
            }


            Thread mainThread = Thread.CurrentThread;

            Thread thread1 = new Thread(CountDown); 
            Thread thread2 = new Thread(CountUp); 
            Thread thread3 = new Thread(() => CountUpWithParameter("Hello")); //If the method has a parameter, must use the lambda expression
            thread1.Start();
            thread2.Start();
            */
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
        static void ArrayOfObjects ()
        {
            Cat cat1 = new Cat("Cutie");
            Cat cat2 = new Cat("Catie");
            Cat cat3 = new Cat("Caty");

            Cat[] arrayOfCats = { cat1, cat2, cat3 };




            // another way of declaring and assigning objects without naming them: (anonymous objects), and saving them in an array
            Cat[] arrayOfAnonymousCats = { new Cat("Cutie"), new Cat("Catie"), new Cat("Caty") };
        }
        static void Lists()
        {
            //List is an advanced version of array with many useful methods but it consumes more memory than array .


            //Method of list

            //Declare a list


            //List<String> strList = new List<String>();
            // style 1

            //List<String> strList = new();
            // style 2 (quicker)

            //Add / Insert / Remove an element


            //Add an element


            //strList.Add("a");

            //Insert an element


            //strList.Insert(1, "b");
            // 1 = index

            //Remove an element


            //strList.Remove("a");

            //Size of a list


            //strList.Count()


            //Index of a specific element

            //First index


            //strList.IndexOf("a");

            //Last index


            //strList.LastIndexOf("a");

            //Check whether a list contains a specific element


            //strList.Contains("a");

            //Sort the list

            //Sort the list alphabetically


            //strList.Sort();

            //Sort the list anti-alphabetically


            //strList.Reverse();

            //Clear the list


            //strList.Clear();

            //Switch between array and list

            //Convert from array to list


            //List<String> strList = strArray.ToList();
            // style 1

            //List<String> strList = new();
            //strList.AddRange(strArray);
            // style 2

            //Convert from list to array

            //String[] strArray = strList.ToArray();

            List<Cat> listOfCats = new List<Cat>();

            Cat cat1 = new Cat("Lily", 7, "black");
            Cat cat2 = new Cat("Mirai", 5, "orange");
            Cat cat3 = new Cat("Milky", "white dotted black");
            Cat cat4 = new Cat("Losty");

            listOfCats.Add(cat1);
            listOfCats.AddRange(new Cat[] { cat2, cat3, cat4 });

            foreach (Cat cat in listOfCats) 
            {
                Console.WriteLine(cat);            
            }
        }
        static double Volume(PlanetRadius radius)
        {
            //This is a practice of enums.
            double result = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return result;
        }
        static void DisplayElements<T>(T[] array)
        {
            foreach (T thing in array)
            {
                Console.Write(thing + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
    }
    class Cat
    {
        String name;
        int age;
        String color;
        public static int numberOfCats;

        public Cat ()
        {
            numberOfCats++;
        }
        public Cat(string name, int age, string color)
        {
            numberOfCats++;
            this.name = name;
            this.age = age;
            this.color = color;
        }
        public Cat(string name, string color)
        {
            numberOfCats++;
            this.name = name;
            this.color = color;
        }public Cat(string name)
        {
            numberOfCats++;
            this.name = name;
            this.age = 0;
            this.color = "Unkown";
        }

        public override string ToString()
        {
            return $"name: {name}, age: {age}, color: {color}";
        }


        public void Meow()
        {
            Console.WriteLine(name + " is meowwing");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
        public void GetAge()
        {
            Console.WriteLine(name + " is " + age + " years old");
        }
        public void AssigningValues(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

    }
    class NaughtyCat : Cat
    {
        String status;
        int punishmentYears;

        public NaughtyCat (string name, int age, string color, String status, int punishmentYears)
        {
            this.AssigningValues(name, age, color);
            this.status = status;
            this.punishmentYears = punishmentYears;
        }
    }



    abstract class Creature //Used the keyword (abstract) to prevent intilizing objects form this class,                       
    //You will no longer be able to:
    //Creature creature1 = new Creature(); 

    {
        String type;
        public virtual void Breathe()
        {
            Console.WriteLine("this creature is breathing");
        }
    }

    class Animal : Creature
    {
        String scientificName;
        int age;


        public override void Breathe()
        {
            Console.WriteLine("this animal is breathing");
        }
    }

    class Human : Creature
    {
        String name;
        int age;

        public override void Breathe()
        {
            Console.WriteLine("this human is breathing");
        }
    }

    class Plant : Creature
    {
        String scientificName;

        public override void Breathe()
        {
            Console.WriteLine("this plant is breathing");
        }
    }


    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }


    class Deer : IPrey
    {
        public void Flee() 
        {
            Console.WriteLine("The deer is running away!");
        }
    }
    class Hawk : IPredator 
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food.");
        }
    }
    class Fish : IPrey, IPredator 
    { 
        public void Flee()
        {
            Console.WriteLine("The fish is swimming away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish.");
        }
    }


    class TryingGetSet 
    {
        private int age;

        public TryingGetSet (int age, String name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    return;
                } else
                {
                age = value;
                }
            }
        }




        // auto-Implemented property =  shortcut when no additional logic is required in the property
        //                                you do not have to define a field for a property,
        //                                you only have to write get; and/or set; inside the property    


        public String Name { get; set; }
    }

}