using System;
using System.Collections.Generic;

namespace DIPExample.Injector
{
    public static class InjectorManager
    {
        private static List<IInjectable> _injectables = new List<IInjectable>();

        public static void AddInjectable(IInjectable injectable)
        {
            var existedInjectable = _injectables.Find(s => s.Equals(injectable));

            if (existedInjectable == null)
            {
                _injectables.Add(injectable);
            }
        }

        public static T Resolve<T>()
        {
            var injectable = _injectables.Find(s => s is T);

            if (injectable == null)
            {
                throw new InjectableNotFoundException("There is no service");
            }

            return (T)injectable;
        }

        private class InjectableNotFoundException : Exception
        {
            public InjectableNotFoundException(string message)
                : base(message)
            {
            }
        }
    }
}