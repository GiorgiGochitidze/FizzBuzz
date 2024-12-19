string fizzBuzzVal = "";

for (var i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        fizzBuzzVal = "- FizzBuzz";
    }
    else if (i % 3 == 0)
    {
        fizzBuzzVal = "- Fizz";
    }
    else if (i % 5 == 0)
    {
        fizzBuzzVal = "- Buzz";
    }
    else
    {
        fizzBuzzVal = "";
    }

    Console.WriteLine($"{i} {fizzBuzzVal}");
}
