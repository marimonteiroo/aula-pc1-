string opcao = "";
 
while (opcao != "4")
{
    Console.WriteLine($"--- Menu ---");
    Console.WriteLine($"1 - icluir");
    Console.WriteLine($"2 - alterar");
    Console.WriteLine($"3 - excluir");
    Console.WriteLine($"4 - sair");
 
    if (opcao == "1")
    {
        Console.WriteLine("um");
    }
    else if (opcao == "2")
    {
        Console.WriteLine("dois");
    }
    else if (opcao == "3")
    {
        Console.WriteLine("tres");
    }
    opcao = Console.ReadLine()!;
}