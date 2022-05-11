namespace Hashing;

class HashAlgorithm
{
    private IHashStrategy _hashStrategy;

    public HashAlgorithm(IHashStrategy hashStrategy)
    {
        _hashStrategy = hashStrategy;
    }

    public string ComputeHash(string source)
    {
        return _hashStrategy.ComputeHash(source);
    }
}
