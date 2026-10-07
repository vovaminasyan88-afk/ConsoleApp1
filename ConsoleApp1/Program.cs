////// урок 1-------------------------------------------------------------------------------------------------------------------------------------

////////Ваше имя
//////Console.WriteLine("Вова");
////////Мой возвраст
//////Console.WriteLine("14");
////////Наш курс
//////Console.WriteLine("Курс : С#");
////////Мой город
//////Console.WriteLine("Сочи");
//////Console.Read();

////// урок 2----------------------------------------------------------------------------------------------------------------------------------

//////int userAge = 34;
//////string userName = "Vova";
//////double userHealh = 101.1;
//////Console.WriteLine($"мой возвраст: {userAge} мое имя:{userName} ,мое здоровье: {userHealh} ");  
//////Console.Read();

//////var userAge = 14; //int
//////var userName = "Vova"; //string
//////var userHealh = 14.5;
//////Console.WriteLine()

//////const userAge = 1488;
////////userAge = 228;
//////Console.WriteLine(userAge);
//////Console.Read();

//////int a = 228;
//////int b = 1488;

//////int sum = a + b;
//////int diff = a - b;
//////int product = a * b;
//////int quotinet = a / b;
//////int remainder = a % b;
//////Console.WriteLine(" a = " + a);
//////Console.WriteLine(" b = " + b);
//////Console.WriteLine(" sum = " + sum);
//////Console.WriteLine("Вычитание =" + diff);
//////Console.WriteLine("Умножение = " + product);
//////Console.WriteLine("Деление = " + quotinet);
//////Console.WriteLine("Без остатка = " + remainder);

//////УРОК 3-------------------------------------------------------------------------------------------------------------------------------------

//////String name = "Vova";
//////int age = 14;
//////Console.WriteLine(name);
//////Console.WriteLine(age);

//////string name = "Vova";
//////double age = 1.4;
//////age = 13;
//////name = "Lox";
//////Console.WriteLine(name);
//////Console.WriteLine();
//////Console.ReadLine();

//////Console.WriteLine("1. Введите свой возвраст \n 2.Введите свое имя \n Введите свою почту!");
//////Console.WriteLine("1. Введите свой возвраст \t 2.Введите свое имя \t Введите свою почту! - Это табуляция");
//////Console.WriteLine();

//////string name = "vova";
//////int age = 14;
//////bool pogoda = false;
//////double ves = 50;
//////Console.WriteLine($"Мое имя: \t{name}");
//////Console.WriteLine($"Мой возвраст: \t{age}");
//////Console.WriteLine($"Моя погода: \t{pogoda}");
//////Console.WriteLine($"Мой вес: \t{ves}");

//////var name = "Vova";
//////var age = 14;
//////var ves = 50;
//////var  svet = true;
//////Console.WriteLine($"Мое имя: \t{name}");
//////Console.WriteLine($"Мой возварст: \t{age}");
//////Console.WriteLine($"Мой вес: \t{ves}");
//////Console.WriteLine($"Моя погода: \t{svet}");

//////string name = "Vova";
//////int age = 14;
//////double height = 100.1;
//////Console.WriteLine($"Мое имя: {0} \nМой возвраст: {1} \nМой здоровье: {2}", name, age, height);
//////Console.ReadLine();

//////Console.WriteLine("Введите свое имя");
//////var name = Console.ReadLine();
//////Console.WriteLine($"Мое имя:{name}");

//////double x = 10;
//////double y = 3;
//////Console.WriteLine(x % y);

//////4 урок-----------------------------------------------------------------------------------------------------------------------------------


//////int userAge = 20;
//////Console.WriteLine("Введите цифру");
//////if (userAge >= 20)
//////{
//////    Console.WriteLine("Вы совершенно летний"); //---------Определение возварста-------- -
//////}
//////Console.WriteLine("Конец программы");

//////Console.WriteLine("Введите пожалуйста время от (0 до 23)");
//////int hour = Convert.ToInt32(Console.ReadLine());



//////if (hour >= 6 && hour < 12)
//////{
//////    Console.WriteLine("Доброе утро");
//////}
//////else if (hour >= 12 && hour < 18)
//////{
//////    Console.WriteLine("Добрый день");
//////}                                              //-----------Определение времени-----------
//////else if (hour >= 18 && hour < 23)
//////{
//////    Console.WriteLine("Добрый вечер!");
//////}
//////else
//////{
//////    Console.WriteLine("доброй ночи");
//////}



////bool isVip = false;
////double money = 5000.0;


////if (isVip == true || money > 6000) ;
////{
////    Console.WriteLine("вХОД зАПРЕЩЕН");
////}
////else
////{
////    Console.WriteLine("Вход запрещен");
////}


//Console.WriteLine("Введите значение от 0 до 10");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Начало цикла for");

//for (int i = firstNum; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"Четные числа:{i}");
//    }
//    else 
//    {
//        Console.WriteLine($"Не Четные числа i:{i}");
//    }
//}
//Console.WriteLine("конец цикла for");
//Console.ReadLine();




for (int i = 10; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"Первое число которое делиться на 7: {i * i}");
        break;
    }
}














