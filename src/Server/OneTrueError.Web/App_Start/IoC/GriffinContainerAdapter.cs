﻿using System;
using System.Collections.Generic;
using System.Linq;
using Griffin.Container;

namespace OneTrueError.Web.IoC
{
    public class GriffinContainerAdapter : IContainer
    {
        private readonly IParentContainer _container;

        public GriffinContainerAdapter(IParentContainer container)
        {
            _container = container;
        }

        public TService Resolve<TService>()
        {
            return (TService)_container.Resolve(typeof(TService));
        }

        public object Resolve(Type service)
        {
            return _container.Resolve(service);
        }

        public IEnumerable<TService> ResolveAll<TService>()
        {
            return _container.ResolveAll(typeof(TService)).Cast<TService>();
        }

        public IEnumerable<object> ResolveAll(Type service)
        {
            return _container.ResolveAll(service);
        }

        public IContainerScope CreateScope()
        {
            return new GriffinContainerScopeAdapter(_container.CreateChildContainer());
        }
    }
}