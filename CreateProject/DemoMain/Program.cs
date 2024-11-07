namespace DemoMain;
using DemoLibrary;

class Program
{
    static void Main(string[] args)
    {
      Demo lib = new Demo();
      lib.say();
      Console.WriteLine("  Hello from Main!");
      Console.WriteLine("\n  That's all Folks!");
    }
}
