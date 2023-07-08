
namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            int c = Convert.ToInt32(Console.ReadLine());
            int mul = a * b * c;
            Console.WriteLine("Multiplication of Three numbers" + mul);
        }
    }
}
    
