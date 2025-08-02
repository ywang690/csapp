using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JUICL
{
    public class CLString
    {
        //        Clone
        //        Compare
        //CompareOrdinal
        //CompareTo
        //Concat
        //Contains
        //Copy
        //CopyTo
        //Create
        //EndsWith
        public bool _Clone()
        {
            bool _result = false;
            return _result;
        }
        public bool _Compare()
        {
            bool _result = false;
            return _result;
        }

        public bool _CompareOrdinal()
        {
            bool _result = false;
            return _result;
        }
        public bool _CompareTo()
        {
            bool _result = false;
            return _result;
        }
        public bool _Concat()
        {
            bool _result = false;
            return _result;
        }

        public bool _Contains()
        {
            bool _result = false;
            return _result;
        }
        public bool _Copy()
        {
            bool _result = false;
            return _result;
        }
        public bool _Create()
        {
            bool _result = false;
            return _result;
        }
        public bool _EndsWith()
        {
            bool _result = false;
            return _result;
        }

        //EnumerateRunes
        public bool _EnumerateRunes()
        {
            bool _result = false;
            return _result;
        }
        //Equals
        public bool _Equals()
        {
            bool _result = false;
            return _result;
        }
        //Format
        public bool _Format()
        {
            bool _result = false;
            return _result;
        }
        //GetEnumerator
        public bool _GetEnumerator()
        {
            bool _result = false;
            return _result;
        }
        //GetHashCode
        public bool _GetHashCode()
        {
            bool _result = false;
            return _result;
        }
        //GetPinnableReference
        public bool _GetPinnableReference()
        {
            bool _result = false;
            return _result;
        }
        //GetTypeCode
        public bool _GetTypeCode()
        {
            bool _result = false;
            return _result;
        }
        //IndexOf
        public bool _IndexOf()
        {
            bool _result = false;
            return _result;
        }
        //IndexOfAny
        public bool _IndexOfAny()
        {
            bool _result = false;
            return _result;
        }
        //Insert
        public bool _Insert()
        {
            bool _result = false;
            return _result;
        }
        //Intern
        public bool _Intern()
        {
            bool _result = false;
            return _result;
        }
        //IsInterned
        public bool _IsInterned()
        {
            bool _result = false;
            return _result;
        }
        //IsNormalized
        public bool _IsNormalized()
        {
            bool _result = false;
            return _result;
        }
        //IsNullOrEmpty
        public bool _IsNullOrEmpty()
        {
            bool _result = false;
            return _result;
        }
        //IsNullOrWhiteSpace
        public bool _IsNullOrWhiteSpace()
        {
            bool _result = false;
            return _result;
        }
        //Join
        public bool _Join()
        {
            bool _result = false;
            return _result;
        }
        //LastIndexOf
        public bool _LastIndexOf()
        {
            bool _result = false;
            return _result;
        }
        //LastIndexOfAny
        public bool _LastIndexOfAny()
        {
            bool _result = false;
            return _result;
        }
        //Normalize
        public bool _Normalize()
        {
            bool _result = false;
            return _result;
        }
        //PadLeft
        public bool _PadLeft() //傳回指定之長度的新字串，其中目前字串的開頭將以空白和或指定的 Unicode 字元填補。
        {
            bool _result = false;
            string str = "forty-two";
            char pad = '.';
            Console.WriteLine(str.PadLeft(15, pad));
            Console.WriteLine(str.PadLeft(2, pad));
            // The example displays the following output:
            //       ......forty-two
            //       forty-two
            return _result;
        }
        //PadRight
        public bool _PadRight() //傳回指定之長度的新字串，其中目前字串的結尾將以空白和或指定的 Unicode 字元填補。
        {
            bool _result = false;
            string str;
            str = "BBQ and Slaw";

            Console.Write("|");
            Console.Write(str.PadRight(15));
            Console.WriteLine("|");       // Displays "|BBQ and Slaw   |".

            Console.Write("|");
            Console.Write(str.PadRight(5));
            Console.WriteLine("|");       // Displays "|BBQ and Slaw|".
            return _result;
        }
        //Remove
        public bool _Remove()
        {
            bool _result = false;
            return _result;
        }
        //Replace
        public bool _Replace()
        {
            bool _result = false;
            return _result;
        }
        //ReplaceLineEndings
        public bool _ReplaceLineEndings()
        {
            bool _result = false;
            return _result;
        }
        //Split
        public bool _Split()
        {
            bool _result = false;
            return _result;
        }
        //StartsWith
        public bool _StartsWith()
        {
            bool _result = false;
            return _result;
        }
        //Substring
        public bool _Substring()
        {
            bool _result = false;
            return _result;
        }
        //ToCharArray
        public bool _ToCharArray()
        {
            bool _result = false;
            return _result;
        }
        //ToLower
        public bool _ToLower()
        {
            bool _result = false;
            return _result;
        }
        //ToLowerInvariant
        public bool _ToLowerInvariant()
        {
            bool _result = false;
            return _result;
        }
        //ToString
        public string _ToString(Int16 _input)
        {
            string _output = _input.ToString();
            return _output;
        }
        public string _ToStringHex(Int16 _input)
        {
            string _output = _input.ToString("X");
            return _output;
        }
        //ToUpper
        public bool _ToUpper()
        {
            bool _result = false;
            return _result;
        }
        //ToUpperInvariant
        public bool _ToUpperInvariant()
        {
            bool _result = false;
            return _result;
        }
        //Trim
        public bool _Trim()
        {
            bool _result = false;
            return _result;
        }
        //TrimEnd
        public bool _TrimEnd()
        {
            bool _result = false;
            return _result;
        }
        //TrimStart
        public bool _TrimStart()
        {
            bool _result = false;
            return _result;
        }
        //TryCopyTo
        public bool _TryCopyTo()
        {
            bool _result = false;
            return _result;
        }


        //        Clone
        //        Compare
        //CompareOrdinal
        //CompareTo
        //Concat
        //Contains
        //Copy
        //CopyTo
        //Create
        //EndsWith
        //EnumerateRunes
        //Equals
        //Format
        //GetEnumerator
        //GetHashCode
        //GetPinnableReference
        //GetTypeCode
        //IndexOf
        //IndexOfAny
        //Insert
        //Intern
        //IsInterned
        //IsNormalized
        //IsNullOrEmpty
        //IsNullOrWhiteSpace
        //Join
        //LastIndexOf
        //LastIndexOfAny
        //Normalize
        //PadLeft
        //PadRight
        //Remove
        //Replace
        //ReplaceLineEndings
        //Split
        //StartsWith
        //Substring
        //ToCharArray
        //ToLower
        //ToLowerInvariant
        //ToString
        //ToUpper
        //ToUpperInvariant
        //Trim
        //TrimEnd
        //TrimStart
        //TryCopyTo
    }
}
