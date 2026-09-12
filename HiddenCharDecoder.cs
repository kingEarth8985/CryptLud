using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Text;
using System.Collections.Generic;

namespace CryptLud.Methods.Stego
{
    public static class HiddenCharDecoder
    {
        private const char BIT0 = '\u200B';
        private const char BIT1 = '\u200C';

        public static string Decode(string stego)
        {
            StringBuilder bits = new StringBuilder();

            foreach (char c in stego)
            {
                if (c == BIT0) bits.Append('0');
                else if (c == BIT1) bits.Append('1');
            }

            List<byte> bytes = new List<byte>();
            for (int i = 0; i < bits.Length; i += 8)
            {
                string byteStr = bits.ToString().Substring(i, 8);
                bytes.Add(Convert.ToByte(byteStr, 2));
            }

            return Encoding.UTF8.GetString(bytes.ToArray());
        }
    }
}
