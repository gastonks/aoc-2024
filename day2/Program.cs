int result = 0;
int total = 0;
int previousTotal = total;
bool flag = true;

while (Console.ReadLine() is { } line)
{
    var parts = line.Split(" ");
    for (int i = 1; i < parts.Length; i++)
    {
        total = Int32.Parse(parts[i-1]) - Int32.Parse(parts[i]);
        
        if (previousTotal * total < 0)
        {
            flag = false;
            break;
        }
        if (Int32.Abs(total) is < 1 or > 3)
        {
            flag = false;
            break;
        }
        previousTotal = total;
    }

    if (flag)
    {
        result++;
    }
    flag = true;
    previousTotal = 0;
}

Console.WriteLine($"RESULT:{result}");