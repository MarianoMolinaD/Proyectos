

//Console.WriteLine(getFactorial(5));
Console.WriteLine("El resultado es {0}", getFibonachi(5));


static int getFactorial (int x)
{
    if (x == 0)
    {
        return 1;
    }else
    {
        return getFactorial(x - 1) * x;
    }
}

static int getFibonachi(int x)
{
    if (x == 0 || x==1) return x;
    else return getFibonachi(x-1) + getFibonachi(x-2);
}

static int getIntereses(int capital, int porcentaje, int tiempo) 
{
    if (tiempo == 0) return capital;
    
    else return ;
}

