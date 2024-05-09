namespace Buses.Exceptions;

public class NothingToSubmitException(string msg) : Exception(msg)
{
}