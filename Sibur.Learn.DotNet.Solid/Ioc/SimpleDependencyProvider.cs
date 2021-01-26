using System;
using System.Collections.Generic;

namespace Sibur.Learn.DotNet.Solid.Ioc
{
    /// <summary>
    /// Like a IServiceProvider in .NET Core
    /// </summary>
    public class SimpleDependencyProvider
    {
        private readonly Dictionary<Type, object> _container;

        public SimpleDependencyProvider()
        {
            _container = new Dictionary<Type, object>();
        }

        private void Add(Type abstraction, Type implementation)
        {
            if (_container.ContainsKey(abstraction))
                throw new InvalidOperationException(
                    $"Implementation of type {implementation.FullName} already registered as {abstraction.FullName}");

            _container.Add(abstraction, implementation);
        }

        public void AddTransient(Type abstraction, Type implementation)
        {
            Add(abstraction, implementation);
        }

        public void AddScoped(Type abstraction, Type implementation)
        {
            Add(abstraction, implementation);
        }

        public void AddSingleton(Type abstraction, Type implementation)
        {
            Add(abstraction, implementation);
        }

        public TImplementation TryGet<TImplementation>()
        {
            return (TImplementation) _container[typeof(TImplementation)];
        }
    }
}