﻿
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
//punto1

/*int number, invertednumb = 0,digit,large;
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

*/
//punto 3

string? input, siNoStr;
bool parseoBool;
int siNo;
float a, b,division;


do{
    Console.WriteLine("Ingrese la operacion: ");
    Console.WriteLine("5 - VALOR ABSOLUTO");
    Console.WriteLine("6 - CUADRADO");
    Console.WriteLine("7 - RAIZ CUADRADA");
    Console.WriteLine("8 - SENO");
    Console.WriteLine("9 - COSENO");
    Console.WriteLine("10 - ENTERO DE UN FLOAT");
    input = Console.ReadLine();
    parseoBool = int.TryParse(input, out int operacion);
    if(11>operacion && operacion>=6){
         Console.WriteLine("Ingrese un numero: ");
         parseoBool = float.TryParse(Console.ReadLine(), out  a);

        switch(operacion){
            case 5:
                 Console.WriteLine($"El valor absoluto de {a} es: {Math.Abs(a)}");
                 break;
            case 6:
                 Console.WriteLine($"El cuadrado de {a} es: {Math.Pow(a, 2)}");
                 break;
            case 7:
                if(a < 0) {
                  Console.WriteLine("No se puede calcular");
                  break;
            }

                 Console.WriteLine($"La raiz cuadrada de {a} es: {Math.Sqrt(a)}");
                 break;
            case 8:
                decimal seno = (decimal) Math.Sin(a);
                Console.WriteLine($"El seno de {a} es: {seno}");
                break;
            case 9:
                decimal coseno = (decimal) Math.Cos(a);
                Console.WriteLine($"El coseno de {a} es: {coseno}");
                break;
            case 10:
                Console.WriteLine($"El entero de {a} es: {(int) a}");
                break;
            default:
                Console.WriteLine("El numero ingresado no corresponde a ninguna operación");
                break;
    }

   }



    Console.WriteLine("Quiere seguir operando: SI[1] - NO[0]");
    siNoStr = Console.ReadLine();
    parseoBool = int.TryParse(siNoStr, out siNo);
    
    
}while(siNo == 1);

Console.WriteLine("Finalizacion");










