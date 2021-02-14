using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 27468;
            Int32 b = -56568;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine();
            
            byte c = 25;
            Byte d = 52;
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine();

            char e = 'y';
            Char f = 'z';
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine();

            bool g = true;
            Boolean h = false;
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine();

            sbyte i = 5;
            SByte j = -5;
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());
            Console.WriteLine();

            double k = 1.234;
            Double l = 5.678;
            Console.WriteLine(k.GetType());
            Console.WriteLine(l.GetType());
            Console.WriteLine();

            float m = 1.23f;
            Single n = 4.56f;
            Console.WriteLine(m.GetType());
            Console.WriteLine(n.GetType());
            Console.WriteLine();

            uint o = 0;
            UInt32 p = 20000000;
            Console.WriteLine(o.GetType());
            Console.WriteLine(p.GetType());
            Console.WriteLine();

            long q = 92234534554775807;
            Int64 r = -922334534554775808;
            Console.WriteLine(q.GetType());
            Console.WriteLine(r.GetType());
            Console.WriteLine();

            ulong s = 0;
            UInt64 t = 1234567890123456789;
            Console.WriteLine(s.GetType());
            Console.WriteLine(t.GetType());
            Console.WriteLine();

            short u = 32109;
            Int16 v = -32109;
            Console.WriteLine(u.GetType());
            Console.WriteLine(v.GetType());
            Console.WriteLine();

            string w = "Hello";
            String x = "Bye";
            Console.WriteLine(w.GetType());
            Console.WriteLine(x.GetType());
            Console.WriteLine();

            object y = new object();
            Object z = new object();
            Console.WriteLine(y.GetType());
            Console.WriteLine(z.GetType());
            Console.WriteLine();
        }
    }
}
