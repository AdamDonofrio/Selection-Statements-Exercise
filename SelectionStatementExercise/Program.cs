namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = 0;

            do 
            {
                Console.WriteLine("What is the Number: ");

                userInput = int.Parse(Console.ReadLine());

                if(userInput < favNumber)
                {
                    Console.WriteLine("To Low");
                }
                if (userInput > favNumber)
                {
                    Console.WriteLine("To High");
                }

            } while (favNumber != userInput);

            Console.WriteLine($"Correct! The number is {favNumber}");

            //Switch Exercise

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is hard");
                    break;
                case "Science":
                    Console.WriteLine("Science is intresting");
                    break;
                case "History":
                    Console.WriteLine("History can be boring");
                    break;
                case "PE":
                    Console.WriteLine("PE can be sweaty");
                    break;
                case "Lunch":
                    Console.WriteLine("Lunch is were you get food");
                    break;
                default:
                    Console.WriteLine("That is not one of the subjects");
                    break;


            }
        }
    }
}
