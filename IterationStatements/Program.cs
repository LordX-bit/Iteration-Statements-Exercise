using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {



        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000


        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            int x = 1000;

            // Exit when x becomes less than 1000
            while (x > -1000)
            {
                Console.WriteLine("Computer Counting :" + x);

                // Decrement the value of x for
                // next iteration
                x--;
            }
            for (int i = 3; i <= 999; i = i + 3)
            {
                Console.WriteLine(i);
            }
            int n;

            //2
            Console.WriteLine("Enter a number to check : ");

            //3
            n = int.Parse(Console.ReadLine());

            //4
            if (n % 2 == 0)
            {
                //5
                Console.WriteLine(n + " is an even number");
            }
            else
            {
                //6
                Console.WriteLine(n + " is an odd number");

            }

            //1
            Console.WriteLine("Enter a number? Negative or postive please : ");
            //2
            n = int.Parse(Console.ReadLine());
            //3
            if (n == 0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if (n > 0)
            {
                //4
                Console.WriteLine(n + " is a positive number.");
            }
            else
            {
                //5
                Console.WriteLine(n + " is a negative number.");
            }
            int Age;
            string Name;
            {
                Console.WriteLine("Enter your name: ");
                Name = Console.ReadLine();

                Console.WriteLine("Enter your Age: ");
                int v = Convert.ToInt32(Console.ReadLine());
                Age = v;


                Console.WriteLine("\nYou have entered:\nName: " + Name + "\nAge: " + Age + " : Thank you for checking in");

            }

            //1
            Console.WriteLine("Enter a number : ");
            //2
            n = int.Parse(Console.ReadLine());
            //3
            if (n == 0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if (n > 0)
            {
                //4
                Console.WriteLine(n + " is a odd number.");
            }
            else
            {

                Console.WriteLine(n + " is a even number.");

            }


            int vote_age;
            Console.Write("\n\n");
            Console.Write("Detrermine a specific age is eligible for casting the vote:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");


        }

    }
}