using System;


namespace Learningcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            PrintConsole("Hello World!");
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
    }
}