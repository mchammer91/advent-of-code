namespace Day2;

public class Second
{
    public static async Task<int> Execute()
    {
        var lines = await System.IO.File.ReadAllLinesAsync(@"input.txt");
        var (horizontal, depth, aim) = (0, 0, 0);

        Array.ForEach(lines, line =>
        {
            var position = line.Split(" ");
            var direction = position.First();
            var value = int.Parse(position.Last());

            switch (direction)
            {
                case "forward":
                    horizontal += value;
                    depth += (aim * value);
                    break;
                case "down":
                    aim += value;
                    break;
                case "up":
                    aim -= value;
                    break;
                default:
                    throw new ArgumentException($"Invalid direction {direction} received.");
            }
        });

        return horizontal * depth;
    }
}