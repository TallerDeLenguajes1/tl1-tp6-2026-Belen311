Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

//Ejercicio 1
Console.WriteLine("Ingrese un numero:");
string num = Console.ReadLine();
int i = 0;
int resto = 0;
bool verificarNum = int.TryParse(num, out i);
if (verificarNum)
{
    if (i>0)
    {
        while (i/10 != 0)
        {
            resto = resto*10 + i%10;
            i /= 10;
        }
        resto = resto*10 + i;
        Console.WriteLine("Numero invertido es: "+resto);
    } else {
        Console.WriteLine("Es un numero negativo");
    }
} else {
    Console.WriteLine("No es un numero");
}

