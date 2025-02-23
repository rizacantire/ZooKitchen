using Microsoft.Extensions.DependencyInjection;

namespace ZooKitchen.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // AutoMapper'ı servis olarak kaydediyoruz.
            services.AddAutoMapper(typeof(ApplicationServiceRegistration).Assembly);

            return services;
        }
    }
}
