using System.Text.RegularExpressions;

var patternMul = @"mul\(\d{1,},\d{1,}\)";
int result = 0;
int product = 1;
bool flag = true;
while (Console.ReadLine() is { } line)
{
    string[] splitLine = Regex.Split(line, @"(do\(\))|(don't\(\))");
    
    splitLine.ToList().ForEach(l =>
    {
        if (l == "don't()")
        {
            flag = false;
        }

        if (flag || l == "do()")
        {
            flag = true;
            if (l != "do()")
            {
                MatchCollection matchesMul = Regex.Matches(l, patternMul);
                
                matchesMul.ToList().ForEach(match =>
                {
                    Console.WriteLine(match);
                    MatchCollection matchesNumber = Regex.Matches(match.Value, @"\d{1,}");
                    matchesNumber.ToList().ForEach(m =>
                    {
                        product *= int.Parse(m.Value);
                    });
                    result += product;
                    product = 1;
                });
            }
        }
        //Console.WriteLine(l);
    });
}

Console.WriteLine(result);