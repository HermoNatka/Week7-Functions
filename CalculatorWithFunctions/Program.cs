int a = 5;
int b = 6;

Add(a, b);
Add(10, 100);
Add(555666, 556666);

Multiply(a, b);
Multiply(10, 100);
Multiply(5555, 5566);

Substract(a, b);
Substract(10, 100);
Substract(666, 555);

Divide(a, b);
Divide(10, 100);
Divide(600, 100);
static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}
