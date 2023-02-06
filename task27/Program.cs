// Function calculates the sum of digits of the number
Console.WriteLine("Enter an integer number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of digits of number {num} is {sumDigits(num)}");

int sumDigits(int num)
{
    int sum = 0;
    int curNum = Math.Abs(num);
    while (curNum > 0)
    {
        sum += curNum % 10;
        curNum = curNum / 10;
    }

    return sum;
}
