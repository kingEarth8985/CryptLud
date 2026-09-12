using System;
using System.Text;

namespace CryptLud.Methods.Stego
{
    public static class HiddenCharEncoder
    {
        private const char BIT0 = '\u200B'; // zero-width space
        private const char BIT1 = '\u200C'; // zero-width non-joiner

        public static string Encode(string visible, string secret)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(secret);
            StringBuilder hiddenBits = new StringBuilder();

            foreach (byte b in bytes)
            {
                for (int i = 7; i >= 0; i--)
                {
                    bool bit = ((b >> i) & 1) == 1;
                    hiddenBits.Append(bit ? BIT1 : BIT0);
                }
            }

            return visible + hiddenBits.ToString();
        }
    }
}
