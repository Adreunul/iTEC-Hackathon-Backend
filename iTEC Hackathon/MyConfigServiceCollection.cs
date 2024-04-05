using iTEC_Hackathon.Infrastructure;
using iTEC_Hackathon.Interfaces;
using iTEC_Hackathon.Interfaces.Application;
using iTEC_Hackathon.Interfaces.Endpoint;
using iTEC_Hackathon.Interfaces.Report;
using iTEC_Hackathon.Interfaces.User;
using iTEC_Hackathon.Repositories;
using iTEC_Hackathon.Repositories.Endpoint;
using iTEC_Hackathon.Repositories.Report;



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
            services.AddScoped<IUpdateApplicationRepository, UpdateApplicationRepository>();
            //--------------------------------------------------------------------
            //ENDPOINT
            services.AddScoped<IGetEndpointRepository, GetEndpointRepository>();
            services.AddScoped<IAddEndpointRepository, AddEndpointRepository>();
            services.AddScoped<IDeleteEndpointRepository, DeleteEndpointRepository>();
            //--------------------------------------------------------------------
            //REPORT
            services.AddScoped<IAddReportRepository, AddReportRepository>();
            services.AddScoped<IGetReportRepository, GetReportRepository>();
            services.AddScoped<IDeleteReportRepository, DeleteReportRepository>();

            return services;
        }
    }
}
