namespace Day2;

public class First
{
    public static async Task<int> Execute()
    {
        var lines = await System.IO.File.ReadAllLinesAsync(@"input.txt");
        var (horizontal, depth) = (0, 0);

        Array.ForEach(lines, line =>
        {
            var position = line.Split(" ");
            var direction = position.First();
            var value = int.Parse(position.Last());

            switch (direction)
            {
                case "forward":
                    horizontal += value;
                    break;
                case "down":
                    depth += value;
                    break;
                case "up":
                    depth -= value;
                    break;
                default:
                    throw new ArgumentException($"Invalid direction {direction} received.");
            }
        });

        return horizontal * depth;
    }
}