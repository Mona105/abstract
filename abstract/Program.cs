using System;
namespace hello
{
    abstract class Rectangle
    {
        public int l;
        public int b;
        public abstract void area(int l, int b);
        public void parameter(int l, int b)
        {
            this.l = l;
            this.b = b;
            Console.WriteLine(2 * this.l * this.b);
        }
    }
    class Squre : Rectangle
    {
        public override void area(int l, int b)
        {
            this.l = l;
            this.b = b;
            Console.WriteLine(this.l * this.b);

        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Squre s = new Squre();
            s.parameter(10, 20);
            s.area(20, 30);
        }
    }
}