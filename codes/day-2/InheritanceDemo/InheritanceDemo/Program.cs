using System;

namespace InheritanceDemo
{
    class A
    {
        protected int m;
        public A() { }
        public A(int j)
        {
            this.m = j;
        }
        public int M
        {
            set => m = value;
            get => m;
        }
        public int GetM()
        {
            return m;
        }
    }
    class B : A
    {
        int n;

        public B()
        {

        }
        public B(int x, int y) : base(x)
        {
            this.n = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B(10, 20);
        }
    }
}
