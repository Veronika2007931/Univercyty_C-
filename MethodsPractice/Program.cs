using System.Globalization;
using System.Text;
using Microsoft.VisualBasic;
Console.InputEncoding = Encoding.Unicode;

Console.OutputEncoding = Encoding.Unicode;
// Console.SetCursorPosition(20, 20);
// Console.WriteLine("Hello KP-41!");

// int X = Console.CursorLeft;
// int y = Console.CursorTop;

// Console.WriteLine($"{X} {y}");



// Console.SetWindowSize(40, 40);
// Console.WriteLine(Console.WindowWidth);
// Console.WriteLine(Console.WindowHeight);

// Console.SetBufferSize(80, 20);

// Console.WriteLine("Enter one symbol");
// int asciiCode = Console.Read();
// char charcter = (char)asciiCode;
// Console.WriteLine($"You entered symbol {charcter}");

// while (Console.ReadKey().Key != ConsoleKey.Enter) ;

// Console.ReadKey(true);
// Console.ReadKey(false);
// // Щоб або виводити на екран або не виводити

// Console.BackgroundColor = ConsoleColor.Blue;
// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.WriteLine("Ukraine!!");

// Console.ResetColor();
// Console.Clear();
// // очищує консоль
// Boolean p = Console.CursorVisible;
// Console.CursorVisible = true;
// Console.CursorVisible = false;
// Console.CursorSize = 20;

// Console.SetBufferSize(80, 20);

// Console.SetWindowSize(40, 40);

// setting the window size 
Console.SetWindowSize(40, 40);

// setting buffer size of console 
Console.SetBufferSize(80, 80);

// using the method 
Console.SetCursorPosition(20, 20);


string text = "ProgramTitle";
Console.Title = text;
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(20, 20);
Console.WriteLine(Console.Title);
Console.BackgroundColor = ConsoleColor.Black;
Console.SetCursorPosition(20, 20);
Console.WriteLine("-----------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.SetCursorPosition(20, 20);
Console.WriteLine("Введіть слово");
string word = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.SetCursorPosition(20, 20);
Console.WriteLine("-----------------");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition(20, 20);
Console.WriteLine($"1  {word} |{word}  2");
Console.SetCursorPosition(20, 20);

Console.WriteLine($"   {word} |{word}   ");
Console.SetCursorPosition(20, 20);
Console.WriteLine($"3  {word} |{word}  4");
Console.BackgroundColor = ConsoleColor.Black;




