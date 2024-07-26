//CONDICIONAIS SIMPLES

Console.Write("Digite um número: ");
double num = Convert.ToInt32(Console.ReadLine());

if (num > 10)
{
    Console.WriteLine($"{num} é maior que 10");
} 
else if (num < 10)
{
    Console.WriteLine($"{num} é menor que 10");
}
else
{
    Console.WriteLine($"{num} é igual a 10");
}
Console.WriteLine("\n\n");


//SWITCH CASE

Console.WriteLine("1 - Somar 5\n" +
    "2 - Subtrair 5\n" +
    "3 - Multiplicar por 5\n" +
    "4 - Dividir por 5");

Console.Write("Opção: ");
int opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        num += 5;
        break;

    case 2:
        num -= 5;
        break;

    case 3:
        num *= 5;
        break;

    case 4:
        num /= 5;
        break;

    default:
        Console.WriteLine("Opção Inválida!");
        break;
}
Console.WriteLine($"\nNum = {num}");

//OPERADORES TERNÁRIOS

Console.Write("\nIdade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(idade >= 18 ? "Maior de Idade" : "Menor de Idade"); //Nesse caso a primeira string será escrita caso idade seja maior ou igual a 18, senão a segunda string será escrita