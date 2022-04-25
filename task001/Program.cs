//программа, в которую вводишь число и она выдает его квадрат

Console.Write("Введите целое число  ");
int num = int.Parse(Console.ReadLine());
int numResult = num * num;
Console.Write("Квадрат числа равен  ");
Console.WriteLine(numResult);
Console.ReadKey();