Console.WriteLine("Введите первое число");
int firstnumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int lastnumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите математическое действие(+, -, /, *)");
char userInput = char.Parse(Console.ReadLine());

if (userInput == '+')
{ 
    Console.WriteLine(firstnumber + lastnumber);
}
else if (userInput == '-')
{
  Console.WriteLine(firstnumber - lastnumber);
}
else if (userInput == '*')
{
    Console.WriteLine(firstnumber * lastnumber);
}
else if (userInput == '/')
{
    Console.WriteLine(firstnumber / lastnumber);
}
else
{
    Console.WriteLine("error input");
}
