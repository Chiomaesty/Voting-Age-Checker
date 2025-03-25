using System.ComponentModel.Design;

Console.WriteLine("CHECK ELIGIBILITY");
Console.WriteLine();
Console.WriteLine("ENTER NAME");
String name = Console.ReadLine();

Console.WriteLine("HELLO " + name.ToUpper() + ", WELCOME \nENTER AGE: ");


int Age;

while (!int.TryParse(Console.ReadLine(), out Age) || Age < 0)
{
    Console.WriteLine("INVALID INPUT. PLEASE INPUT A POSITIVE NUMBER");
}

if (Age < 18) 
{
    Console.WriteLine($"I AM SORRY {name.ToUpper()} YOU ARE NOT ELIGIBLE TO VOTE.");
}

else
{
    Console.WriteLine("YOU ARE ELIGIBLE TO VOTE");
}
