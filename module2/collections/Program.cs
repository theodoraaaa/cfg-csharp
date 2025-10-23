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