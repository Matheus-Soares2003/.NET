using aula03.models;

Calculadora calc = new Calculadora();

//Operações Simples
Console.WriteLine("\n");
calc.Somar(10, 30);
calc.Subtrair(45, 25);
calc.Multiplicar(10, 2);
calc.Dividir(25, 5);
calc.Pot(4, 2);
calc.RaizQuadrada(2);

//Operações Trigonométricas
Console.WriteLine("\n");
calc.Seno(60);
calc.Cosseno(60);
calc.Tangente(60);