// See https://aka.ms/new-console-template for more information

//1. Verilmiş iki ədədin cəmini hesablayan proqram yazın.
Console.WriteLine("1. Verilmiş iki ededin cemini hesablayan proqram!");
Console.WriteLine("-----------------");
Console.Write("İlk ededi daxil edin: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write($"{number1} + (ikinci eded:) ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"= {number1+number2}");
Console.WriteLine("-----------------");
Console.WriteLine("-----------------");

//2. Verilmiş ədədin cüt və ya tək olduğunu təyin edən proqram yazın.

Console.WriteLine("2. Verilmiş ededin cüt ve ya tek olduğunu teyin eden proqram!");
Console.WriteLine("-----------------");

Console.Write("Yoxlamaq istediyiniz ededi daxil edin:");
int number3 = int.Parse(Console.ReadLine());

if (number3 % 2 == 0) {
    Console.WriteLine($"{number3} - cüt ededdir");
} else {
    Console.WriteLine($"{number3} - tek ededdir");
}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");
