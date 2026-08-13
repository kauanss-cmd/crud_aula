using System.Collections.Generic;
using crud;

List<Cliente> clientes = new List<Cliente>();
int i=0;

do
{
    Console.WriteLine("\n1 criar cliente");
    Console.WriteLine("2 editar cliente");
    Console.WriteLine("3 excluir cliente");
    Console.WriteLine("4 listar cliente");
    Console.WriteLine("5 sair");
    string opcao = Console.ReadLine();
    i = int.Parse(opcao);


    if (i == 1)
    {
        Cliente cliente1 = new Cliente();
        Console.WriteLine("criando cliente");


        Console.WriteLine("Digite o ID:");
        cliente1.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Nome:");
        cliente1.Nome = Console.ReadLine();
        clientes.Add(cliente1);

    }

    if (i==2)
    {
        
    }

    if (i == 4)
    {
        Console.WriteLine("Listando clientes:\n");
        foreach (Cliente c in clientes)
        {
            Console.WriteLine($"ID: {c.Id} | Nome: {c.Nome}");
        }
    }



}
while (i !=5 );