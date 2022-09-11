namespace Core.Utilities.Results
{
    
    //temel voidler için bunu yaptık
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
        
    }
}