using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de notas: ");
        int n = int.Parse(Console.ReadLine());

        float soma = 0;

        Console.WriteLine($"Digite as {n} notas:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            float nota = float.Parse(Console.ReadLine());
            soma += nota;
        }

        // Média
        float media = soma / n;
        Console.WriteLine($"A média das notas é: {media:F2}");

        // Verifica se o aluno foi aprovado ou reprovado
        if (media >= 7.0)
        {
            Console.WriteLine("Aluno APROVADO!");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO!");
        }
    }
}
