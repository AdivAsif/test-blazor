namespace BlazorTest.API.Exception;

using System;

public class ApiException : Exception
{
    public ApiException(string message, int status, object test, object test1, object test2)
    {
    }
}

public class ApiException<TResult> : ApiException
{
    public ApiException(string message, int status, object test, object test1, object test2) : base(message, status,
        test, test1, test2)
    {
    }
}