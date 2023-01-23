Console.WriteLine("Iniciando QUESTAO 02 \nEscreva um algoritmo de ordenação\n");

List<int> num = new List<int>();
Console.WriteLine("Informe numeros separados por espaço");

var input = Console.ReadLine();
var nums = input.Split(" ");

foreach (var n in nums)
    num.Add(int.Parse(n));
Sort(num);

Console.WriteLine("Lista:");
Console.WriteLine(String.Join(", ", num));

void Sort(List<int> numeros)
{
    int i, j, count;
    for (i = 1; i < numeros.Count; i++)
    {
        count = numeros[i];
        j = i - 1;
        while (j >= 0 && numeros[j] > count)
        {
            numeros[j + 1] = numeros[j];
            j--;
        }
        numeros[j + 1] = count;
    }
}
Console.Read();