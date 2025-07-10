//LBP1

//Program to check whether the given number is even or odd number

//input-----> an integer number n
//contraint-> n>=0
//output----> even or odd or invalid




public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= 0)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}