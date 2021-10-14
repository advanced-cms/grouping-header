using System.Linq;
using EPiServer.Shell.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace Advanced.CMS.GroupingHeader
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGroupingHeader(this IServiceCollection services)
        {
            services.Configure<ProtectedModuleOptions>(
                pm =>
                {
                    if (!pm.Items.Any(i =>
                        i.Name.Equals("advanced-cms-grouping-header", System.StringComparison.OrdinalIgnoreCase)))
                    {
                        pm.Items.Add(new ModuleDetails() { Name = "advanced-cms-grouping-header" });
                    }
                });

            return services;
        }
    }
}
