void ArrayLoad(int[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        if (i == 0)
        {
            ints[i] = 0;
            continue;
        }

        if (i == 1)
        {
            ints[i] = 1;
            continue;
        }

        ints[i] = ints[i - 1] + ints[i - 2];
    }
}

void ArrayWrite(int[] ints)
{
    foreach (int number in ints)
    {
        Console.Write("{0,3}",number);
    }

    Console.WriteLine();
}
int ArrayTotal(int[] ints)
{
    int total = 0;
    foreach (int number in ints)
    {
        total += number;
    }
    return total;
}

float ArrayAverage(int x, int y)
{
    return (float)x / y;
}
int Dimension(int i)
{
    do
    {
        if (i == 0 || i == 1)
        {
            Console.Write("Girdiğiniz boyutun toplamı 0 ortalaması 0 'dır...\nFibonacci Serisinin Boyutunu Giriniz : ");
            i = Convert.ToInt32(Console.ReadLine());
        }
    } while (i <= 1);

    return i;
}

Console.Write("Fibonacci Serisinin Boyutunu Giriniz : ");
int dimension = Convert.ToInt32(Console.ReadLine());

Dimension(dimension);

int[] fibonaccies = new int[dimension];
float average;
int total;

ArrayLoad(fibonaccies);
total = ArrayTotal(fibonaccies);
average = ArrayAverage(total, dimension);

ArrayWrite(fibonaccies);
Console.WriteLine("{0} boyutlu fibonacci serilerinin :\nToplamı : {1}\nOrtalaması : {2,5}",dimension,total,average.ToString());