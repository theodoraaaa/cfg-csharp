int firstNumber = 5;

int secondNumber = 3;

int resultPlus = firstNumber + secondNumber;
int resultMinus = firstNumber - secondNumber;
int resultMultiply = firstNumber * secondNumber;
int resultDivide = firstNumber / secondNumber; // result is automatically an integer
int resultRemainder = firstNumber % secondNumber; // modulus operator gives the remainder
int resultPreIncrement = ++firstNumber; // this changes the value of firstNumber
int resultPreDecrement = --firstNumber; // this uses the new value of firstNumber

Console.WriteLine("The sum is: " + resultPlus);
Console.WriteLine("The difference is: " + resultMinus);
Console.WriteLine("The product is: " + resultMultiply);
Console.WriteLine("The quotient is: " + resultDivide);
Console.WriteLine("The remainder is: " + resultRemainder);
Console.WriteLine("The incremented first number is: " + resultPreIncrement);
Console.WriteLine("The decremented first number is: " + resultPreDecrement);

// ++firstNumber = pre-increment - this changes the value of firstNumber before it is used
// --firstNumber = pre-decrement - this changes the value of firstNumber before it is used
// firstNumber++ = post-increment - this changes the value of firstNumber after it is used
// firstNumber-- = post-decrement - this changes the value of firstNumber after it is used  