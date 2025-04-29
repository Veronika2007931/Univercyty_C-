using System.Globalization;
using System.Text;
using Microsoft.VisualBasic;

Console.InputEncoding = Encoding.Unicode;

Console.OutputEncoding = Encoding.Unicode;

Produser produser1 = new Produser(1, "Skoda", "Ukraine");
Car miniCooper = new Car("miniCooper", "S", produser1, 2018, 44, 0.068, 13, 15000);
produser1.InformationProduser();
Console.WriteLine("Скільки кілометрів ви хочете проїхати?");
int kilometers = Convert.ToInt32(Console.ReadLine());
miniCooper.Moove(kilometers);
Aviacompany aviacompany1 = new Aviacompany("Ryanair", 1980, 1500);
// aviacompany1.Information();
Plane plane1 = new Plane("Lizard", 2000, 800, 200, 100, aviacompany1, "red");
plane1.PlaneInfo();

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


public class Aviacompany
{
    public string Name;
    public int YearOpened;
    public int FlightsOnYear;

    public Aviacompany(string name, int years, int flights)
    {
        Name = name;
        YearOpened = years;
        FlightsOnYear = flights;
    }

    public void Information()
    {
        Console.WriteLine($"Назва компанії:{Name}  Кількість років на ринку:{DateTime.Now.Year - YearOpened}  Кількість перелітів за рік:{FlightsOnYear}");
    }
}


public class Plane
{
    public string Name;
    public int NumberOfFlights;
    public int YearInvented;
    private int fuelUsage;
    public int FuelUsage
    {
        get { return fuelUsage; }
        set { fuelUsage = value > 0 ? value : throw new ArgumentException("Використання палива має бути більше 0"); }
    }
    public int NumberOfSeats { get; set; }
    private string color;
    public string Color
    {
        get { return color; }
        set { color = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Колір не може бути порожнім"); }
    }
    public Aviacompany Aviacompany1;

    public Plane(string name, int yearInvented, int flights, int fuelUsage, int seats, Aviacompany aviacompany1, string color)
    {
        Name = name;
        YearInvented = yearInvented;
        NumberOfFlights = flights;
        NumberOfSeats = seats;
        FuelUsage = fuelUsage;
        Color = color;
        Aviacompany1 = aviacompany1;
    }

    public void PlaneInfo()
    {
        Console.Write($"Назва літака: {Name}\n");
        Console.Write($"Вік літака: {DateTime.Now.Year - YearInvented} \n");
        Console.Write($"Використання палива на один польот: {FuelUsage}\n");
        Console.Write($" Кількість польотів: {NumberOfFlights} \n");
        Console.Write($" Кількість місць: {NumberOfSeats}\n");
        Console.Write($" Колір: {Color} \n");
        Aviacompany1.Information();
    }
}








