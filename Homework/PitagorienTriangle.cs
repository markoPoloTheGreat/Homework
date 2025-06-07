using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class PitagorienTriangle
    {
        private int a;
        private int b;
        private int c;
        public PitagorienTriangle(int n,int m)
        {
            a = m * m - n * n;
            b = 2 * m * n;
            c = m * m+n * n;
        }
        public PitagorienTriangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int GetA()
        {
            return a;
        }
        public int GetB()
        {
            return b;
        }
        public int GetC()
        {
            return c;
        }
        public override string ToString()
        {
            return a+","+b+","+c;
        }
    }
}
