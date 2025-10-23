// Arrays

// fixed size, all the same data type, limited functionality
string fruit1 = "apple";
string fruit2 = "plum";
string fruit3 = "cherry";

// use [] to declare an array
string[] fruit = new string[3]; // count from zero

// initialise array elements
fruit[0] = "apple";
fruit[1] = "plum";
fruit[2] = "cherry";

// alternative array initialisation syntax
string[] fruity = new string[] { "apple", "plum", "cherry" };

// access array elements using index
Console.WriteLine(fruity[0]); // apple
Console.WriteLine(fruity[1]); // plum
Console.WriteLine(fruity[2]); // cherry

// Lists

List<string> fruitList = new List<string>(); // () for when elements aren't known at compile time

fruitList.Add("apple");
fruitList.Add("plum");
fruitList.Add("cherry");

List<string> fruits = new List<string>{"apple", "plum", "cherry"}; // {} for when elements are known at compile time

Console.WriteLine(fruits[0]); // apple
Console.WriteLine(fruits[1]); // plum
Console.WriteLine(fruits[2]); // cherry

fruits.Add("banana");
fruits.Add("strawberry");
fruits.Add("kiwi");

// apple, plum, cherry, banana, strawberry, kiwi

fruits.Remove("kiwi");

// Console.WriteLine(fruits[5]); // returns an error because we removed kiwi

fruits.RemoveAt(0); // removes apple

Console.WriteLine(fruits[0]); // now plum

// List methods

// AddRange - adds another collection to the end of the list
List<string> fruits2 = new List<string>{"mango", "papaya", "grape"};
fruits.AddRange(fruits2); // adds all elements of fruits2 to fruits

Console.WriteLine(fruits[0]); // plum
Console.WriteLine(fruits[1]); // cherry
Console.WriteLine(fruits[2]); // banana
Console.WriteLine(fruits[3]); // strawberry
Console.WriteLine(fruits[4]); // mango
Console.WriteLine(fruits[5]); // papaya
Console.WriteLine(fruits[6]); // grape

// Insert - adds an element at a specific index
fruits.Insert(0, "melon"); // adds melon at index 0

Console.WriteLine(fruits[0]); // melon

// Contains - check if a specific element exists in the list

Console.WriteLine(fruits.Contains("banana")); // True
Console.WriteLine(fruits.Contains("kiwi")); // False

// IndexOf - finds the index of a specific element

Console.WriteLine(fruits.IndexOf("strawberry")); // 4

// Count - gets the number of elements in the list

Console.WriteLine(fruits.Count); // 8

// Sort elements in order (ascending order for numbers, alphabetical order for characters and strings)

fruits.Sort();
Console.WriteLine(fruits[0]); // banana
Console.WriteLine(fruits[5]); // papaya

// Reverse - reverses the order of elements in the list

fruits.Reverse();
Console.WriteLine(fruits[0]); // strawberry
Console.WriteLine(fruits[5]); // grape

// Clear - removes all elements from the list
fruits.Clear();
Console.WriteLine(fruits.Count); // 0