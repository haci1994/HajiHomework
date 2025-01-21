//1. Verilmiş iki ədədin cəmini hesablayan proqram yazın.
Console.WriteLine("1. Verilmiş iki ededin cemini hesablayan proqram!");
Console.WriteLine("-----------------");
Console.Write("İlk ededi daxil edin: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write($"{number1} + (ikinci eded:) ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"= {number1 + number2}");
Console.WriteLine("-----------------");
Console.WriteLine("-----------------");

//2. Verilmiş ədədin cüt və ya tək olduğunu təyin edən proqram yazın.

Console.WriteLine("2. Verilmiş ededin cüt ve ya tek olduğunu teyin eden proqram!");
Console.WriteLine("-----------------");

Console.Write("Yoxlamaq istediyiniz ededi daxil edin:");
int number3 = int.Parse(Console.ReadLine());

if (number3 % 2 == 0)
{
    Console.WriteLine($"{number3} - cüt ededdir");
}
else
{
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
}
else if (number4 < 0)
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
bool teen = age >= 13 & age < 19;
bool adult = age >= 20 && age < 150;

if (kids)
{
    Console.WriteLine("Usaq");
}
else if (teen)
{
    Console.WriteLine("Yeniyetme");
}
else if (adult)
{
    Console.WriteLine("Boyuk");
}
else
{
    Console.WriteLine($"{age} yas ucun duzgun deyer deyil!");
}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");

//5. İki ədəddən hansının daha böyük olduğunu müəyyən edən proqram yazın.

Console.WriteLine("Iki ededi muqayise eden proqram");
Console.WriteLine("-----------------");

Console.Write("Birinci ededi daxil edin:");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Ikinci ededi daxil edin:");
double n2 = double.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"{n1} > {n2}. ({n1}, {n2}-den (dan) {n1 - n2} vahid boyukdur!)");
}
else if (n1 < n2)
{
    Console.WriteLine($"{n2} > {n1}. ({n2}, {n1}-den (dan) {n2 - n1} vahid boyukdur!)");
}
else
{
    Console.WriteLine($"{n1} = {n2}");
}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");

//6. İstifadəçidən 1-dən 7-yə qədər bir rəqəm daxil etməsini istəyin və ona uyğun həftənin gününü çap edin.Məsələn: 1 → Bazar ertəsi, 2 → Çərşənbə axşamı və s.

Console.WriteLine("Heftenin gununun adini teyin eden proqram!");
Console.Write("Heftenin gununu daxil edin:");
byte weekday = byte.Parse(Console.ReadLine());

switch (weekday)
{
    case 1:
        Console.WriteLine("Bazar ertesi");
        break;
    case 2:
        Console.WriteLine("Cersenbe axsami");
        break;
    case 3:
        Console.WriteLine("cersenbe");
        break;
    case 4:
        Console.WriteLine("cume axsami");
        break;
    case 5:
        Console.WriteLine("cume");
        break;
    case 6:
        Console.WriteLine("senbe");
        break;
    case 7:
        Console.WriteLine("bazar");
        break;
    default:
        Console.WriteLine("Heftenin gununu duzgun daxil edin!");
        break;
}

// IF ile yazsaydim asagidaki kimi yazardim:
// if (weekday == 1) {
//          Console.WriteLine("Bazar ertesi");}
//  else if (weekday == 2) {
//          Console.WriteLine("Cersenbe axsami");}
//  else if ..............
//  else {Console.WriteLine("Heftenin gununu duzgun daxil edin!");}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");

//7. İlin təkcə 365 gündən yox, həm də sıçrayış ili (leap year) olub-olmadığını yoxlayın.İl 4-ə tam bölünməlidir, amma 100-ə bölünməməlidir və ya 400-ə tam bölünməlidir

Console.WriteLine("Ilin -Leap Year- oldugunu yoxlayan proqram");

Console.Write("Yoxlamaq istediyiniz ili daxil edin:");

int year = int.Parse(Console.ReadLine());

if (year%4 ==0)
{
    if (year%100 == 0 && year%400 >0)
    {
        Console.WriteLine("365");
    } else
    {
        Console.WriteLine("366");
    }
} else
{
    Console.WriteLine("365");
}

Console.WriteLine("-----------------");
Console.WriteLine("-----------------");


