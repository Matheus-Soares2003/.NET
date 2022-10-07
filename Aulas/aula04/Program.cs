int[] arrayInteiros = new int[3];

arrayInteiros[0] = 2;
arrayInteiros[1] = 10;
arrayInteiros[2] = 5;

for (int i = 0; i < arrayInteiros.Length; i++){
    Console.WriteLine($"Posição {i} - {arrayInteiros[i]}");
}

foreach (int item in arrayInteiros) {
    Console.WriteLine($"{item}");
}
