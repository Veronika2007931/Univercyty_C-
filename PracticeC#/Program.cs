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

string[,,] thirdArray = new string[2, 3, 4];

for (int x = 0; x < 2; x++)
{
    for (int y = 0; y < 3; y++)
    {
        for (int z = 0; z < 4; z++)
        {

            thirdArray[x, y, z] = "a";
            Console.Write(thirdArray[x, y, z] + "\t");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
;
