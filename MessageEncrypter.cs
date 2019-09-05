using System.Security.Cryptography;
using System.Text;

namespace BoundarySeparationProject
{
    class MessageEncrypter
    {
        private readonly ILineReader lineReader;
        private readonly ILineWriter lineWriter;

        public MessageEncrypter(ILineReader lineReader, ILineWriter lineWriter)
        {
            this.lineReader = lineReader;
            this.lineWriter = lineWriter;
        }

        public bool EncryptMessage()
        {
            var sb = new StringBuilder();
            var inputString = lineReader.ReadLine();
            var isEmptyString = string.IsNullOrWhiteSpace(inputString);

            if (!isEmptyString)
            {
                foreach (byte b in GetHash(inputString)) sb.Append(b.ToString("X2"));

                lineWriter.WriteLine(sb.ToString());
            }

            return isEmptyString;
        }

        private byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();

            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
    }
}
