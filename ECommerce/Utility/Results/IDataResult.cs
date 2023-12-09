namespace ECommerce.Utility.Results
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
    }
}
