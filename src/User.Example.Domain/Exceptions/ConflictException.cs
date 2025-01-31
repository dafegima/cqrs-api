﻿using System;
using System.Globalization;

namespace User.Example.Domain.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException() : base() { }

        public ConflictException(string messages) : base(messages) { }

        public ConflictException(string messages, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, messages, args))
        {
        }
    }
}
