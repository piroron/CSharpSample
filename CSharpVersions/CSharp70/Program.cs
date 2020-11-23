using System;

namespace CSharp70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        // 下記の戻り値がTaskになるパターンを許容するのは、C#7.1から。
        //static async Task Main(string[] args)
        //{
        //    await Task.Run(() => Console.WriteLine("Run async method."));
        //    Console.WriteLine("Hello World!");
        //}
    }
}
