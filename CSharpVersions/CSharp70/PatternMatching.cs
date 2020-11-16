using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp70
{
    /// <summary>
    /// Pattern matching practice : <see cref="https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#pattern-matching">official link</see>
    /// </summary>
    public class PatternMatching
    {
        public void Run()
        {
            var result = DoSomething();
            switch (result)
            {
                case Success _:
                    Console.WriteLine("Success!");
                    break;
                case Failure f when f.Message.Contains("fail"):
                    Console.WriteLine($"Failed: {f.Message}");
                    break;
                case Failure f:
                    Console.WriteLine(f.Message);
                    break;
                default:
                    break;
            }
        }

        UseCaseResult DoSomething()
        {
            return new Failure("失敗！");
        }

        interface UseCaseResult { 
            bool IsSuccess { get; }
        }

        class Success : UseCaseResult
        {
            public bool IsSuccess => true;
        }

        class Failure: UseCaseResult
        {
            public Failure(string message) => Message = message;
            public bool IsSuccess => false;

            public string Message { get; }
        }
    }
}
