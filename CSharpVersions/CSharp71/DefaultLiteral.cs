using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71
{
    class DefaultLiteral
    {
        public DefaultLiteral()
        {
            // NG
            // var value = default;

            // OK
            int value = default;


        }
    }
}
