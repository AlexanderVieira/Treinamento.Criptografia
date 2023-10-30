using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AVS.Criptography
{
    internal class EncryptionKeyGenerator
    {
        public EncryptionKeyGenerator() { }

        public byte[] Create()
        {
            var random = RandomNumberGenerator.Create();
            var key = new byte[256];
            random.GetBytes(key);

            return key;
        }

        public void PrintKey(byte[] key)
        {
            Console.WriteLine("============== EncryptionKeyGenerator ==============");
            Console.WriteLine();
            Console.WriteLine("Chave: {0}", Convert.ToHexString(key));
            Console.WriteLine();
            Console.WriteLine("============== EncryptionKeyGenerator ==============");
        }
    }
}
