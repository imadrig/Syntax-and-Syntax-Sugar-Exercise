namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? "is less than 9" : "is grater than or equal to 9";

            Console.WriteLine($"{answer} {response}");

            /*
            Corrections after reviewing answer

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);
            */


        }
    }
}
