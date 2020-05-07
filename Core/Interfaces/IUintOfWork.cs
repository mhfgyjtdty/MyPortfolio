namespace Core.Interfaces
{
    public interface IUintOfWork<T> where T : class
    {
        IGenerricRebository<T> Entity { get; }
        void save();
    }
}
