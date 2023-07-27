namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int input = int.Parse(Console.ReadLine());
            IsPalindrom(input);
        }
        static void IsPalindrom(int n)
        {
            int newN = n, r, sum = 0; ;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (sum == newN)
            {
                Console.WriteLine("Entered number is Palindrom!");
            }
            else
            {
                Console.WriteLine("Entered number isn`t Palindrom!");
            }
        }
    }
}