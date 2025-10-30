// start with the return type of the method

int AddNumbers (int a, int b)
{
    int result = a + b;
    return result;
}

AddNumbers(10, 5);
Console.WriteLine(AddNumbers(10, 5));

// or

int sum = AddNumbers(10, 5);
Console.WriteLine("The sum of these two numbers is " + sum);