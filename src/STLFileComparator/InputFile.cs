using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLFileComparator
{
    internal class InputFile
    {
        private string _STLPath;
        
        public string STLPath
        {
            get { return _STLPath; }
            set
            {
                if (string.IsNullOrEmpty(value) || Path.GetExtension(value).ToLower() != ".stl")
                    throw new ArgumentException("\nCaminho Inválido");
                _STLPath = value;
            }
        }
        public static InputFile GetPath(string tipo)
        {
            InputFile inputFile = new InputFile();

            if (tipo == "ref")
                Console.Write("Insira o caminho para a peça de referência: ");
            else if (tipo == "comp")
                Console.Write("Insira o caminho para a peça a ser comparada: ");

            inputFile.STLPath = Console.ReadLine();

            return inputFile;
        }
    }
}
