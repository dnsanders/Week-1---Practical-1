// Task 1

Console.WriteLine("Please enter your name");
    String name = Console.ReadLine();
    Console.WriteLine(name);

Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + name + " in 5 yours you will be " + (age + 5));

// Task 2

if (age < 13)
    {
        Console.WriteLine(name + " is a child!");
    }
else if (age >= 12 && age <= 19)
    {
        Console.WriteLine(name + " is a teenager");
    }
else if (age > 19)
    {
    Console.WriteLine(name + " is a a adult");
    }

// Task 3

Console.WriteLine("Enter an integer");

int number = Convert.ToInt32(Console.ReadLine()); // User inputs number.

if (number < 0)
{
    Console.WriteLine("{0} is a negitive number", number);
}
else if (number == 0)
{
    Console.WriteLine("{0} is Zero!", number);
}
else
{
    Console.WriteLine("{0} is a postive number", number);
}

// Task 4

Console.WriteLine("Enter a year");
int year  = Convert.ToInt32(Console.ReadLine()); // User inputs year.

while (year < 0) 
{
    Console.WriteLine("You entered a negitive number");
    Console.WriteLine("Enter a valid number");
    year = Convert.ToInt32(Console.ReadLine());
}
if (year % 4 == 0)
{
    Console.WriteLine(year + " is a leap year");
}
else
{
    Console.WriteLine(year + " is not a leap year");
}

// Task 5
Console.WriteLine("Enter a number");

int input = Convert.ToInt32(Console.ReadLine());

if (input % 2 == 0)
{
    Console.WriteLine(input + " is an even number");
}
else
{
    Console.WriteLine(input + " is an odd number");
}
