using System;


namespace Learningcs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beep();
            // PrintConsole("Hello World!");
            // UserInput();
            HypotenuseFinder();
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
    }
}