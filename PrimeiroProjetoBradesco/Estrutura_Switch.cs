// Estrutura Switch

Console.WriteLine("Qual a nota você dar para o prato? 0, 5, ou 10");
int.TryParse(Console.ReadLine(), out int nota);

switch (nota)
{
    case 0:
        Console.WriteLine("Comida muito ruim!.");
        break;
    case 5:
        Console.WriteLine("Comida razóavel.");
        break;
    case 10:
        Console.WriteLine("Comida Ótima!!.");
        break;
    default:
        Console.WriteLine("Nota inexistente");
        break;




}