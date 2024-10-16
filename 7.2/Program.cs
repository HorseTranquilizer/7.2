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
                using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Average;
            Console.WriteLine("write down 4 numbers");
            int numba;
            int numba2;
            int numba3;
            int numba4;
            numba = Convert.ToInt32(Console.ReadLine());
            numba2 = Convert.ToInt32(Console.ReadLine());
            numba3 = Convert.ToInt32(Console.ReadLine());
            numba4 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 4; i = i + 1)
            {
                Console.WriteLine(numba + numba2 + numba3 + numba4 * 4);
               
                
            }
        }
    }
}
















                

            }

        }
    }
}
