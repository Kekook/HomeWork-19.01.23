Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    Console.WriteLine($"Первое число {firstNumber} больше второго {secondNumber} ");

else Console.WriteLine($"второе число {secondNumber} больше первого {firstNumber} ");