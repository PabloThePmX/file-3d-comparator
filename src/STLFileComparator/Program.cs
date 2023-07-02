using STLFileComparator;
using System.Drawing;

try
{
    string caminhoRef = InputFile.GetPath("ref").STLPath;
    string caminhoComp = InputFile.GetPath("comp").STLPath;

    Console.WriteLine($"\nO caminho de referência é {caminhoRef}, correto?");
    Console.ReadKey();
    Console.WriteLine($"O caminho do objeto a ser comparado é {caminhoComp}, correto?");
    Console.ReadKey();
    ReadSTL readSTL = new ReadSTL(caminhoRef, caminhoComp);

    List<string> pecaRef = readSTL.OpenSTL(caminhoRef);
    List<string> pecaComp = readSTL.OpenSTL(caminhoComp);

    var iguais = pecaRef.SequenceEqual(pecaComp);

    Console.WriteLine("\nSão iguais? " + iguais.ToString());

    foreach(var r in pecaRef)
        Console.WriteLine(r.ToString());
    Console.Write("\n");

    foreach(var c in pecaComp)
        Console.WriteLine(c.ToString());

    Console.ReadKey();
}
catch (Exception e)
{
    Console.Write(e.Message);
    Console.ReadKey();
}