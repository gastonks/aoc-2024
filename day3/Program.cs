using System.Text.RegularExpressions;

var pattern = @"mul\(\d{1,},\d{1,}\)";
int result = 0;
int product = 1;
while (Console.ReadLine() is { } line)
{
    MatchCollection matches = Regex.Matches(line, pattern);
    
    matches.ToList().ForEach(match =>
    {
        MatchCollection matchesNumber = Regex.Matches(match.Value, @"\d{1,}");
        matchesNumber.ToList().ForEach(m =>
        {
            //Console.WriteLine(m);
            product *= int.Parse(m.Value);
        });
        result += product;
        product = 1;
    });
}

Console.WriteLine(result);