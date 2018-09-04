using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Matriz
    {
        int[] n;
        int[] m;
        public Matriz(int[] a, int[] b)
        {
            n = a;
            m = b;

        }
        public int nlength()
        {
            return n.Length;
        }
        public int mlength()
        {
            return m.Length;
        }
        public static Matriz operator +(Matriz a, Matriz b)
        {
            if (a.nlength() == b.nlength() && a.mlength() == b.mlength())
            {
                for (int i = 0; i < a.nlength(); i++)
                {
                    a.n[i] = a.n[i] + b.n[i];
                }
                for (int i = 0; i < a.mlength(); i++)
                {
                    a.m[i] = a.m[i] + b.m[i];
                }
            }
            return a;
        }
        public static Matriz operator -(Matriz a, Matriz b)
        {
            if (a.nlength() == b.nlength() && a.mlength() == b.mlength())
            {
                for (int i = 0; i < a.nlength(); i++)
                {
                    a.n[i] = a.n[i] - b.n[i];
                }
                for (int i = 0; i < a.mlength(); i++)
                {
                    a.m[i] = a.m[i] - b.m[i];
                }
            }
            return a;
        }
        public void print( Matriz r )
        {
            Console.WriteLine("n= ");
            for (int i = 0; i < r.nlength()  ; i++)
            {
                Console.Write(r.n[i]);
            }
            Console.WriteLine("\nm= ");
            for (int i = 0; i < r.mlength(); i++)
            {
                Console.Write(r.m[i]);
            }
        }
    }
}
