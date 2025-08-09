using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace JUICL
{
    public class UICL
    {
        public bool PrintString(string _data)
        {
            bool _result = false;
            Console.WriteLine(_data);
            _result = true;
            return _result;
        }

        public string _DateTime()
        {
            string _DateTimeValue = "";
            DateTime _DateTime = DateTime.Now;
            _DateTimeValue = _DateTime.ToString();
            return _DateTimeValue;
        }

        public string _DateTimeTwentyFour()
        {
            string _DateTimeTF = "";
            DateTime _DTTF = DateTime.Now;
            _DateTimeTF = _DTTF.ToString("yyyy-MM-dd HH:mm");
            return _DateTimeTF;
        }

        public int Default_Length = 1000;
        public int Default_Width = 900;

        public bool _bitWiseA()
        {
            bool _result = false;
            bool a = true;
            bool b = false;

            // 轉成 int 做位元 AND 運算
            int result = Convert.ToInt32(a) & Convert.ToInt32(b);
            bool final = Convert.ToBoolean(result);

            Console.WriteLine(final); // 輸出 False
            _result = true;
            return _result;
        }

        public bool _bitWiseOR()
        {
            bool _result = false;
            bool b1 = true;
            bool b2 = false;
            bool b3 = true;

            // 將三個 bool 結果合併成一個 int
            int mask = (Convert.ToInt32(b1) << 0) |
                       (Convert.ToInt32(b2) << 1) |
                       (Convert.ToInt32(b3) << 2);

            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(8, '0'));  // 00000101
            _result = true;
            return _result;
        }

        public byte[] DecToAscii(string Input)
        {
            byte[] _dataAscii = new byte[2];

            ASCIIEncoding ascii = new ASCIIEncoding();
            Byte[] bytes = ascii.GetBytes(Input);

            foreach (byte _data in bytes)
            {
                Console.WriteLine(_data);
            }

            return _dataAscii;
        }

        public string AppliedOpenFileDialog(string title = "選擇檔案", string filter = "All files (*.*)|*.*")
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = title;
            dialog.Filter = filter;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

    }
}
