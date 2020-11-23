using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71
{
    class TupleInitialize
    {
        public TupleInitialize()
        {
            int x = 10;
            Action y = () => Console.WriteLine("Run something.");
            var pair = (x, y);

            pair.y();
        }
    }
}
