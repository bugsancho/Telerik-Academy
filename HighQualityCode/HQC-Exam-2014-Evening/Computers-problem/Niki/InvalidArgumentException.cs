﻿namespace ComputersSystem
{
    using System;

    public class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(string message) : base(message)
        {
        }
    }
}