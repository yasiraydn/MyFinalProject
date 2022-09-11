using System.Collections;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}