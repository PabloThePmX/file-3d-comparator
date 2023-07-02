using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using QuantumConcepts.Formats.StereoLithography;

namespace STLFileComparator
{
    internal class ReadSTL
    {
        public ReadSTL(params string[] files)
        {
            foreach (var file in files)
            {
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public List<string> OpenSTL(string STLPath)
        {
            STLDocument docBinary = new STLDocument();
            STLDocument docASCII = new STLDocument();

            using (var stream = new FileStream(STLPath, FileMode.Open, FileAccess.Read))
            {
                if (STLDocument.IsBinary(stream))
                    docBinary = STLDocument.Read(stream);
                else
                    docASCII = STLDocument.Read(stream);
            }

            List<string> facetsCollection = new List<string>();

            if (docBinary != null)
            {
                foreach (var f in docBinary.Facets)
                    facetsCollection.Add(f.ToString());
            }

            if (docASCII != null)
            {
                foreach (var f in docASCII.Facets)
                    facetsCollection.Add(f.ToString());
            }

            return facetsCollection;
            
        }
    }
}
