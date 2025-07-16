using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace JUICL
{
    public class CLArray
    {
        public bool _ArrayCopyTest()
        {
            bool _result = false;
            byte[] _data = new byte[16] { 0xE8, 0x86, 0x00, 0x00, 0x7F, 0x03, 0x00, 0x00, 0x00, 0x00, 0x52, 0x50, 0x2D, 0x34, 0x38, 0x2D };
            byte[] _add = new byte[4] { 0x11, 0x22, 0x33, 0x44 };
            Array.Copy(_add, 0, _data, 3, 2);
            //                        init,Length
            //{ 0xE8, 0x86, 0x00, 0x22,0x33, 0x03, 0x00, 0x00, 0x00, 0x00, 0x52, 0x50, 0x2D, 0x34, 0x38, 0x2D };
            //      
            _result = true;
            return _result;
        }

        public bool _AsReadOnly()
        { 
            bool _result = false;
            return _result;
        }

        public bool _BinarySearch()
        {
            bool _result = false;
            return _result;
        }
        public bool _Clear()
        {
            bool _result = false;
            return _result;
        }

        public bool _Clone()
        {
            bool _result = false;
            return _result;
        }

        public bool _ConstrainedCopy()
        {
            bool _result = false;
            return _result;
        }
        public bool _ConvertAll()
        {
            bool _result = false;
            return _result;
        }
        public bool _Copy()
        {
            bool _result = false;
            return _result;
        }
        public bool _CreateInstance()
        {
            bool _result = false;
            return _result;
        }
        public bool _Empty()
        {
            bool _result = false;
            return _result;
        }
        //ArrayCopy
        //AsReadOnly
        //BinarySearch
        //Clear
        //Clone
        //ConstrainedCopy
        //ConvertAll
        //Copy
        //CopyTo
        //CreateInstance
        //Empty
        //Exists
        //Fill
        //Find
        //FindAll
        //FindIndex
        //FindLast
        //FindLastIndex
        //ForEach
        //GetEnumerator
        //GetLength
        //GetLongLength
        //GetLowerBound
        //GetUpperBound
        //GetValue
        //IndexOf
        //Initialize
        //LastIndexOf
        //Resize
        //Reverse
        //SetValue
        //Sort
        //TrueForAll


    }
}
