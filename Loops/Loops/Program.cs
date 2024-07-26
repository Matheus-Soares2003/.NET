//Loop for

Console.Write("Digite um número para ver sua tabuada: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"{i} x {num} = {i * num}");
}

Console.WriteLine("\nContagem Regressiva: ");

for (int i = 10; i > 0; i--)
{
    Console.Write($"{i} ");
}
Console.Write("0\n");

//Loop While

int numero = 0;
int cont = 0;

while (numero != 999)
{
    Console.Write("Digite um número: (999 para parar) ");
    numero = Convert.ToInt32(Console.ReadLine());
    cont = (numero != 999 ? cont + 1 : cont);
}

Console.WriteLine($"Você digitou {cont} números\n");


int acumulado = 0;
Console.WriteLine("Acumulado inicial = " + acumulado);
while (true) 
{
    Console.Write("Deseja adicionar 1 ao acumulado? (S/N) ");
    string confirmacaoAdd = Console.ReadLine() + ""; //Concatenar uma string vazia no final evita valores nulos para a variável

    if (confirmacaoAdd.ToUpper().StartsWith("N")) { break; } //Um loop while (true) só pode ser parado com um break ou lançando uma exception

    acumulado++;
}

Console.WriteLine("Acumulado final = " + acumulado);

//Loop "DO While"
int contador = 0;
do
{
    Console.Write($"{contador} -> ");
    contador += 2;

}  while (contador < 20);

Console.WriteLine(contador);
Console.ReadKey();

//Ainda há o loop foreach mas esse será mostrado quando eu começar a trabalhar com coleções