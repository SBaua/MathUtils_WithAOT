namespace MathUtils_WithAOT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public static class MathUtils
    {
        public const double PI = Math.PI;
        public const double e = Math.E;
        public const double g = 9.81;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static double CircleArea(int x)
        {
            return x * x * PI;
        }
        public static double Circumference(int x)
        {
            return (x + x) * PI;
        }
        public static double FallSpeedDistance(int n)
        {
            return n * g;
        }
        public static double FallDistance(int x)
        {
            return 0.5 * g * x * x;
        }
        public static double SquareArea(int x)
        {
            return x * x;
        }
        public static double Diameter(int u)
        {
            return u / PI;
        }
    }
}
