// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Проверяем четное ли число");

Console.WriteLine("Введите число");

int divideNumber = Convert.ToInt32(Console.ReadLine());

if(divideNumber % 2 == 1){
    Console.WriteLine($"Число {divideNumber} является нечетным");
}
else{
    Console.WriteLine($"Число {divideNumber} является ЧЕТНЫМ");

}