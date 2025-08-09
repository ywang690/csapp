using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUICL
{
    public class WProjects
    {
        #region MOT-BIN
        public bool _MotBin()
        {
            bool _result = false;
            byte[] _header = new byte[] { 0x00,0x00,0x00,0x00,0x90,0x06,0x00,0x00,0x00,0x00,
                                          0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                                          0x05,0x01,0x01,0x01,0x01,0x00,0x40,0x00,0x00,0x00};
            byte[] _bootloaderInfo = new byte[] { 0x11 };
            string _path = "_path";
            //byte[] _fw = new byte[] { 0x11,0x22};
            //byte[] _subFW = new byte[] { 0x33 };
            //byte[] _hw = new byte[] { 0x44 };
            string _message = "";
            bool result = false;
            string FW = "2211";  //1122
            string SUBFW = "33";
            string HW = "44";


            byte[] _fw = BitConverter.GetBytes(Convert.ToUInt16(FW, 16));
            byte[] _subFW = BitConverter.GetBytes(Convert.ToUInt16(SUBFW, 16));
            byte[] _hw = BitConverter.GetBytes(Convert.ToUInt16(HW, 16));
            return _result;
        }

        public bool ConvertMOTtoBIN(byte[] _header, string path, byte[] bootloaderInfo, byte[] fw, byte[] subFW, byte[] hw, ref string message)
        {
            bool _result = false;
            Array.Copy(fw, 0, _header, 23, 2);
            Array.Copy(subFW, 0, _header, 25, 1);
            Array.Copy(hw, 0, _header, 26, 1);

            //byte[] _data = new byte[16] { 0xE8, 0x86, 0x00, 0x00, 0x7F, 0x03, 0x00, 0x00, 0x00, 0x00, 0x52, 0x50, 0x2D, 0x34, 0x38, 0x2D };
            //byte[] _add = new byte[4] { 0x11, 0x22, 0x33, 0x44 };
            //Array.Copy(_add, 0, _data, 3, 2);
            //                        init,Length
            //{ 0xE8, 0x86, 0x00, 0x22,0x33, 0x03, 0x00, 0x00, 0x00, 0x00, 0x52, 0x50, 0x2D, 0x34, 0x38, 0x2D };
            //      

            return _result;
        }
        #endregion

        public byte[] _stringToByte(string[] input, int Len)
        {
            byte[] buf = new byte[Len];
            for (int i = 0; i < Len; i++)
            {
                buf[i] = Convert.ToByte(input[i]);
            }
            return buf;
        }

        public List<double[]> Parse(string filePath, int skipLines)
        {   
            var lines = File.ReadAllLines(filePath);

            var result = new List<double[]>();
            //還沒去除標頭

            foreach (var line in lines.Skip(skipLines))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var fields = line.Split(',');
                int fieldsCnt = fields.Length;
                    var nums = fields
                        .Where(f => !string.IsNullOrWhiteSpace(f))
                        .Select(f => double.Parse(f.Trim()))
                        .ToArray();

                    result.Add(nums);
            }

            return result;
        }

    }
}
