// LBP2
// Given an integer n, perform the following conditional actions,
// if n is odd, print weird,
// if n is even and in the inclusive range of 2 to 5, print Not Weird.
// if n is even and in the inclusive range of 6 to 20, print Weird.
// if n is even and greater than 20, print Not Weird.

// input-----> a number from the user
// contraint-> 1<=n<=100
// output----> Weird or Not Weird



public class Program
{
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if (n%2 != 0)
        {
            Console.WriteLine("Weird");
        }
        else
        {
            if (n >= 2 && n <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if(n >= 6 && n <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
