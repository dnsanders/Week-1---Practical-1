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
        Console.WriteLine(name + " is a a ult");
    }

// Task 3

Console.WriteLine("Enter an integer");

int number = Convert.ToInt32(Console.ReadLine());

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