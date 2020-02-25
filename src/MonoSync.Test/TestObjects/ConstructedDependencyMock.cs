using System;
using MonoSync.Attributes;
using MonoSync.SyncTargetObjects;
using PropertyChanged;

namespace MonoSync.Test.TestObjects
{
    [AddINotifyPropertyChangedInterface]
    public class ConstructedDependencyMock
    {
        public ISomeService SomeService { get; }

        [SyncConstructor]
        public ConstructedDependencyMock(ISomeService someService)
        {
            SomeService = someService;
        }
    }

    public class SomeServiceResolver : IDependencyResolver
    {
        public SomeServiceResolver()
        {
            SomeService = new SomeService();
        }

        public SomeService SomeService { get; }

        public object ResolveDependency(Type T)
        {
            if (T == typeof(ISomeService))
                return SomeService;
            throw new Exception($"Service of type {T} not found");
        }
    }

    public interface ISomeService
    {

    }

    public class SomeService : ISomeService
    {

    }
}