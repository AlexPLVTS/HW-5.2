using System;
using System.Transactions;

Console.WriteLine("Enter any value");

string input = Console.ReadLine();

try
{
    int intValue = int.Parse(input);
    Console.WriteLine($"Successfully parsed: {intValue}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong input format for 'int'");
}
catch (OverflowException)
{
    Console.WriteLine("Input value is too big for 'int'");
}
try
{
    long longValue = long.Parse(input);
    Console.WriteLine($"Successfully parsed: {longValue}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong input format for 'long'");
}
catch (OverflowException)
{
    Console.WriteLine("Input value is too big for 'long'");
}
try
{
    decimal decimalValue = decimal.Parse(input);
    Console.WriteLine($"Successfully parsed: {decimalValue}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong input format for 'decimal'");
}
catch (OverflowException)
{
    Console.WriteLine("Input value is too big for 'decimal'");
}
try 
{
    float floatValue = float.Parse(input);
    Console.WriteLine($"Successfully parsed: {floatValue}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong input format for 'float'");
}
catch (OverflowException)
{
    Console.WriteLine("Input value is too big for 'float'");
}
try
{
    double doubleValue = double.Parse(input);
    Console.WriteLine($"Successfully parsed: {doubleValue}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong input format for 'double'");
}
catch (OverflowException)
{
    Console.WriteLine("Input value is too big for 'double'");
}