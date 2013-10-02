using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EventRegistration.Models.Domain.Repository;
using Ninject;
using Ninject.Syntax;

namespace EventRegistration.Infrastructure
{
    public class CustomDependencyResolver : IDependencyResolver
    {
        private IKernel ninjectKernel;
        public CustomDependencyResolver()
        {
            ninjectKernel = new StandardKernel();
            AddDefaultBindings();
        }
        public object GetService(Type serviceType)
        {
            return ninjectKernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ninjectKernel.GetAll(serviceType);
        }
        public IBindingToSyntax<T> Bind<T>()
        {
            return ninjectKernel.Bind<T>();
        }
        private void AddDefaultBindings()
        {
            Bind<IRepository>().To<DummyRepository>(); // seems like the only thing that directly references the repository
        }
    }
}