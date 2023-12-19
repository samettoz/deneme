namespace Core.Utility.Results
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
    }
}
