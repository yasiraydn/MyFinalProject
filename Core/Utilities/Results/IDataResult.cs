using System.Collections;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult, IEnumerable
    {
        T Data { get; }
    }
}