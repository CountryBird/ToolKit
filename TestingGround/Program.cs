using ToolKit;

namespace TestingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hw = "Hello World!";
            Console.Write(StringKit.Truncate(hw, 5));
        }
    }
}
