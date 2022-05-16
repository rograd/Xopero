using System.Text;
using System.Security.Cryptography;

namespace Hashing;

class MD5Strategy : IHashStrategy
{
    public string ComputeHash(string source)
    {
        byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
        using MD5 md5 = MD5.Create();
        byte[] hashBytes = md5.ComputeHash(sourceBytes);
        return Convert.ToHexString(hashBytes);
    }
}
