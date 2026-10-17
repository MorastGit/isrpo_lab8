// // num 1
// PrintLine();
// Console.WriteLine("Отчет");
// PrintLine();

// PrintHeader("popa");
// PrintHeader("pepa");
// Console.WriteLine();

// // num 2.1
// Console.WriteLine(Max(5, 7));
// Console.WriteLine(Max(23, 2));
// // num 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(0));
// Console.WriteLine(IsEven(7));

// num 3
// int[] array = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(array));
// Console.WriteLine(CountGreater(array, 100));

// num 4
// double c3 = 32.212;
// Console.WriteLine(ToFahrenheit(c3));
// Console.WriteLine(ToFahrenheit(c3));
// Console.WriteLine(ToFahrenheit(c3));

// samostoya;telnie 
// num5
// Console.WriteLine(Factorial(14));
// for (int i = 2; i != 51; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.WriteLine(i);
//     }
// }

bool status = true;
while (status)
{
    razdelitel();
    menu();
    razdelitel();
    string x = Console.ReadLine();

    switch (x) 
    {
        case "1": {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            razdelitel();
            Console.WriteLine($"сумма чисел: {Sum(a, b)}");
        }
        break;
        case "2":
            {
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                razdelitel();
                Console.WriteLine($"максимальное: {Max(a, b)}");
            }
            break;
        case "3":
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                razdelitel();
                Console.WriteLine($"факториал: {Factorial(a)}");
            }
            break;
        case "0": Console.WriteLine("пока"); status = false; break;
        default: Console.WriteLine("Такой команды нет"); menu(); break;
    }

}




static void razdelitel()
{
    Console.WriteLine("------------------");
}
static void menu()
{
    Console.WriteLine("1 - сумма двух чисел \n2 - большее из двух чисел \n3 - факториал \n0 - выход");
}

static int Max(int a, int b)
{
    return a > b ? a : b;
}

static int Sum(int a, int b)
{
    return a + b;
}

static bool IsEven(int n)
{
    return n % 2 == 0 && n != 0;
}

static void PrintLine()
{
    Console.WriteLine("0-0");
}

static void PrintHeader(string title)
{
    Console.WriteLine("^_^   0_0   ^-^");
    Console.WriteLine(title);
    Console.WriteLine("^_^   0_0   ^-^");

}

static double Average(int[] arr)
{
    double sum = 0.0;
    foreach (int x in arr)
    {
        sum += x;
    }
    return sum / arr.Length;
}

static int CountGreater(int[] arr, int limit)
{
    int count = 0;
    foreach (int x in arr)
    {
        if (x > limit)
        {
            count += 1;
        }
    }
    return count;
}

static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}

static long Factorial(int n)
{
    long res = 1;
    for (int i = 1; i != n+1; i++)
    {
        res *= i;
    }
    return res;
}

static bool IsPrime(int n)
{
    bool res = true;
    for (int i = 2; i != n; i++)
    {
        if (n % i == 0)
        {
            res = false;
            break;
        }
    }
    return res;
}

static int ReadPositive(string message)
{
    int x;
    while (true)
    {
        Console.Write(message);
        do 
        {
            Console.WriteLine(message);
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        } while (x > 0);

    }
}





