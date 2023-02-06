// Raise number A to power B
double a = 0.0;
int b = 0;

Console.WriteLine("Enter number A: ");
a = double.Parse(Console.ReadLine());

while (b < 1)
{
    Console.WriteLine("Enter an integer number B: ");
    b = int.Parse(Console.ReadLine());
}

Console.WriteLine($"A^B = {a}^{b} = {myPow(a, b)}");

double myPow(double a, int b)
{
    double res = 1;
    for (int i = 0; i < b; i++) res *= a;
    return res;
}
