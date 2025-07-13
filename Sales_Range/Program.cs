// LBP4

// The e-commerce company Bookshelf wishes to analyse its monthly sales data between minimum range 30 to max range 100.
// The company has categorized these book sales into four groups depending on the number of sales with the help of these groups
// the company will know which stock they should increase or decrease in their inventory for the next month. the groups are as follows


// sales range		groups
// 30-50 ------------------> D
// 51-60 ------------------> C
// 61-80 ------------------> B
// 81-100 -----------------> A

// write an alg to find the group for the given book sale count.

// input--------> an integer salesCount represent total sales of a book
// output-------> a character representing the group of given sale count
// constraint---> 30<=saleCount<=100 ...otherwise invalid


public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if (n>=30 && n <= 100)
        {
            if (n>=30 && n <= 50)
            {
                Console.WriteLine("D");
            }
            else if (n>=51 && n <= 60)
            {
                Console.WriteLine("C");
            }
            else if (n>=61 && n <= 80)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}