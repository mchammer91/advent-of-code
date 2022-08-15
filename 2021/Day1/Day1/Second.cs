namespace Day1;

public class Second
{
    public static async Task<int> Execute()
    {
        var lines = await System.IO.File.ReadAllLinesAsync(@"1-input.txt");
        return lines.ToInts().ToChunksOfThree().ToIncreaseComparison();
    }
}

public static class Extensions
{
    public static IEnumerable<int> ToInts(this string[] input) => input.Select(i => int.Parse(i));
    public static IEnumerable<int> ToChunksOfThree(this IEnumerable<int> ns) => Enumerable.Zip(ns, ns.Skip(1), ns.Skip(2)).Select(c => c.First + c.Second + c.Third);
    public static int ToIncreaseComparison(this IEnumerable<int> ns) => Enumerable.Zip(ns, ns.Skip(1), (a, b) => a < b ? 1 : 0).Count(c => c == 1);
}