namespace Day1;

public class First
{
    public static async Task<int> Execute()
    {
        var lines = await System.IO.File.ReadAllLinesAsync(@"1-input.txt");
        var increasesCount = 0;

        lines.Aggregate((prev, curr) =>
        {
            if (int.Parse(curr) > int.Parse(prev))
                increasesCount++;

            return curr;
        });

        return increasesCount;
    }
}