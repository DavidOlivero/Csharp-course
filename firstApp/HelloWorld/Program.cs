namespace firstApp
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
            Console.WriteLine("The college have " + students + "students ");

            // Operators
            Console.WriteLine(7 + 5); //Adition
            Console.WriteLine(45 - 78); // Substraction
            Console.WriteLine(5 * 8); // Multiplycation
            Console.WriteLine(5.0 / 2.0); // Divition
            Console.WriteLine(5.0 % 2.0); // Module

            // Strings interpolation
            Console.WriteLine($"Tines {yearsOld} años de edad");
        }
    }
}