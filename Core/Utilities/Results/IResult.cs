using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Voidler için api response
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
