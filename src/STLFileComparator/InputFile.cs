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
                if (string.IsNullOrEmpty(value) || Path.GetExtension(value).ToLower() != "stl")
                    throw new ArgumentException("Caminho Inválido");
                _STLPath = value;
            }
        }
        public static InputFile GetPath()
        {
            InputFile inputFile = new InputFile();

            Console.WriteLine("Caminho STL: ");
            inputFile.STLPath = Console.ReadLine();

            return inputFile;
        }
    }
}
