// Program initialize and print an array with 8 random elements
int num = 8;
int[] arr = new int[num];

Console.Write("Set the range for random numbers.\nEnter a: ");
int a = int.Parse(Console.ReadLine());

int b = a - 1;
while (b < a)
{
    Console.Write("Enter b (>= a): ");
    b = int.Parse(Console.ReadLine());
}

arr = randomArray(a, b);
Console.WriteLine($"Array with random elements in range [{a},{b}]:");
printArray(arr);

int[] randomArray(int a, int b)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(a, b + 1);

    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
}