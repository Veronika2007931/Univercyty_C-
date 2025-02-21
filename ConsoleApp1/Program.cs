// int age = 18;
// string name = "Veronika";
// bool f = false;
// char symbol = '@';
// decimal decimalnumb = 3.179767837467m;
// float floatNumb = 2.4f;
// double doubleNumb = 4.3456;
// byte byteNumb = 250;

// Console.WriteLine($"{age}   {name} {f} {symbol} {decimalnumb} {floatNumb} {doubleNumb} {byteNumb}");
// Console.WriteLine("Age" + age + "name" + name + "f" + f + "symbol" + symbol + "decimalnumb" + decimalnumb + "floatNumb" + floatNumb + "doubleNumb" + doubleNumb + "byteNumb" + byteNumb);
// Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", age, name, f, symbol, decimalnumb, floatNumb, doubleNumb, byteNumb);

// Console.WriteLine("скільки зараз годин?");
// byte hour = Convert.ToByte(Console.ReadLine());

// Console.WriteLine("${hour}");

// Console.WriteLine("скільки зараз годин?");
// byte hour2 = byte.Parse(Console.ReadLine());

// Console.WriteLine("${hour}");

// if (hour > 12)
// {
//     Console.WriteLine("pm");
// }
// else if (hour < 12)
// {
//     Console.WriteLine("am");
// }
// else
// {
//     Console.WriteLine("Incorect number");
// }
// ;


// Console.WriteLine(hour < 12 ? "am" : hour > 12 & hour < 24 ? "pm" : "incorect number");

// Random random = new Random();
// int randomNumb = random.Next(20, 31);
// Console.WriteLine(randomNumb);

// for (int i = 11; i < randomNumb; i++)
// {
//     Console.WriteLine(i);
// }

// Random random2 = new Random();
// int[] array = new int[6];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random2.Next(-5, 0);
// }

// foreach (var number in array)
// {
//     Console.Write(number);
// }

// Random random3 = new Random();
// int[,] array1 = new int[4,5];
// for (int i = 0; i < array1.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         array1[j] = random3.Next(-5, 0);
//     }
// }

// foreach (var number in array1)
// {
//     Console.Write(number);
// }

// лабораторна

using System.Text;
using Microsoft.VisualBasic;

Console.InputEncoding = Encoding.Unicode;

Console.OutputEncoding = Encoding.Unicode;

Produser produser = new Produser(1, "Skoda", "Ukraine");
Car miniCooper = new Car("miniCooper", "S", produser, 2018, 44, 0.068, 13, 15000);
produser.InformationProduser();
Console.WriteLine("Скільки кілометрів ви хочете проїхати?");
int kilometers = Convert.ToInt32(Console.ReadLine());
miniCooper.Moove(kilometers);


public class Produser
{
    public int Year;
    public string Contry;
    public string Name;

    public Produser(int year, string name, string contry)
    {
        Year = year;
        Name = name;
        Contry = contry;
    }

    public void InformationProduser()
    {

        Console.WriteLine($" Країна виробника: {Contry} Назва: {Name} Кількість років уже існує на ринку: {DateTime.Now.Year - Year} ");
    }
}


public class Car
{
    public string Name;
    public string Mark;
    public Produser Produser1;
    public int YearMade;
    public int FullFuel;
    public double FuelUsing;
    public int FuelNow;
    public int KilometersPassed;


    public Car(string name, string mark, Produser produser1, int yearMade, int fullFuel, double fuelUsing, int fuelNow, int kilometersPassed)
    {
        Name = name;
        Mark = mark;
        YearMade = yearMade;
        FullFuel = fullFuel;
        FuelUsing = fuelUsing;
        KilometersPassed = kilometersPassed;
        FuelNow = fuelNow;
        Produser1 = produser1;

    }

    public void CarInfo()
    {
        Console.WriteLine($"Назва:{Name} марка:{Mark} Рік коли випущено:{YearMade} Ємність баку для пального:{FullFuel}L  Використання пального на один кілометр:{FuelUsing} 0.065  Проїханий кілометраж:{KilometersPassed}km Залишок пального:{FuelNow}L Виробник:{Produser1}");
    }

    public void Moove(int kilometers)
    {

    }
}


