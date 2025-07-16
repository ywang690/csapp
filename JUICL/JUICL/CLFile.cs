using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JUICL
{
    public class CLFile
    {
        public bool _FileWriteAllLines()
        {
            bool _result = false;
            string fileName = "fileName";
            string[] data = {"data1","data2" };
            File.WriteAllLines(@"fileName.csv",data);
            return _result;
        }
    }
}
