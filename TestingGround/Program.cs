using ToolKit;

namespace TestingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string snake = "hello world_example-test";

            Console.WriteLine(StringKit.ToPascalCase(snake));
            Console.WriteLine(StringKit.ToCamelCase(snake));

            string pascal = "HelloWorldExampleTest";

            Console.WriteLine(StringKit.ToSnakeCase(pascal));
            Console.WriteLine(StringKit.ToKebabCase(pascal));
        }
    }
}
