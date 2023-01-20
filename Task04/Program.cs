// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Из трех чисел сравниваем наибольшее");

Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье  число");
int numberThree = Convert.ToInt32(Console.ReadLine());

int max = numberOne;
if ( numberTwo> max){
    max = numberTwo;
}
if(numberThree > max){
    max = numberThree;
}
Console.WriteLine($"Наибольшее из перечисленных чисел это {max}");