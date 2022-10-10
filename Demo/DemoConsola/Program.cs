// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Variales
using DemoConsola;

var variable = "Hola Mundo";
bool esActivo = true;
int entero = 5;
double real = 5.6;
float real2 = 5.6f;
char caracter = 'S';
string cadena = "Hola SIS457 2-2022";
DateTime fecha = DateTime.Now;
DateTime fecha2 = new DateTime();

/* Constantes */
const double PI = 3.1416;
const string MATERIA_INFORMATICA = "SIS457";

// Operadores y expresiones
double suma = entero + real;
int modulo = entero % 2;
bool esPar = (modulo == 0);
entero += 2; // entero = entero + 2
entero++; // entero = entero + 1 o entero += 1

// Conversiones y cadenas
Int32 conversionEntero = Convert.ToInt32("6"); // int
Int64 conversionEntero2 = Convert.ToInt64("6"); // bigint
bool conversionBooleana = Convert.ToBoolean("true");

string siglaSis457 = "SIS457";
string detalleSis457 = " Fundamentos de la Programación  ";
string concatenar = $"{siglaSis457} - {detalleSis457.Trim()}";
string concatenar2 = siglaSis457 + " - " + detalleSis457;
string quitarEspcios = detalleSis457.Trim();
string reemplazo = concatenar2.Replace(" ", "#");
string mayusculas = concatenar.ToUpper();
string minusculas = concatenar.ToLower();
string[] separar = concatenar.Split(' ');

// Estructuras de Control
if (entero % 3 == 0) Console.WriteLine($"El valor {entero} es impar");
else if (entero % 2 == 0) Console.WriteLine($"El valor {entero} es par");
else Console.WriteLine($"Else");

string tipo;
var prueba = entero % 2 == 0 ? tipo = "Par" : tipo = "Impar";

int iterador = 1;
while (iterador <= 10)
{
    Console.WriteLine("while: " + iterador);
    if (iterador % 5 == 0) break;
    iterador++;
}

do
{
    Console.WriteLine("do while: " + iterador);
    iterador--;
}
while (iterador > 0);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"for: {i}");
}

// Arreglos
string[] numeros = { "uno", "dos", "tres", "cuatro" };
//for (int i = 0; i < numeros.Length; i++) Console.WriteLine(numeros[i]);
//foreach (string numero in numeros) Console.WriteLine(numero);

/*Console.WriteLine("\nIntroduzca un número:");
int entrada = Convert.ToInt32(Console.ReadLine());
List<string> lista = new List<string>();
for (int i = 0; i < entrada; i++)
{
    Console.WriteLine($"Introduzca el valor de la posición {i}; ");
    lista.Add(Console.ReadLine());
}

foreach (string str in lista) Console.WriteLine(str);
*/
saludar("SIS457");
void saludar(string texto) {
    Console.WriteLine("Hola a tod@s " + texto);
}

Persona persona = new Persona();
persona.cedulaIdentidad = "1234";
persona.nombres = "Juan";
persona.primerApellido = "Pérez";
persona.fechaNacimiento = DateTime.Parse("1995-12-25");
persona.saludar();

Estudiante estudiante = new Estudiante();
estudiante.cedulaIdentidad = "1234";
estudiante.nombres = "Ronald";
estudiante.primerApellido = "Pérez";
estudiante.fechaNacimiento = DateTime.Parse("1995-12-25");
estudiante.carnetUniversitario = "26-5527";
estudiante.saludar();
