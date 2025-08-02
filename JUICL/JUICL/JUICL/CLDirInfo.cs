using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUICL
{
    public class CLDirInfo
    {
        public bool _GetFilesDI()
        {
            bool _result = false;
            DirectoryInfo di = new DirectoryInfo(@"D:\!Platform\AutoFW\AutoTestPlan\JUICL\JUICL");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi);
            }
            _result = true;
            return _result;
        }
        public bool _DirInfoCreate()
        {
            bool _result = false;
            _result = true;
            return _result; 
        }

        public bool _DirInfoCreateSubdirectory()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _DirInfoCreateDelete()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _EnumerateDirectories()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _EnumerateFiles()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _EnumerateFilesSystemInfos()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _GetDirectories()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _GetFiles()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _GetFilesSystemInfos()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _MoveTo()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        public bool _ToString()
        {
            bool _result = false;
            _result = true;
            return _result;
        }
        //Create
        //CreateSubdirectory
        //Delete
        //EnumerateDirectories
        //EnumerateFiles
        //EnumerateFileSystemInfos
        //GetDirectories
        //GetFiles
        //GetFileSystemInfos
        //MoveTo
        //ToString
    }
}
