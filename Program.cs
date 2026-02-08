namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter number 1: ");
            string num1 = Console.ReadLine();
            int num1Int = int.Parse(num1);

            Console.Write("Enter number 2: ");
            string num2 = Console.ReadLine();
            int num2Int = int.Parse(num2);

            Console.WriteLine();
            Console.WriteLine("Name Formats");
            Console.WriteLine("Using Concatenation " + firstName + " " + lastName +".");
            Console.WriteLine($"Using Interpolation: {firstName} {lastName}");
            Console.WriteLine();

            Console.WriteLine("Results");
            Console.WriteLine("------------");

            Console.WriteLine($"Sum: {num1Int + num2Int}");
            Console.WriteLine($"Average: {(num1Int + num2Int) / 2}");
            Console.WriteLine($"Difference: {num1Int - num2Int}");
            Console.WriteLine($"Product: {num1Int * num2Int}");
            Console.WriteLine($"Quotient: {(float)num1Int / num2Int}");

            Console.WriteLine($"Comparisons");
            Console.WriteLine("-------------");
            Console.WriteLine($"{num1} > {num2}: {(num1Int > num2Int)}");
            Console.WriteLine($"{num1} == {num2}: {(num1Int == num2Int)}");
            Console.WriteLine($"{num1} != {num2}: {(num1Int != num2Int)}");
        }
    }
}
