
List<int> left = new List<int>();
List<int> right = new List<int>();

while (Console.ReadLine() is { } line)
{
    String[] split = line.Split("   ");
    left.Add(Int32.Parse(split[0]));
    right.Add(Int32.Parse(split[1]));
}

left.Sort();
right.Sort();

int i = 0;
int result = 0;

// Part 1
/*
while (i < left.Count && i < right.Count)
{
    result += Int32.Abs(left[i] - right[i]);
    i++;
}
*/

// Part 2
left.ForEach(x => result += x * right.FindAll(y => y == x).Count);

Console.WriteLine(result);