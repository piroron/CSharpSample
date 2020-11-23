using System;
using System.Threading.Tasks;

namespace CSharp71
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(() => Console.WriteLine("Run async method."));
            Console.WriteLine("Hello World!");
        }
    }
}
