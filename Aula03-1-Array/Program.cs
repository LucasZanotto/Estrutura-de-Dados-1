
// Array Unidimensional
int[] numbers;
numbers = new int[5];

// Atribuição de valor direta
// ai índice do vetor

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

// Declaração inicializada 
string[] names = ["Eu", "Tu", "Ele", "Nós", "Vós", "Eles"];

// Exemplo Vetor com os nomes dos meses
string[] months = new string[12];

for (int i = 1; i <= 12; i++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

    string name = firstDay.ToString("MMMM");

    months[i - 1] = name;
}

foreach (string m in months)
{
    Console.WriteLine(m);
}

int[] numeros = new int[100];

for (int i = 0; i < 100; i++)
{
    numeros[i] = i + 1;
}

List<int> listaPares = new List<int>();
List<int> listaImpares = new List<int>();

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        listaPares.Add(numero);
    }
    else
    {
        listaImpares.Add(numero);
    }
}

int[] pares = listaPares.ToArray();
int[] impares = listaImpares.ToArray();

Console.WriteLine("-------------");

Console.WriteLine("numeros pares:");
Console.WriteLine(string.Join(", ", pares));

Console.WriteLine("-------------");

Console.WriteLine("numeros impares:");
Console.WriteLine(string.Join(", ", impares));

Console.WriteLine("-------------");