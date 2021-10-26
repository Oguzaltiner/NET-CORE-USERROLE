using CORE.Utilities.Results.Abstract;

namespace CORE.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {

            this.Message = message;
        }
        public Result(bool success)
        {
            this.Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
