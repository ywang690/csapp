using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JUICL
{
    public class CLBitConverter
    {
        const string formatter = "{0,25:E16}{1,23:X16}";
        public bool _DoubleToInt64Bits(double argument)
        {
            bool _result = false;
            long longValue;
            longValue = BitConverter.DoubleToInt64Bits(argument);

            // Display the resulting long in hexadecimal.
            Console.WriteLine(formatter, argument, longValue);
            return _result;
        }
        public bool _DoubleToUInt64Bits()
        {
            bool _result = false;
            return _result;
        }
        public bool _GetBytes()
        {
            bool _result = false;
            return _result;
        }
        public bool _HalfToInt16Bits()
        {
            bool _result = false;
            return _result;
        }
        //DoubleToInt64Bits
        //DoubleToUInt64Bits
        //GetBytes
        //HalfToInt16Bits
        //HalfToUInt16Bits
        //Int16BitsToHalf
        //Int32BitsToSingle
        //Int64BitsToDouble
        //SingleToInt32Bits
        //SingleToUInt32Bits
        //ToBoolean
        //ToChar
        //ToDouble
        //ToHalf
        //ToInt16
        //ToInt32
        //ToInt64
        //ToSingle
        //ToString
        //ToUInt16
        //ToUInt32
        //ToUInt64
        //TryWriteBytes
        //UInt16BitsToHalf
        //UInt32BitsToSingle
        //UInt64BitsToDouble
    }
}
