using System;
using DIPExample.Injector;

namespace DIPExample.Animals
{
    public abstract class Animal : IInjectable
    {
        protected abstract string Sound { get; }
        
        public void Execute()
        {
            Console.WriteLine($"Animal says {Sound}");
        }
    }
}