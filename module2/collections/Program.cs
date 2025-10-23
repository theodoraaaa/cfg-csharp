// Arrays

// fixed size, all the same data type, limited functionality
string fruit1 = "apple";
string fruit2 = "plum";
string fruit3 = "cherry";

// use [] to declare an array
string[] fruits = new string[3]; // count from zero

// initialise array elements
fruits[0] = "apple";
fruits[1] = "plum";
fruits[2] = "cherry";

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

List<string> fruitList2 = new List<string>{"apple", "plum", "cherry"}; // {} for when elements are known at compile time

Console.WriteLine(fruitList[0]); // apple
Console.WriteLine(fruitList[1]); // plum
Console.WriteLine(fruitList[2]); // cherry

fruitList2.Add("banana");
fruitList2.Add("strawberry");
fruitList2.Add("kiwi");

// apple, plum, cherry, banana, strawberry, kiwi

fruitList2.Remove("kiwi");

// Console.WriteLine(fruitList2[5]); // returns an error because we removed kiwi

fruitList2.RemoveAt(0); // removes apple

Console.WriteLine(fruitList2[0]); // now plum