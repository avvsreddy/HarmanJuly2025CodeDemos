
using Microsoft.AspNet.OData.Extensions;

namespace HarmanCoolProductsService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson();
            builder.Services.AddOData(); // for OData

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // Register Swagger
            builder.Services.AddEndpointsApiExplorer(); // required
            builder.Services.AddSwaggerGen();           // required


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                app.UseSwagger();
                app.UseSwaggerUI(); // optional customization below
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(e =>
            {
                e.EnableDependencyInjection();
                e.Select().OrderBy().Filter().Count().MaxTop(100).SkipToken();
            });

            app.MapControllers();

            app.Run();
        }
    }
}
