using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp70
{
    /// <summary>
    /// Throw Expression sample : <see cref="https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#throw-expressions"/>
    /// </summary>
    class ThrowExpression
    {
        // Compile error: このコンテキストではスロー式は許可されていません。
        // private Exception _v = throw new ArgumentNullException("null");

        private void Sample()
        {
            string test = "123";
            int num = int.TryParse(test, out int v) ? v : throw new ArgumentException("");
            Console.WriteLine(num);
        }
    }
}
