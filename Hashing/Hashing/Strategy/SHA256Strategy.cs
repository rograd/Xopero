using System.Text;
using System.Security.Cryptography;

namespace Hashing;

class SHA256Strategy : IHashStrategy
{
    public string ComputeHash(string source)
    {
        byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
        using SHA256 sha256 = SHA256.Create();
        byte[] hashBytes = sha256.ComputeHash(sourceBytes);
        return Convert.ToHexString(hashBytes);
    }

    public override string ToString() => "sha256";
}
