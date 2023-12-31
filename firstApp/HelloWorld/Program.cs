﻿namespace firstApp
{
    class Program 
    {
        static void Main(String[] args) {
            Console.WriteLine("Hello, World!"); // Show console message

            /* Variables
            * Primitive types
            -> Signed
            sbyte
            short
            int
            long
            float
            double
            -> Unsigned
            byte
            ushort
            uint
            ulong
            * No primitive type
            char
            String
            */
            int yearsOld; // Declaration
            // Console.WriteLine(yearsOld); -> Is not allowed use a variable if not has initialize
            yearsOld = 30; // Initialized
            Console.WriteLine("Alex have " + yearsOld + " years old");

            int students = 240; // Declaration and initialize in the same line
            Console.WriteLine("The school have " + students + "students ");

            // Operators
            Console.WriteLine(7 + 5); //Adition
            Console.WriteLine(45 - 78); // Substraction
            Console.WriteLine(5 * 8); // Multiplycation
            Console.WriteLine(5.0 / 2.0); // Divition
            Console.WriteLine(5.0 % 2.0); // Module

            // Strings interpolation
            Console.WriteLine($"You have {yearsOld} years old");

            // Initialize all variables in the same line
            int personYearsOld1;
            int personYearsOld2;
            int personYearsOld3;
            int personYearsOld4;

            personYearsOld1 = personYearsOld2 = personYearsOld3 = personYearsOld4 = 24;
            Console.WriteLine($"All peoples have {personYearsOld4} years old");

            /* 
            This in not initialize all variables in 1000 but defines them in int type and the last 
            variable yes is initialized in 1000
            */
            int students1, students2, students3, students4 = 1000;
            students1 = students2 = students3 = students4;
            Console.WriteLine($"The sum of the amount school students is {students1 + students2 + students3 + students4} students");

            // Implicit declaration
            var num = 24;
            Console.WriteLine(num);

            // num = 34.8; -> Once declarated is not allowed cange the data type

            // Explicit conversion or casting
            double temperature = 34.5;
            int currentlyTemperature = (int) temperature;
            Console.WriteLine(currentlyTemperature);

            // Implicit conversion
            int peoples = 1000000;
            long cityPeoples = peoples;
            Console.WriteLine(cityPeoples);

            // Convert Strings to number
            Console.WriteLine("|-> Into the numbers for add them up <-|");

            Console.WriteLine("Into the first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Into the secon number");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = firstNumber + secondNumber;
            Console.WriteLine($"The addition of {firstNumber} and {secondNumber} is {result}");

            // Constants -> They are values that don´t cahange
            const int VALUE = 345;
            Console.WriteLine("El valor de la constante es {0}", VALUE);

            // Calculate the circle Radio
            //const double PI = 3.1416;
            
            Console.WriteLine("Into the circle radio length");
            double radio = double.Parse(Console.ReadLine());
            double resultCircleArea = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("The circle area is {0}", resultCircleArea);
        }
    }
}