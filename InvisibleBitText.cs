using CryptLud.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptLud.Methods.Stego
{
    internal class InvisibleBitText : IEncryptionModule
    {
        public string Name => "Invisible Bit Text";

        public IEnumerable<UIElementDescriptor> GetUI()
        {
            return new List<UIElementDescriptor>
        {
            new UIElementDescriptor { Id="VisibleText", Label="Visible Text", Type=UIElementType.TextBox },
            new UIElementDescriptor { Id="SecretText", Label="Secret Message", Type=UIElementType.TextBox },
            new UIElementDescriptor { Id="EncodeButton", Label="Encode", Type=UIElementType.Button },
            new UIElementDescriptor { Id="DecodeButton", Label="Decode", Type=UIElementType.Button },
            new UIElementDescriptor { Id="OutputText", Label="Output", Type=UIElementType.TextBox }
        };
        }

        public string Encode(Dictionary<string, string> inputs)
        {
            string visible = inputs["VisibleText"];
            string secret = inputs["SecretText"];
            return HiddenCharEncoder.Encode(visible, secret);
        }

        public string Decode(Dictionary<string, string> inputs)
        {
            string encoded = inputs["OutputText"];
            return HiddenCharDecoder.Decode(encoded);
        }
    }

}
