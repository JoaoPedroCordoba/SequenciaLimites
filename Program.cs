int n1, n2, Contador;

Console.Write("Início:");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Fim:");
n2 = Convert.ToInt32(Console.ReadLine());

if (n2 < n1)
{
    Console.WriteLine("Erro");
}

else
{
    Contador = n1;
    while( Contador < n2 )
    {
        Console.WriteLine(Contador);
        Contador = Contador + 1;
    }
}