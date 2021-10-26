using Microsoft.Extensions.DependencyInjection;

namespace CORE.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
