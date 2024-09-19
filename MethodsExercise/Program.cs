namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            StoryPrograme();
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



    }
}







    
    
  


   
   
   
    

