using System.Globalization;
using System.Text;
using Microsoft.VisualBasic;
Console.InputEncoding = Encoding.Unicode;

Console.OutputEncoding = Encoding.Unicode;
// 1

// Product[] products = new Product[5];
// products[0] = new Product("Apple", 10);
// products[1] = new Product("Soap", 30);
// products[2] = new Product("Fish", 100);
// products[3] = new Product("Juse", 50);
// products[4] = new Product("Pie", 150);

// Console.WriteLine("List of available positions:");
// for (int i = 0; i < products.Length; i++)
// {
//     Console.WriteLine($"{i}: {products[i].Name}");
// }

// Console.WriteLine("Choose number of position");
// int position = Convert.ToInt32(Console.ReadLine());
// if (position == 0)
// {
//     products[0].Display();
// }
// else if (position == 1)
// {
//     products[1].Display();
// }
// else if (position == 2)
// {
//     products[2].Display();
// }
// else if (position == 3)
// {
//     products[3].Display();
// }
// else if (position == 4)
// {
//     products[4].Display();
// }

// Console.WriteLine("Enter emount of money you give");
// int money = Convert.ToInt32(Console.ReadLine());
// if (money == products[position].Price || money > products[position].Price)
// {
//     Console.WriteLine($"Rest: {money - products[position].Price}");
// }
// else
// {
//     Console.WriteLine("Not enoughf emount of money");
// }


// class Product
// {
//     public string Name;
//     public int Price;

//     public Product(string name, int price)
//     {
//         Name = name;
//         Price = price;
//     }

//     public void Display()
//     {


//         Console.Write($"Position:{Name} price:{Price}");
//     }

// }

// 2

string[] alphabet = new string[]
{
    "a", "b", "c", "d", "e", "f", "g",
    "h", "i", "j", "k", "l", "m", "n",
    "o", "p", "q", "r", "s", "t", "u",
    "v", "w", "x", "y", "z"
};

Console.WriteLine("Enter letter number of what you want to know");
string letter = Console.ReadLine();

string result = Array.Find(alphabet, l => l == letter);

if (result != null)
{
    int index = Array.IndexOf(alphabet, result);
    Console.WriteLine($"Порядковий номер: {index + 1}");

}
else
{
    Console.WriteLine("You entered something wrong");
}



foreach (string l in alphabet)
{
    Console.Write($"{l}");
}


string[] alphabet2 = new string[]
{
    "a", "б", "в", "г", "д", "е","є", "ж",
    "з", "и", "і", "ї", "й", "к", "л",
    "м", "н", "о", "п", "р", "с", "т",
    "у", "ф", "x", "ц", "ч","ш", "щ", "ь", "ю", "я"
};

foreach (string l in alphabet2)
{
    Console.Write($"{l}");
}


Dictionary<string, int> products =
    new Dictionary<string, int>();

products.Add("apple", 10);
products.Add("banana", 15);
products.Add("citruse", 20);
products.Add("mango", 50);

// Отримання значення за ключем
int price = products["apple"];

// Перевірка наявності ключа у словнику
bool containsKey = products.ContainsKey("apple");

// Зміна значення за ключем
products["apple"] = 7;

// Видалення елемента за ключем
products.Remove("apple");
