Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

ExpTable3(number);

void ExpTable3(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int res = (int)Math.Pow(i, 3);
        Console.Write(res);
        if (i!= num)
            Console.Write(" ,");
    }
}