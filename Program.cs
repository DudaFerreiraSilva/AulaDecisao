int n1, n2;

Console.WriteLine("Divisão de dois números");

Console.Write("Digite o primeiro número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
n2 = Convert.ToInt32(Console.ReadLine());

if (n2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Não é possível dividir por zero.");

    Console.ResetColor();
}
else 
{
    double resultado = n1 / n2; 
    Console.Write($"{n1} dividido por {n2} é ");
    
    Console.ForegroundColor = ConsoleColor.Green;
    
     Console.WriteLine($"{resultado}");

    Console.ResetColor();

}
