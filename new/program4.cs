// public sealat class D()
// {

// }

// public int a, { get; set; }


//B c = new B();

using System.Runtime.InteropServices.Marshalling;

public class B1
{
    static B1()
    {
        Console.WriteLine("YEar");

    }

    public B1()
    {
        Console.WriteLine("Month");
    }
}

// record A (int i);

public class A1
{
    public int b { get; set; }
}

// public int Me (ref int a)
// public ME1(int a)

public interface IMe
{
    string Name { get; set; }
    int Age { get; set; }

    void SayHello();
}

public class ME : IMe
{
    public string Name { get; set; }
    public int Age { get; set; }

    public ME(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine($"Привіт! Мене звати {Name}, мені {Age} років.");
    }
}

// зробити приклад з наслідуванням 

// Virtual
// new
// abstract 

// почитати що таке атрибути та зробити їх
