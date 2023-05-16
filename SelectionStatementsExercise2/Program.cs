namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); // Evaluate to a string

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "History":
                    Console.WriteLine("History is a very useful subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a very useful subject!");
                    break;
                case "PhysEd":
                    Console.WriteLine("PhysEd is a fun subject!");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is one of the harder subjects to learn!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I havn't taken {subject} before.");
                    break;


            }
        }
    }
}