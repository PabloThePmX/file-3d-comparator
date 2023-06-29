using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLFileComparator
{
    internal class InputFile
    {
        private string _caminhoSTL;
        
        public string caminhoSTL
        {
            get { return _caminhoSTL; }
            set
            {
                if (string.IsNullOrEmpty(value) || Path.GetExtension(value).ToLower() == "stl")
                    throw new ArgumentException("Caminho Inválido");
                _caminhoSTL = value;
            }
        }
        public static InputFile GetPath()
        {
            InputFile inputFile = new InputFile();

            Console.WriteLine("Caminho STL: ");
            string path = Console.ReadLine();

            inputFile.caminhoSTL = path;

            return inputFile;
        }
    }
}
