using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public byte[] OpenSTL(string STLPath)
        {
            byte[] STLbytes = File.ReadAllBytes(STLPath);
            return STLbytes;
        }
    }
}
