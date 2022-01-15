using System;
using System.Collections.Generic;
using DIPExample.Animals;
using DIPExample.Injector;

namespace DIPExample
{
    class Program
    {
        private static void InitInjectables()
        {
            InjectorManager.AddInjectable(new Cat());
            InjectorManager.AddInjectable(new Dog());
        }
        
        static void Main(string[] args)
        {
            InitInjectables();

            var animals = new List<Animal>()
            {
                InjectorManager.Resolve<Cat>(),
                InjectorManager.Resolve<Dog>(),
            };

            foreach (var animal in animals)
            {
                animal.Execute();
            }
        }
    }
}