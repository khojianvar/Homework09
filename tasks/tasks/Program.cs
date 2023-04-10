namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}