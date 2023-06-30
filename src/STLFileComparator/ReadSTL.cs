using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLFileComparator
{
    internal class ReadSTL
    {
        public string[] binario { get; set; }
        public static string[] OpenSTL(string pathSTL)
        {
            ReadSTL openStlFile = new ReadSTL();

            if (File.Exists(pathSTL))
            {
                openStlFile.binario = File.ReadAllLines(pathSTL);
            }
            return openStlFile.binario;
        }
    }
}
