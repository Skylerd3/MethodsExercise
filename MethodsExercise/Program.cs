namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            StoryPrograme();

            int added = Add(3, 4);
            Console.WriteLine(added);

            int sub = subtract(10, 5);
            Console.WriteLine(sub);

            int div = divide(20, 2);
            Console.WriteLine(div);

            int mult = multiply(3, 3);
            Console.WriteLine(mult);

            int result = sum(10, 5, 10, 4, 2, 9);
            Console.WriteLine(result);
        }





        public static void StoryPrograme()
        {

            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello {username}! What is your favorite color?");
            string favcolor = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favband = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favanimal = Console.ReadLine();

            Console.WriteLine($"One day {username} was driving into town in there {favcolor} car, As {username} was driving they could her the band {favband} playing and to there surprise a {favanimal} dancing to it!");
 
        }

        public static int Add(int numA, int numB)
        {
            return numA + numB;
        }
        public static int subtract(int numA, int numB)
        {
            return numA - numB;
        }

        public static int divide( int numA, int numB)
        {
            return numA / numB;
        }

        public static int multiply(int numA, int numB)
        {
            return numA * numB;
        }

        public static int sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;

        }




        



    }
}







    
    
  


   
   
   
    

