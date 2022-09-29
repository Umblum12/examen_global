using examen_global;

namespace examen_global
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 18;
            int c = 50;
            int r;
            int r2;
            int r3;
            int x;

            r = a + (b * c) / 5;
            Console.WriteLine(r);

            r2 = a + b * (c + b);
            Console.WriteLine(r2);

            r3 = c - b + a * (b/a);
            Console.WriteLine(r3);

            x = 6 * (a + b + c);
            Console.WriteLine(x);

            Console.ReadKey(true);
        }
    }
}