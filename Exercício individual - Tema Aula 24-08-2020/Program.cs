using System;

namespace POO_26_08_2020
{
    public class CalculaIdade
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new Pessoas();
            Console.WriteLine("Insira os dados da pessoa 1;");
            Console.WriteLine();
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.Write("Salario: ");
            pessoa1.salario = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Pessoas pessoa2 = new Pessoas();
            Console.WriteLine("Agora, insira os dados da pessoa 2;");
            Console.WriteLine();
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.Write("Salario: ");
            pessoa2.salario = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int media = ((pessoa1.salario + pessoa2.salario) / 2);

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome + " é o mais velho(a) das duas pessoas.");
            }
            else
            {
                Console.WriteLine(pessoa2.nome + " é mais velho(a) das duas pessoas.");
            }

            Console.WriteLine("A media salarial desses funcionarios é " + media);

            Console.ReadKey();
        }
    }
}
