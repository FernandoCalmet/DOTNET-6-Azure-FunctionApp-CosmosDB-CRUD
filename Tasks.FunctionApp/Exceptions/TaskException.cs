﻿using System;

namespace Tasks.FunctionApp.Exceptions;

public class TaskException : Exception
{
    public TaskException() { }

    public TaskException(string message) : base(message) { }

    public TaskException(string message, Exception innerException) : base(message, innerException) { }
}
