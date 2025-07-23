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
        public long _DoubleToInt64Bits(double argument)
        {
            bool _result = false;
            long longValue;
            longValue = BitConverter.DoubleToInt64Bits(argument);

            // Display the resulting long in hexadecimal.
            Console.WriteLine(formatter, argument, longValue);
            return longValue;
        }
        public bool _DoubleToUInt64Bits()
        {
            bool _result = false;
            return _result;
        }
        public bool _GetBytes()
        {
            bool _result = false;
            string FW = "2211";
            byte[] _fw = BitConverter.GetBytes(Convert.ToUInt16(FW, 16));

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
        public bool _Int16BitsToHalf()
        {
            bool _result = false;
            return _result;
        }
        //Int32BitsToSingle
        public bool _Int32BitsToSingle()
        {
            bool _result = false;
            return _result;
        }
        //Int64BitsToDouble
        public bool _Int64BitsToDouble()
        {
            bool _result = false;
            return _result;
        }
        //SingleToInt32Bits
        public bool _SingleToInt32Bits()
        {
            bool _result = false;
            return _result;
        }
        //SingleToUInt32Bits
        public bool _SingleToUInt32Bits()
        {
            bool _result = false;
            return _result;
        }
        //ToBoolean
        public bool _ToBoolean()
        {
            bool _result = false;
            return _result;
        }
        //ToChar
        public bool _ToChar()
        {
            bool _result = false;
            return _result;
        }
        //ToDouble
        public bool _ToDouble()
        {
            bool _result = false;
            return _result;
        }
        //ToHalf
        public bool _ToHalf()
        {
            bool _result = false;
            return _result;
        }
        //ToInt16
        public bool _ToInt16()
        {
            bool _result = false;
            return _result;
        }
        //ToInt32
        public bool _ToInt32()
        {
            bool _result = false;
            return _result;
        }
        //ToInt64
        public bool _ToInt64()
        {
            bool _result = false;
            return _result;
        }
        //ToSingle
        public bool _ToSingle()
        {
            bool _result = false;
            return _result;
        }
        //ToString
        public bool _ToString()
        {
            bool _result = false;
            return _result;
        }
        //ToUInt16
        public bool _ToUInt16()
        {
            bool _result = false;
            return _result;
        }
        //ToUInt32
        public bool _ToUInt32()
        {
            bool _result = false;
            return _result;
        }
        //ToUInt64
        public bool _ToUInt64()
        {
            bool _result = false;
            return _result;
        }
        //TryWriteBytes
        public bool _TryWriteBytes()
        {
            bool _result = false;
            return _result;
        }
        //UInt16BitsToHalf
        public bool _UInt16BitsToHalf()
        {
            bool _result = false;
            return _result;
        }
        //UInt32BitsToSingle
        public bool _UInt32BitsToSingle()
        {
            bool _result = false;
            return _result;
        }
        //UInt64BitsToDouble
        public bool _UInt64BitsToDouble()
        {
            bool _result = false;
            return _result;
        }
    }
}
