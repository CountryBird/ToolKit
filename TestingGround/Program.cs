using ToolKit;

namespace TestingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1,2,3,4,5};
            bool hasEven = CheckKit.AnyMatch(numbers, n => n % 2 == 0);
            bool allPositive = CheckKit.AllMatch(numbers, n => n > 0);

            Console.WriteLine(hasEven);
            Console.WriteLine(allPositive);
        }
    }
}
