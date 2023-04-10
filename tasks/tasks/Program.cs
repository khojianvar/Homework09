namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();
            string newnumber = "";
            string number1 = "";
            string str = ",";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                number1 += number[i];
            }
            for (int i = number1.Length-1; i >= 0; i--)
            {
                newnumber += number1[i];
                if (i % 3 == 0 && i != 0)
                {
                    newnumber += str;
                }
            }
            Console.WriteLine(newnumber);
        }
    }
}