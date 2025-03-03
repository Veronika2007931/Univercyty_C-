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
