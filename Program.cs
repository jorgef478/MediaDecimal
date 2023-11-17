Console.Clear();

Console.Write("Digite a quantidade de numeros a serem exibidos.: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

decimal soma = 0;
decimal numeroMenor = 999999999.99m;
decimal numeroMaior = 999999999.99m;
decimal digitado;
int contador = 0;

while (contador < quantidade)
{
    contador += 1;
    Console.Write($"Número #{contador}: ");
    digitado = Convert.ToDecimal(Console.ReadLine());
    soma = soma + digitado;

    if (contador == 1)
    {
        numeroMaior = digitado;
        numeroMenor = digitado;
    }   

    if (digitado > numeroMaior)
    {
        numeroMaior = digitado;
    }
    if (digitado < numeroMenor)
    {
        numeroMenor = digitado;
    }
}

if (contador > 0)
    {
        decimal media = soma / quantidade;
        Console.WriteLine($"Soma..........: {soma:n2}");
        Console.WriteLine($"Média.........: {media:n2}");
        Console.WriteLine($"Número maior..: {numeroMaior:n2}");
        Console.WriteLine($"Número menor..: {numeroMenor:n2}");
    }
