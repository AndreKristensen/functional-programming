// The Output Of A Pure Function Is Determined Exclusively By Its Input Values, Without Observable Side Effects

namespace functional_programming
{
    public static class PureFunctions
    {
        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;
        public static int Subtract(int x, int y) => x - y;
        public static int Divide(int x, int y) => x / y;


        public static List<string> PureParallel(List<string> names) =>
         names.AsParallel()
                .Select(x => x.ToUpper())
                .Zip(ParallelEnumerable.Range(1, names.Count), (name, c) => $"{c}) {name}")
                .ToList();

        public static int Sum(int to)
        {
            int sum = 0;
            for (int i = 0; i < to; i++)
                sum += i;
            return sum;
        }
    }
}