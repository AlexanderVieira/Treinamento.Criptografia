using AVS.Criptography;

// Gerador de Chaves
var gerador = new EncryptionKeyGenerator();
var chave = gerador.Create();
gerador.PrintKey(chave);

// XOR
Console.WriteLine();
Console.WriteLine("============== OneTimePad ==============");
Console.WriteLine();

var mensagem = "fundamentos de criptografia";
var cipher = new OneTimePad(chave, mensagem).ExecuteXor();

Console.WriteLine("Cipher: {0}", Convert.ToHexString(cipher));

Console.WriteLine();
Console.WriteLine("============== OneTimePad ==============");
