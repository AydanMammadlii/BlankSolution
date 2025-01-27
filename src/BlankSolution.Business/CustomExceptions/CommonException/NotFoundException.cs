﻿namespace BlankSolution.Business.CustomExceptions.CommonException;

public class NotFoundException : Exception
{
    public int StatusCode { get; set; }
    public NotFoundException()
    {
    }

    public NotFoundException(string? message) : base(message)
    {
    }

    public NotFoundException(int statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }
}

