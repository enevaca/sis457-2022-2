// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DemoConsolaAvanzado;
using DemoLibreria;
using static DemoConsolaAvanzado.Delegado;
using Cuadrado = DemoConsolaAvanzado.Cuadrado;

// Biblioteca de clases Net Standar y métodos estáticos
Console.WriteLine($"Suma de 5 y 3 es {Calculadora.sumar(5, 3)}");
Console.WriteLine($"Resta de 5 y 3 es {Calculadora.restar(5, 3)}");

// Delegados
Reverse rev = ReverseString;
Console.WriteLine(rev("un string"));

Func<int, int, int> multiplicacion = (v1, v2) => v1 * v2;
Console.WriteLine(multiplicacion(7, 3));

Predicate<int> esMayorDeEdad = e => e >= 18;
Console.WriteLine(esMayorDeEdad(15));

// Genéricos
Generico<string> cadena = new Generico<string>();
cadena.valor = "Hola SIS457";
//cadena.valor = 5555;


// Clase Abstracta
// Pieza pieza = new Pieza();
Cuadrado cuadrado = new Cuadrado(5);
Console.WriteLine($"Cuadrado de lado 5, área: {cuadrado.area()}, perímetro: {cuadrado.perimetro()}");

// Try Catch Finally
int numero1, numero2;
decimal resultado;
try
{
    Console.WriteLine("Introduzca 2 números a dividirse");
    numero1 = Convert.ToInt32(Console.ReadLine());
    numero2 = Convert.ToInt32(Console.ReadLine());
    resultado = numero1 / numero2;
    Console.WriteLine($"La división de {numero1} entre {numero2} es {resultado}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: No es posible la división por Cero. {ex.Message}");
}
finally 
{
    resultado = 0;
}

// Async / Await
testAsyncAwaitMethod();
Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadLine();

async static void testAsyncAwaitMethod()
{
    await longRunningMethod();
}

static async Task<int> longRunningMethod() 
{
    Console.WriteLine("Iniciando un método de ejecución prolongada...");
    await Task.Delay(5000);
    Console.WriteLine("Finalizando un método de ejecución prolongada...");
    return 1;
}

// Inmutabilidad
class Age 
{
    readonly int year;
    public Age(int year) 
    {
        this.year = year;
    }

    void changeYear() {
        //this.year = 2022;
    }
}

