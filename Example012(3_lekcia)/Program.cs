// // Первая группа методов

// void Metod1()
// {
// Console.WriteLine("Автор ..."); }
// Metod1();




// Вторая группа методов

// void Metod2(string msg)
// {
//     Console.WriteLine(msg);

// }
// Metod2("Текст сообщения");


// void Metod21(string msg, int count)
// {
//     int i =0;
//     while (i < count) 
//     {
//             Console.WriteLine(msg);
//             i++;
//     }
// }
// Metod21("Текст", 4);

// Третья группа методов

// int Metod3()
// {
//     return DateTime.Now.Year;

// }

// int year = Metod3();
// Console.WriteLine(year);


//  Четвёртая группа методов

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
