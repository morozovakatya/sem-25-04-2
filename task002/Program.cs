//программа, в которую вводишь 2 числа и она проверяет, является ли оно квадратом второго числа

Console.Write("Введите первое число  ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число  ");
int numB = int.Parse(Console.ReadLine());
bool result = numB * numB == numA;
Console.WriteLine(result ? "Да" : "Нет");
Console.ReadKey(); 
