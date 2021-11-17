using System;

namespace InheritanceDemo
{
    class B
    {
        public void Foo()
        {
            Console.WriteLine("B foo");
        }
    }
    class A : B
    {
        public new void Foo()
        {
            Console.WriteLine("A foo");
        }
    }

    class C : B
    {
        public void Foo()
        {
            Console.WriteLine("C foo");
        }
    }
    interface IA
    {
        void Foo1();
        void Foo();
    }
    interface IB
    {
        void Foo2();
        void Foo();
    }
    class D : IA, IB
    {
        //explicit implementation
        void IA.Foo()
        {
            Console.WriteLine("IA foo");
        }
        //explicit implementation
        void IB.Foo()
        {
            Console.WriteLine("IB foo");
        }
        //implicit implementation
        public void Foo1()
        {
            Console.WriteLine("IA foo1");
        }
        //implicit implementation
        public void Foo2()
        {
            Console.WriteLine("IB foo2");
        }
        void Test() { }
    }
    class Program
    {
        static void Main()
        {
            A obj = new A();
            //immediate base class's method (if C has no Foo method)
            obj.Foo();
            /*
            D obj1 = new D();
            //obj1.Foo();
            //obj1.Test();

            //implcit invocation of interface members from D
            obj1.Foo1();
            obj1.Foo2();

            //implcit invocation of IA interface members from D
            IA ia = obj1 as IA;
            ia.Foo();//can be called only explicitly
            ia.Foo1(); //can be called implicitly/explicitly

            //implcit invocation of IB interface members from D
            IB ib = obj1 as IB;
            ib.Foo();
            ib.Foo2();
            */
        }
    }
}
