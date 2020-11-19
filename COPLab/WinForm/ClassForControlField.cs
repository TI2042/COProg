using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class ClassForControlField
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }

        public ClassForControlField(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
