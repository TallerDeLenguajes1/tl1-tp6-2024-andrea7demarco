
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

       string? Cadena, Sub_cadena,Buscada;
        int longitud, posc, long_sub;

        Console.WriteLine("Ingrese texto:");
        Cadena = Console.ReadLine();
        Console.WriteLine("Ingrese texto a buscar:");
        Buscada = Console.ReadLine();
        
        if (Cadena != null && Buscada != null) // Asegúrate de que la cadena no sea nula
        {
            longitud = Cadena.Length;
            Console.WriteLine($"Largo de la cadena: {longitud}");

            Console.WriteLine("Ingresar la posición inicial de la sub cadena:");
            posc = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de la sub cadena:");
            long_sub = int.Parse(Console.ReadLine());

            // Verifica que los valores estén dentro de los límites de la cadena
            if (posc >= 0 && posc + long_sub <= longitud)
            {
                Sub_cadena = Cadena.Substring(posc, long_sub);
                Console.WriteLine($"La subcadena extraída es: {Sub_cadena}");
            }
            else
            {
                Console.WriteLine("La posición inicial y/o la longitud de la subcadena no son válidas.");
            }
            
            int posicion = Cadena.IndexOf(Buscada, StringComparison.OrdinalIgnoreCase);
            if(posicion!= -1)
            {
                Console.WriteLine($"La palabra '{Buscada}' se encuentra\n");
            }
            else 
            {
                Console.WriteLine("La palabra no se encuentra");

            }
            Console.WriteLine("Recorro la cadena con un foreach:\n");
            foreach(char caracter in Cadena )
            {
                Console.Write(caracter);
            }

            string Min = Cadena.ToLower();
            Console.WriteLine($"Minuscula : {Min}\n");
            string May = Cadena.ToUpper();
            Console.WriteLine($"Mayuscula : {May}\n");
            Console.WriteLine("Ingrese el caracter que separa:\n");
            char separa = Console.ReadLine()[0];
            string[] partes = Cadena.Split(separa);
            
            Console.WriteLine("Cadena CORTADA: ");
            foreach( string parte in partes)
            {
                Console.WriteLine(parte);
            }



            
        }
        else
        {
            Console.WriteLine("No se ingresó una cadena válida.");
        }








