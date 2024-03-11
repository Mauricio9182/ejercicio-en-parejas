//ejercicio 1
int numeroMayor = int.MinValue; 
int numeroMenor = int.MaxValue; 
int numero;


do
{
    
    Console.WriteLine("Ingrese un numero positivo (o 0 para salir): ");
    numero = int.Parse(Console.ReadLine());

    
    if (numero > numeroMayor)
    {
        numeroMayor = numero;
    }

    
    if (numero < numeroMenor && numero != 0)
    {
        numeroMenor = numero;
    }

} while (numero != 0);


if (numeroMayor != int.MinValue && numeroMenor != int.MaxValue)
{
    Console.WriteLine("El numero mayor ingresado es: {0}", numeroMayor);
    Console.WriteLine("El numero menor ingresado es: {0}", numeroMenor);
}
else
{
    Console.WriteLine("No se ingresaron numeros positivos");
}

// ejercicio 2
string frase;
int numeroPalabras = 0;
int numeroVocales = 0;


Console.WriteLine("Ingrese una frase: ");
frase = Console.ReadLine();


int i = 0;
while (i < frase.Length)
{
   
    if (char.IsWhiteSpace(frase[i]))
    {
        numeroPalabras++;
    }

    
    if (EsVocal(frase[i]))
    {
        numeroVocales++;
    }

    
    i++;
}


if (!char.IsWhiteSpace(frase[frase.Length - 1]))
{
    numeroPalabras++;
}


Console.WriteLine("la frase tiene {0} palabras", numeroPalabras);

Console.WriteLine("La frase tiene {0} vocales", numeroVocales);


bool EsVocal(char caracter)
{
    return "aeiou".Contains(char.ToLower(caracter));
}



//ejercicio 3
string palabra;
bool esPalindromo = true;

Console.WriteLine("Ingrese una palabra: ");
palabra = Console.ReadLine().ToLower();

for (int a = 0; i < palabra.Length / 2; a++)
{
    
    if (palabra[a] != palabra[palabra.Length - 1 - a])
    {
        esPalindromo = false;
        break;
    }
}


if (esPalindromo)
{
    Console.WriteLine("La palabra {0} es un palindromo", palabra);
}
else
{
    Console.WriteLine("La palabra {0} no es un palindromo", palabra);
}
