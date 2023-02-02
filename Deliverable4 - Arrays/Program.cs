/* 
 * Author: Tran Nguyen
 * Date: 2/2/2023
 * Description: This C# Console application code demonstrates Fibonacci sequence
 */
namespace Deliverable4___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25] ;

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}