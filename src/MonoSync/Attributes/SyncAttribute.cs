﻿using System;
using System.Diagnostics;
using System.IO;

namespace MonoSync.Attributes
{
    /// <summary>
    /// Types must be marked with this attribute in order to be synchronized.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class SynchronizableAttribute : Attribute
    {

    }

    /// <summary>
    ///     Properties with this attribute will be synchronized.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SyncAttribute : Attribute
    {
        public SynchronizationBehaviour SynchronizationBehaviour { get; }

        public SyncAttribute(
            SynchronizationBehaviour synchronizationBehaviour = SynchronizationBehaviour.TakeSynchronized)
        {
            SynchronizationBehaviour = synchronizationBehaviour;
        }
    }
}