namespace Hashing;

using BCrypt.Net;

class BCryptStrategy : IHashStrategy
{
    public string ComputeHash(string source) => BCrypt.HashPassword(source);
}
