// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

char[] PILA;
char[] PILA2;
int TOPE = 0;
int contador = 0;


Console.WriteLine("Ingrese la Operacion que infija \n\n");

String operacion;


operacion = Console.ReadLine();

PILA2 = new char[2];

PILA = operacion.ToCharArray();

foreach (char c in PILA)
{
    contador++;
    if (c != '+')
    {
        apilar('+');
        desapilar(contador, '+');
    }
}

Console.WriteLine("{0}{1}+", PILA[0], PILA[2]);



bool pilaVacia() => TOPE == 0;
bool pilaLlena() => TOPE >= TOPE;

void apilar(char valor)
{
    if (pilaLlena()) return;

    PILA2[0] = valor;

    TOPE++;
}
void desapilar(int cont, char valor)
{
    if (pilaVacia()) return;

    PILA[cont] = valor;
    
}
