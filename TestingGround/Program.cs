using ToolKit;

namespace TestingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whitespaceString = @"I'm          White space";
            Console.WriteLine(StringKit.RemoveAllWhitespace(whitespaceString));
            Console.WriteLine(StringKit.NormalizeWhitespace(whitespaceString));
        }
    }
}
