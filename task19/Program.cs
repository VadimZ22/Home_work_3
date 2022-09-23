Console.Clear();
Console.WriteLine("Введите любое пятизначное число");
int number = int.Parse((Console.ReadLine()));

if ((number / 10000 < 1) || (number / 100000 >= 1))
    Console.WriteLine("Число не является пятизначным");
else
    {
        int num1 = (number % 100000 - number % 10000)/10000;
        int num2 = (number % 10000 - number % 1000)/1000;
        int num3 = (number % 1000 - number % 100)/100;
        int num4 = (number % 100 - number % 10)/10;
        int num5 = (number % 10);
        if (num1 == num5 && num2 == num4)
            Console.WriteLine("Число является палиндромом");
        else Console.WriteLine("Число не является палиндромом");
    }
    