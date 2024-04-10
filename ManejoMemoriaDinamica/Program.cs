unsafe
{

    int nota = 10;

    int* puntero;

    puntero = &nota;

    //Console.WriteLine("La direccion de memoria es {0}", (int)puntero);
    
    //Console.WriteLine("La nota es {0}", puntero ->ToString());

    //Asi se define un arreglo de enteros
    int* Arreglo = stackalloc int[3];

    int valor1 = 100;
    int valor2 = 200;

    Console.WriteLine("valor 1 {0} valor 2 {1}",valor1 , valor2);

    intercambiarValores(&valor1, &valor2);

    Console.WriteLine("valor 1 {0} valor 2 {1}", valor1, valor2);
}
unsafe void intercambiarValores(int* x1, int* x2)
{
    int temporal = *x1;

    *x1 = *x2;
    *x2 = temporal;
}


