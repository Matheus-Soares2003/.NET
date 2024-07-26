//Tipos de Dados (mais usados)

int numInteiro = 2;                 //(4 bytes)
long numLongInteiro = 2000000;      //(8 bytes) 

float numFloat = 2.5f;              //(4 bytes)
double numDouble = 3.5;             //(8 bytes)
decimal numDecimal = 25.5M;         //(16 bytes)

char caracter = 'a';                //(2 bytes)
string palavra = "Matheus Soares";  //(2 bytes cada caracter)

bool verdadeiro_ou_falso = false;   //(1 byte)

var numero = 5; //"var" vai receber qualquer tipo na instanciação. Nesse exemplo o tipo dessa variável será inteiro (int)
var nome = "Carlos Pereira"; //Nesse caso será string

Console.WriteLine(numero.GetType());
Console.WriteLine(nome.GetType());

//Conversoes de tipos e Cast

//Conversao String para número
    string numeroInt = "5";
    string numeroFloat = "2.5";

    int numeroIntConvertido1 = Convert.ToInt32(numeroInt);
    float numeroFloatConvertido1 = Convert.ToSingle(numeroFloat);

    int numeroIntConvertido2 = int.Parse(numeroInt);
    float numeroFloatConvertido2 = float.Parse(numeroFloat);


//Conversao Número para String
    int n1 = 10;
    float n2 = 3.5f;

    string n1Str = Convert.ToString(n1);
    string n2Str = Convert.ToString(n2);

Console.ReadKey();

