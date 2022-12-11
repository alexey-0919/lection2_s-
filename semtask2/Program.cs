//Random random = new Random();
//int number = random.Next(100, 1000);
//Console.WriteLine($"Random number = {number}");

//int a = number / 100;
//int c = number % 10;

//Console.WriteLine("Ответ " +a +c);


Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine($"Random number = {number}");
int delete = 2;
var str = number.ToString();
number = int.Parse(str.Remove(str.Length - delete, 1));
Console.WriteLine(number);

//str.remove(1, 1) позиция / количество 369 (6 удаляется)