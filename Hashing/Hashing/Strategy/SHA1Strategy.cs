using System.Text;
using System.Security.Cryptography;

namespace Hashing;

class SHA1Strategy : IHashStrategy
{
    public string ComputeHash(string source)
    {
        byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
        using SHA1 sha1 = SHA1.Create();
        byte[] hashBytes = sha1.ComputeHash(sourceBytes);
        return Convert.ToHexString(hashBytes);
    }

    public override string ToString() => "sha1";
}
