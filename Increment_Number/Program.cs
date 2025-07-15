// LBP5

// Return the Next Number from the Integer Passed

// implement a program that takes a number as an argument, increments the number by +1 and returns the result

// input ----------> a number from the user
// constraints-----> no constraints
// output ---------> an incremented value





public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(++n);
    }
}