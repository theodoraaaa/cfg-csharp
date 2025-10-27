// smoothie example

bool strawberry = true;
bool banana = false;

if (strawberry && banana)
{
    Console.WriteLine("You can make a smoothie!");
}
else if (strawberry || banana)
{
    Console.WriteLine("You can eat a piece of fruit.");
}
else
{
    Console.WriteLine("You need more ingredients to make a smoothie.");
}

// raining example

bool raining = true;

if (!raining) {
    Console.WriteLine("It's not raining outside.");
}
else {
    Console.WriteLine("It's raining outside. Take an umbrella!");
}