// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine ("Введите первое число");
string num1=Console.ReadLine();
int number1=int.Parse(num1);
Console.WriteLine ("Введите второе число");
string num2=Console.ReadLine();
int number2=int.Parse(num2);
if (number1>number2) Console.Write ("Число "+number1+" большее, а число "+number2+" меньшее");
if (number1<number2) Console.Write ("Число "+number2+" большее, а число "+number1+" меньшее");
