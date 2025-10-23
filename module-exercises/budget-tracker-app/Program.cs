// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to our budget tracker app!");

// 1. Create a variable called groceryBudget and set a monthly budget
double groceryBudget = 200.00;

// 2. Create a variable called entertainmentBudget and set a monthly budget
double entertainmentBudget = 250.00;

// 3. Use Console.WriteLine() to output these variables to the console
Console.WriteLine($"Grocery budget: {groceryBudget}");
Console.WriteLine($"Entertainment budget: {entertainmentBudget}");

// 4. Create an array called fixedExpenses to store 3 double variables (one for rent, one for electricity and one for water)
// double[] fixedExpenses = { 1200.00, 150.00, 50.00 };

//    and output the contents of the array to the console
// Console.WriteLine("Fixed Expenses: ");
// Console.WriteLine("Rent: " + fixedExpenses[0]);
// Console.WriteLine("Electricity: " + fixedExpenses[1]);
// Console.WriteLine("Water: " + fixedExpenses[2]);

// 5. Replace the array with a List
List<double> fixedExpenses = new List<double> { 1200.00, 150.00, 50.00 };
Console.WriteLine("Fixed Expenses: ");
Console.WriteLine("Rent: " + fixedExpenses[0]);
Console.WriteLine("Electricity: " + fixedExpenses[1]);
Console.WriteLine("Water: " + fixedExpenses[2]);

// 6. Add some new expenses to the List using List methods
fixedExpenses.Add(35.00); // Internet
fixedExpenses.Add(9.99);  // Spotify

Console.WriteLine("Internet: " + fixedExpenses[3]);
Console.WriteLine("Spotify: " + fixedExpenses[4]);
