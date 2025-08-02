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
//        AppendAllLines
//        AppendAllLinesAsync
//AppendAllText
//AppendAllTextAsync
//AppendText
//Copy
//Create
//CreateSymbolicLink
//CreateText
//Decrypt
//Delete
//Encrypt
//Exists
//GetAttributes
//GetCreationTime
//GetCreationTimeUtc
//GetLastAccessTime
//GetLastAccessTimeUtc
//GetLastWriteTime
//GetLastWriteTimeUtc
//GetUnixFileMode
//Move
//Open
//OpenHandle
//OpenRead
//OpenText
//OpenWrite
//ReadAllBytes
//ReadAllBytesAsync
//ReadAllLines
//ReadAllLinesAsync
//ReadAllText
//ReadAllTextAsync
//ReadLines
//ReadLinesAsync
//Replace
//ResolveLinkTarget
//SetAttributes
//SetCreationTime
//SetCreationTimeUtc
//SetLastAccessTime
//SetLastAccessTimeUtc
//SetLastWriteTime
//SetLastWriteTimeUtc
//SetUnixFileMode
//WriteAllBytes
//WriteAllBytesAsync
//WriteAllLines
//WriteAllLinesAsync
//WriteAllText
//WriteAllTextAsync
    }
}
