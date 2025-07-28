using ToolKit;

namespace TestingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringKit.GetSafeFileName("\\Hello<World!>."));
        }
    }
}
