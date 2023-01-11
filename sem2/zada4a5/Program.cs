//zada4a5-Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обращаться к числу как к строке нельзя.

Console.WriteLine("Введите трехзначное число");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }