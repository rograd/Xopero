namespace Hashing;

class HashFunction
{
    private IHashStrategy _hashStrategy;

    public HashFunction(IHashStrategy hashStrategy)
    {
        _hashStrategy = hashStrategy;
    }

    public string ComputeHash(string source)
    {
        return _hashStrategy.ComputeHash(source);
    }
}