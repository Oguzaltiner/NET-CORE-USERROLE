﻿namespace CORE.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
