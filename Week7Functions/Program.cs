string hello = "Hello, world!";
string panic = "Dont panic!";

PrintStringFiveTimes(hello);
PrintStringFiveTimes(panic);
PrintStringFiveTimes("Batman");

static void PrintStringFiveTimes(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);
    }
}