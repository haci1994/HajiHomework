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

//3. Verilmiş bir ədədin müsbət, mənfi və ya sıfır olub-olmadığını təyin edən proqram yazın.

Console.WriteLine("2. Verilmiş ededin musbet, menfi ve ya sifir olgugunu teyin eden proqram!");
Console.WriteLine("-----------------");

Console.Write("Yoxlamaq istediyiniz ededi daxil edin:");
double number4 = double.Parse(Console.ReadLine());

if (number4 == 0)
{
    Console.WriteLine($"{number4} yoxlamanin neticesi: Eded SIFIR-a beraberdir!");
} else if (number4 < 0)
{
    Console.WriteLine($"{number4} yoxlamanin neticesi: Eded MENFI-dir!");
}
else
{
    Console.WriteLine($"{number4} yoxlamanin neticesi: Eded MUSBET-dir!");
}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");


//4. İstifadəçinin yaşına əsasən, onu bir kateqoriyaya aid edin:
//0 - 12: Uşaq
//13-19: Yeniyetmə
//20 və yuxarı: Böyük.

Console.WriteLine("Yas kateqoriyasi proqrami!");
Console.WriteLine("-----------------");

Console.Write("Yasi daxil edin:");
int age = int.Parse(Console.ReadLine());

bool kids = age >= 0 && age < 13;
bool teen = age >=13 & age < 19;
bool adult = age >=20 && age <150;

if (kids){
    Console.WriteLine("Usaq");
} else if(teen) {
    Console.WriteLine("Yeniyetme");
} else if(adult)
    {
    Console.WriteLine("Boyuk");
} else
{
    Console.WriteLine($"{age} yas ucun duzgun deyer deyil!");
}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");