using STLFileComparator;
using System.Drawing;

try
{
    Console.WriteLine("Insira o caminho para a peça de referência");
    string caminhoRef = InputFile.GetPath().caminhoSTL;
    string caminhoComp = InputFile.GetPath().caminhoSTL;
    Console.WriteLine($"O caminho de referência é {caminhoRef}, correto?\n");
    Console.ReadKey();
    Console.WriteLine($"O caminho do objeto a ser comparado é {caminhoComp}, correto?\n");
    Console.ReadKey();
}
catch (Exception e)
{
    Console.Write(e.Message);
    Console.ReadKey();
}