int result = 0;


bool CheckSafe(string[] input)
{
    bool flag = true;
    int total = 0;
    int previousTotal = total;
    
    for (int i = 1; i < input.Length; i++)
    {
        total = Int32.Parse(input[i-1]) - Int32.Parse(input[i]);
        
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
    
    return flag;
}

while (Console.ReadLine() is { } line)
{
    var parts = line.Split(" ");
    

    if (CheckSafe(parts))
    {
        result++;
    }
}

Console.WriteLine($"RESULT:{result}");