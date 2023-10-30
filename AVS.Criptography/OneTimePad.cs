using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.Criptography
{
    internal class OneTimePad
    {
        public byte[] Key { get; set; }
        public string Mensagem { get; set; }
        public OneTimePad(byte[] key, string mensagem) 
        {
            Key = key;
            Mensagem = mensagem;
        }

        public byte[] ExecuteXor()
        {            
            var mensagem = Encoding.UTF8.GetBytes(Mensagem);
            var length = mensagem.Length;
            var cipher = new byte[length];

            for (int i = 0; i < length; i++)
            {
                //var x = byte.Parse((Key[i] ^ mensagem[i]).ToString());
                //cipher.ToArray().Append(x);]
                cipher[i] = (byte)(Key[i] ^ mensagem[i]);
            }

            return cipher;
        }
    }
}
