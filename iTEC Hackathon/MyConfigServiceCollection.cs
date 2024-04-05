using iTEC_Hackathon.Infrastructure;
using iTEC_Hackathon.Interfaces;
using iTEC_Hackathon.Repositories;


namespace iTEC_Hackathon
{
    public static class MyConfigServiceCollection
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();
            //--------------------------------------------------------------------
            //USER
            services.AddScoped<ILoginUserRepository, LoginUserRepository>();
            services.AddScoped<IRegisterUserRepository, RegisterUserRepository>();

            //--------------------------------------------------------------------
            //APPLICATION
            services.AddScoped<IAddApplicationRepository, AddApplicationRepository>();
            services.AddScoped<IDeleteApplicationRepository, DeleteApplicationRepository>();
            services.AddScoped<IGetApplicationRepository, GetApplicationRepository>();

            return services;
        }
    }
}
