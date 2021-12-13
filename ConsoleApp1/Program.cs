
using ConsoleApp1;

while (true)
{
    Console.WriteLine("Please Type '1' for 'FizzBuzz' or '2' for 'PostCode'");
    var selection = Console.ReadLine();

    if (selection != "1" && selection != "2")
    {
        Console.WriteLine("Invalid Option, Please Type '1' for 'FizzBuzz' or '2' for 'PostCode'");
    }
    else
    {
        if (selection == "1")
        {
            FizzBuzz.RunFizzBuzz();
        }
        else
        {
            PostCode.RunPostCode();
        }
    }
}
 


