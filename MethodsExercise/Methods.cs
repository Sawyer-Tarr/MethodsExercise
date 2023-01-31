using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Methods
    {
       // Exercise 1
        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your nickname?");
            string nickName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("Who is your favorite fictional character?");
            string favoriteFicChar = Console.ReadLine();

            Console.WriteLine("Where is a place that you would like to travel?");
            string favoriteLocation = Console.ReadLine();

            Console.WriteLine("Who is an actor that you love?");
            string favortieActor = Console.ReadLine();

            Console.WriteLine("What is your least favorite animal?");
            string leastFavAnimal = Console.ReadLine();

            Console.WriteLine($"There was once a brave knight named {name}, more widely known as the {nickName} throughout the land. They traveled the land on their " +
                $"trusty companion. A {favoriteColor} {favoriteAnimal} named {favoriteFicChar}. Their latest quest led them to the far away land of {favoriteLocation}" +
                $" where they had to defeat the evil neerdowell {favortieActor}. The battle was tough and dangerous and {favoriteFicChar} about met its end at {favortieActor}'s" +
                $" army of {leastFavAnimal}, but ultimately, the {nickName} rode away victorious.");
        }
        // Exercise 2
        public static int Add(int num1, int num2) 
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Multiply(int num1, int num2) 
        {
            int product = num1 * num2;
            return product;
        }

        public static int Subtract(int num1, int num2) 
        {
            int difference = num1 - num2;
            return difference;
        }
        public static int Divide(int num1, int num2) 
        {
            int quotient = num1 / num2;
            return quotient;
        
        }
        public static int Params(params int[] List) 
        {
            int total = 0;
            foreach(int x in List) 
            {
                total = x + total;
            }
            return total;
        }

    }
}
