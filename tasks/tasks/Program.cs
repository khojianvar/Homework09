namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int n = number;
            while (n > 0)
            {
                sum += n % 10;
                n= n / 10;
            }
            Console.WriteLine($"the sum of {number} number is {sum}");
        }
    }
}