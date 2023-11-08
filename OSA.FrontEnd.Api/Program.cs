
using OSA.Backend.Api.One.Client;
using OSA.Backend.Api.Two.Client;

namespace OSA.FrontEnd.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Retrieve base addresses from configuration
            var backendOneBaseAddressConfig = builder.Configuration["BackendOneService:OverrideBaseAddress"];
            var backendTwoBaseAddressConfig = builder.Configuration["BackendTwoService:OverrideBaseAddress"];

            // Register BackendOne API client service
            builder.Services.AddBackendOneApiClientService(
                !string.IsNullOrWhiteSpace(backendOneBaseAddressConfig) 
                    ? new Uri(backendOneBaseAddressConfig) 
                    : BackendOneApiClientService.DefaultBaseAddress
            );

            // Register BackendTwo API client service
            builder.Services.AddBackendTwoApiClientService(
                !string.IsNullOrWhiteSpace(backendTwoBaseAddressConfig) 
                    ? new Uri(backendTwoBaseAddressConfig) 
                    : BackendTwoApiClientService.DefaultBaseAddress
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}