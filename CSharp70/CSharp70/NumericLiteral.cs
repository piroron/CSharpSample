using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp70
{
    /// <summary>
    /// Numeric literal syntax improvement sample : <see cref="https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#numeric-literal-syntax-improvements">official link</see>
    /// </summary>
    class NumericLiteral
    {
        private readonly decimal _million = 1_000_000m;
        private readonly decimal _twoMillion = 20_000__00m;

        private readonly int _v = 0x001;
    }
}
