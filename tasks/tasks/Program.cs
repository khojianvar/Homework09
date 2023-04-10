namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {a}");
                a = a + a;
            }
        }
    }
}