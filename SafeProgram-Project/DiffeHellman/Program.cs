using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DiffeHellman
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Alice a = new Alice();

        }
    }
    public class Alice
    {
        public static byte[] alicePublicKey;
        public byte[] aliceKey;
        public Alice()
        {
            
            using (ECDiffieHellmanCng alice = new ECDiffieHellmanCng())
            {
                alice.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                alice.HashAlgorithm = CngAlgorithm.Sha256;
                alicePublicKey = alice.PublicKey.ToByteArray();

                Bob bob = new Bob();
                CngKey k = CngKey.Import(bob.bobPublicKey, CngKeyBlobFormat.EccPublicBlob);
                aliceKey = alice.DeriveKeyMaterial(k);
                Console.WriteLine("Alice Key: " + Convert.ToBase64String(aliceKey));
            }
        }
    }
    public class Bob
    {
        public byte[] bobPublicKey;
        public byte[] bobKey;
        public Bob()
        {
            using (ECDiffieHellmanCng bob = new ECDiffieHellmanCng())
            {

                bob.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                bob.HashAlgorithm = CngAlgorithm.Sha256;
                bobPublicKey = bob.PublicKey.ToByteArray();
               
                bobKey = bob.DeriveKeyMaterial(CngKey.Import(Alice.alicePublicKey, CngKeyBlobFormat.EccPublicBlob));
                Console.WriteLine("Bob key: " + Convert.ToBase64String(bobKey));
            }
        }
    }   
}
