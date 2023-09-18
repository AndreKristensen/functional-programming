// The Output Of A Pure Function Is Determined Exclusively By Its Input Values, Without Observable Side Effects
namespace functional_programming
{
    public static class NotPureFunctions
    {
        public static bool IsOver18(DateTime birthDate) => birthDate <= DateTime.Today.AddYears(-18);


        public static int counter = 1;
        public static string Format(string s) => $"{counter++}) {s}";

        public static List<string> NotPureParallel(List<string> names) =>
        names.AsParallel()
                .Select(x => x.ToUpper())
                .Select(Format)
                .ToList();


    }
}