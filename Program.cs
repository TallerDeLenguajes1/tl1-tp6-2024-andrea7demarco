
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
//punto1

int number, invertednumb = 0,digit,large;
bool parseBool;
string? input;
Console.WriteLine("Ingrese un numero:\n");

input = Console.ReadLine();


parseBool = int.TryParse(input, out number);
while(number > 0 )
{
  digit = number % 10;
  invertednumb = invertednumb * 10 + digit;
  number/=10;


}

  Console.WriteLine($"numero inv {invertednumb}");










