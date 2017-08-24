namespace Emigrace.Core
{
    public interface IConfig
    {
        string ConnectionString { get; }
        string Environment { get; }
    }
}