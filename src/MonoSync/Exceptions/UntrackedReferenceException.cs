﻿using System;

namespace MonoSync.Exceptions
{
    public class UntrackedReferenceException : Exception
    {
        public object Parent { get; }
        public object UntrackedReference { get; }

        public UntrackedReferenceException(object parent, object untrackedReference) : base(
            $"{parent.GetType().Name}, contains an untracked reference to {untrackedReference.GetType().Name}")
        {
            Parent = parent;
            UntrackedReference = untrackedReference;
        }
    }
}