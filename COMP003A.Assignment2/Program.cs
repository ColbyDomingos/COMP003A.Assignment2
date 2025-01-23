/* Author: Colby D
 * Faculty: Jonathan Rodrigo Cruz
 * Course: COMP 003A
 * Create a basic calculation for prices of discounts
 */ 

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************"); // hola of the code
            Console.WriteLine("Welcome to the Discount Calculator!");
            Console.WriteLine("*********************************");

            Console.WriteLine("What is your First Name?: ");
            string firstName = Console.ReadLine(); // asks for first name

            Console.WriteLine("What is your Last Name?: ");
            string lastName = Console.ReadLine(); // asks for last name

            Console.WriteLine("How old is you?: ");
            int age = int.Parse(Console.ReadLine()); // asks for age

            Console.WriteLine("What is the price of the item you're interested in?: "); // asks for a price to imput and calculate
            double itemPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you a student???????? (true/false): "); 
            bool isStudent = bool.Parse(Console.ReadLine()); // asks if you are a student

            //sets up all variables for the ending block of code
            int futureAge = age + 5;
            double studentPrice = itemPrice * 0.9;          
            double seniorPrice = itemPrice * 0.8;

            Console.WriteLine("*************************");
            Console.WriteLine("Hello, " + firstName + " " + lastName + ".");
            Console.WriteLine("You are currently " + age + " years old!");
            Console.WriteLine("In 5 years, you will be " + futureAge + ".");
            Console.WriteLine("The original price of the item is " + itemPrice + ".");
            Console.WriteLine("As a student, your discounted price is " + studentPrice + ".");
            Console.WriteLine("As a senior citizen, your discounted price would be " + seniorPrice + ".");
            Console.WriteLine("*************************");
            //says it all
        }
    }
}