

Console.SetCursorPosition(20, 20);
Console.WriteLine("Hello KP-41!");

int X = Console.CursorLeft;
int y = Console.CursorTop;

Console.WriteLine($"{X} {y}");



Console.SetWindowSize(40, 40);
Console.WriteLine(Console.WindowWidth);
Console.WriteLine(Console.WindowHeight);

Console.SetBufferSize(80, 20);

Console.WriteLine("Enter one symbol");
int asciiCode = Console.Read();
char charcter = (char)asciiCode;
Console.WriteLine($"You entered symbol {charcter}");

while (Console.ReadKey().Key != ConsoleKey.Enter) ;

Console.ReadKey(true);
Console.ReadKey(false);
// Щоб або виводити на екран або не виводити

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Ukraine!!");

Console.ResetColor();
Console.Clear();
// очищує консоль
Boolean p = Console.CursorVisible;
Console.CursorVisible = true;
Console.CursorVisible = false;
Console.CursorSize = 20;