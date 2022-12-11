Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    int result = number1 / number2;
    Console.WriteLine("Число кратно, ответ " + result);
    //Console.WriteLine(number1 / number2;
}
else
{
    int result = number1 % number2;
    Console.WriteLine("Число некратно, остаток " + result);
    //Console.WriteLine($"Не кратно, остаток: {number1 % number 2}");
}