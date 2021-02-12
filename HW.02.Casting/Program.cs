using System;

namespace HW._02.Casting
{
    class Program
    {
        static int Main(string[] args)
        {
            //a явное преобразование
            
            byte a = 9;
            byte b = (byte)(a + 143);

            ushort c = 4;
            sbyte d = (sbyte)c;

            double e = 72.5;
            float f = (float)e;

            //b неявное преобразование
            byte g = 7;             
            uint h = g;

            int i = 10;
            double j = 20.1;
            j = i;

            long k = 93;
            decimal l = k;

            //c операции упаковки
            int m = 1234;
            object n = m;

            char o = 'x';
            object p = o;

            double q = 2.1415359;
            object r = q;

            //d операции распаковки
            m = (int)n;
            o = (char)p;
            q = (double)r;
        }
    }
}
