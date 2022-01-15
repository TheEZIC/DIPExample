namespace DIPExample.Injector
{
    public class InjectorDecorator
    {
        InjectorDecorator(IInjectable service)
        {
            AddToInjectableList(service);
        }

        private void AddToInjectableList(IInjectable injectable)
        {
            InjectorManager.AddInjectable(injectable);
        }
    }
}