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

//Calculadora V1

Console.WriteLine("Desea realizar un calculo?");
string resp = Console.ReadLine();
int j = 0;
bool resultado = int.TryParse(resp, out j);

while (resultado && (j != 0))
{
    Console.WriteLine("Ingrese el primer numero");
    string num1 = Console.ReadLine();
    double aux1 = 0;
    double.TryParse(num1, out aux1);

    Console.WriteLine("Ingrese el segundo numero");
    string num2 = Console.ReadLine();
    double aux2 = 0;
    double.TryParse(num2, out aux2);

    Console.WriteLine("Que tipo de calculo (suma, resta, multip o division):");
    string tipoCalculo = Console.ReadLine();

    switch (tipoCalculo)
    {
        case "1":
        double suma = aux1 + aux2;
        Console.WriteLine("Resultado "+suma);
        break;
        case "2":
        double resta = aux1 - aux2;
        Console.WriteLine("Resultado "+resta);
        break;
        case "3":
        double multi = aux1 * aux2;
        Console.WriteLine("Resultado "+multi);
        break;
        default:
        double div = aux1 / aux2;
        Console.WriteLine("Resultado "+div);
        break;
    }
    Console.WriteLine("Desea realizar otro calculo?");
    resp = Console.ReadLine();
    resultado = int.TryParse(resp, out j);
}

