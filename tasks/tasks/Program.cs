namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i < b; i++)
            {
                counter = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if(counter==2)
                {
                    Console.Write($" {i}");
                }
            }
        }
    }
}