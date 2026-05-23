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

double suma, resta, multi, div;

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

    string numero1 = aux1.ToString();
    string numero2 = aux2.ToString();

    switch (tipoCalculo)
    {
        case "1":
        suma = aux1 + aux2;
        Console.WriteLine("Resultado "+suma);
        Console.WriteLine($"La suma de {numero1} y de {numero2} es igual a: {suma.ToString()}");
        break;
        case "2":
        resta = aux1 - aux2;
        Console.WriteLine("Resultado "+resta);
        Console.WriteLine($"La resta de {numero1} y de {numero2} es igual a: {resta.ToString()}");
        break;
        case "3":
        multi = aux1 * aux2;
        Console.WriteLine("Resultado "+multi);
        Console.WriteLine($"La multiplicacion de {numero1} y de {numero2} es igual a: {multi.ToString()}");
        break;
        default:
        div = aux1 / aux2;
        Console.WriteLine("Resultado "+div);
        Console.WriteLine($"La division de {numero1} y de {numero2} es igual a: {div.ToString()}");
        break;
    }
    Console.WriteLine("Desea realizar otro calculo?");
    resp = Console.ReadLine();
    resultado = int.TryParse(resp, out j);
}

//Calculadora V2
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

//Ejercicio 4
Console.WriteLine("Ingrese un texto:");
string texto = Console.ReadLine();
int longitud = texto.Length;
Console.WriteLine($"Longitud del texto: {longitud}");

Console.WriteLine("Ingrese otro texto:");
string texto2 = Console.ReadLine();

Console.WriteLine($"Textos concatenados: {texto}{texto2}");

string subCadena = texto.Substring(2);

Console.WriteLine($"Cadena extraida: {subCadena}");

foreach (char item in texto)
{
    Console.WriteLine(item);
}

Console.WriteLine("Ingrese la palabra a buscar: ");
string buscar = Console.ReadLine();

int indice = texto.IndexOf(buscar);

if (indice != -1)
{
    Console.WriteLine("Se encontro");
}

string mayus = texto.ToUpper();
string minus = texto.ToLower();

Console.WriteLine(mayus);
Console.WriteLine(minus);

string []textoDiv = texto.Split("@");

foreach (string palabra in textoDiv)
{
    Console.WriteLine(palabra);
}

Console.WriteLine("Ingrese una operacion: ");
string operacion = Console.ReadLine();

int var1, var2;


foreach (char signo in operacion)
{
    switch (signo)
    {
        case '+':
        string []op = operacion.Split('+');
        var1 = int.Parse(op[0]);
        var2 = int.Parse(op[1]);
        suma = var1 + var2;
        Console.WriteLine(suma);
        break;
        case '-':
        string []ope = operacion.Split('-');
        var1 = int.Parse(ope[0]);
        var2 = int.Parse(ope[1]);
        resta = var1 + var2;
        Console.WriteLine(resta);
        break;
        case '*':
        string []oper = operacion.Split('*');
        var1 = int.Parse(oper[0]);
        var2 = int.Parse(oper[1]);
        multi = var1 * var2;
        Console.WriteLine(multi);
        break;
        case '/':
        string []opera = operacion.Split('/');
        var1 = int.Parse(opera[0]);
        var2 = int.Parse(opera[1]);
        div = var1 / var2;
        Console.WriteLine(div);
        break;
    }
}