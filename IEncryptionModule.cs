using System;
using System.Collections.Generic;
using System.Text;
using CryptLud.UI;

namespace CryptLud.Methods.Stego
{
    public interface IEncryptionModule
    {
        string Name { get; }

        // What UI elements should appear?
        IEnumerable<UIElementDescriptor> GetUI();

        // Optional: perform encoding/decoding
        string Encode(Dictionary<string, string> inputs);
        string Decode(Dictionary<string, string> inputs);
    }

}
