﻿namespace Mlt.Api.Base.Exceptions;

public class NotFoundException : SystemException
{
    public NotFoundException(string message) : base(message) { }

    public NotFoundException(string message, Exception inner) : base(message, inner) { }
}