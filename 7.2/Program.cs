using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;
            randNum = generator.Next(35);
            int userguess;
            


            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine("Guess between 1-35");
                userguess = Convert.ToInt32(Console.ReadLine());
                if (userguess > randNum)
                {
                    Console.WriteLine("Too high");
                }
               else if (userguess < randNum)
                {
                    Console.WriteLine("too low");
                }
               else if (userguess == randNum)
                {
                    Console.WriteLine("correct!");
                }


            }

        }
    }
}
