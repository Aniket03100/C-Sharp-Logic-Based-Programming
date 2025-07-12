//LBP3
//To check whether the given year is leap year or not.

//input------> year from the user
//constraint-> no constraint............Year>0
//             Leap Year: It is exactly divisible by 4 except for century year, if it is a century year then it must be divisible by 400.

//output-----> leap year or not leap year (True or False)




public class Program
{
    public static void Main(string[] args)
    {
        int y = Convert.ToInt32(Console.ReadLine());

        if ((y%4 == 0 && y%100 != 0) || (y%400 == 0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}