using EnumerableSamples;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("=======================");
Console.WriteLine("Enumerables");
Console.WriteLine("=======================");

#region List
//Console.WriteLine("*** List<T> ***");
//var products = new List<Product>
//{
//    new Product { Id = 1, Name = "Coke", Price = 2.15M },
//    new Product { Id = 2, Name = "Milk", Price = 5.58M },
//    new Product { Id = 3, Name = "iPhone", Price = 354.99M },
//    new Product { Id = 4, Name = "iWatch", Price = 121.99M },
//};

//Console.WriteLine("Original list =>");
//for (int i = 0; i < products.Count; i++)
//{
//    Console.WriteLine(products[i]);
//}

//Console.WriteLine("Ordered list =>");
//products = products.OrderByDescending(p => p.Price).ToList();
//for (int i = 0; i < products.Count; i++)
//{
//    Console.WriteLine(products[i]);
//}

#endregion

#region Dictionary1
//Console.WriteLine("*** Dictionary<TKey, TValue> ***");
//var fruits = new Dictionary<string, int>
//{
//    { "Manzana", 10 },
//    { "Pera", 12 },
//    { "Sandia", 7 },
//    { "Uva", 30 },
//    { "Aguacate", 12 },
//    { "Kiwi", 4 }
//};

//if (fruits.ContainsKey("Limon"))
//{
//    fruits["Limon"] += 20;
//}
//else
//{
//    fruits.Add("Limon", 20);
//}

//foreach (var fruit in fruits)
//{
//    Console.WriteLine($"{fruit.Key} => {fruit.Value}");
//}
#endregion

#region Dictionary2
//Console.WriteLine("*** Dictionary<TKey, TValue> ***");
//var products = new Dictionary<int, Product>
//{
//    { 1, new Product { Id = 1, Name = "Coke", Price = 2.15M } },
//    { 2, new Product { Id = 2, Name = "Milk", Price = 5.58M } },
//    { 3, new Product { Id = 3, Name = "iPhone", Price = 354.99M } },
//    { 4, new Product { Id = 4, Name = "iWatch", Price = 121.99M } },
//};

//if (products.ContainsKey(5))
//{
//    products[5].Price *= 1.10M;
//}
//else
//{
//    products.Add(5, new Product { Id = 5, Price = 34.45M, Name = "Shirt" });
//}

//foreach (var product in products)
//{
//    Console.WriteLine($"{product.Key} => {product}");
//}
#endregion

#region LinkedList
//Console.WriteLine("*** LinkedList<T> ***");
//var numbers = new LinkedList<int>();
//numbers.AddFirst(5);
//numbers.AddLast(10);
//numbers.AddLast(20);
//numbers.AddLast(30);
//numbers.AddLast(40);
//numbers.AddLast(50);
//numbers.AddLast(60);
//numbers.AddLast(65);

//var node30 = numbers.Find(30);
//numbers.AddAfter(node30!, 35);

//var node50 = numbers.Find(50);
//numbers.Remove(node50!);

//var pointer = numbers.First;
//while (pointer != null)
//{
//    Console.WriteLine(pointer.Value);
//    pointer = pointer.Next;
//}

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}
#endregion

#region Queue
//Console.WriteLine("*** Queue<T> ***");
//var messages = new Queue<string>();
//messages.Enqueue("Primer mensaje");
//messages.Enqueue("Segundo mensaje");
//messages.Enqueue("Tercer mensaje");

//foreach (var message in messages)
//{
//    Console.WriteLine(message);
//}

//var messagePeeked = messages.Peek();
//Console.WriteLine($"Peeked: {messagePeeked}");

//var messageDequeeded = messages.Dequeue();
//Console.WriteLine($"Dequeeded: {messageDequeeded}");

//Console.WriteLine("New queue =>");
//foreach (var message in messages)
//{
//    Console.WriteLine(message);
//}

//Console.WriteLine("Dequeue process =>");
//while (messages.Count > 0)
//{
//    var message = messages.Dequeue();
//    Console.WriteLine(message);
//}
#endregion

#region Stack
Console.WriteLine("*** stack<T> ***");
var numbers = new Stack<int>();
for (int i = 0; i < 10; i++)
{
    numbers.Push(i);
}

var numberPeeked = numbers.Peek();
Console.WriteLine($"Peeked: {numberPeeked}");

var numberPoped = numbers.Pop();
Console.WriteLine($"Poped: {numberPoped}");

numbers.Push(500);

Console.WriteLine("Pop process =>");
while (numbers.Count > 0)
{
    var number = numbers.Pop();
    Console.Write($"{number}\t");
}
Console.WriteLine();
#endregion