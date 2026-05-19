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

Console.WriteLine("Ingrese un numero");
string num3 = Console.ReadLine();
double aux3 = 0;
double.TryParse(num3, out aux3);

double valorAbs = Math.Abs(aux3);
Console.WriteLine("Valor absoluto: "+valorAbs);

double cuadrado = Math.Pow(aux3, 2);
Console.WriteLine("Numero al Cuadrado: "+cuadrado);

double raizCuadrada = Math.Sqrt(aux3);
Console.WriteLine("Raiz cuadrada: "+raizCuadrada);

double seno = Math.Sin(aux3);
Console.WriteLine("Seno: "+seno);

double cos = Math.Cos(aux3);
Console.WriteLine("Cos: "+cos);

double entero = Math.Truncate(aux3);
Console.WriteLine("Parte entera: "+entero);

Console.WriteLine("Ingrese un numero");
string comparar1 = Console.ReadLine();
double comp1 = 0;
double.TryParse(comparar1, out comp1);

Console.WriteLine("Ingrese un numero");
string comparar2 = Console.ReadLine();
double comp2 = 0;
double.TryParse(comparar2, out comp2);

double max = Math.Max(comp1, comp2);
Console.WriteLine("Maximo: "+max);

double min = Math.Min(comp1, comp2);
Console.WriteLine("Minimo: "+min);