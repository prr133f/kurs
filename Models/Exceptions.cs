using System;

namespace Buses.Models.Exceptions;

public class NothingToSubmitException : Exception
{
    public NothingToSubmitException(string message) : base(message)
    {
    }
}