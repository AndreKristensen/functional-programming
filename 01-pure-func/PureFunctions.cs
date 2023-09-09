// The Output Of A Pure Function Is Determined Exclusively By Its Input Values, Without Observable Side Effects

namespace functional_programming
{
    public static class PureFunctions
    {
        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;
        public static int Subtract(int x, int y) => x - y;
        public static int Divide(int x, int y) => x / y;
    }
}