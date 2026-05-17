using Products.Application.Products;
using Scalar.AspNetCore;
using Wolverine;

namespace Products.WebApi
{
    public  class StartUp
    {
        public  void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddHealthChecks();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddOpenApi();

        }

        public void ConfigureWolverineHost(WebApplicationBuilder builder)
        {
            builder.Host.UseWolverine(w =>
            {
                w.Discovery.IncludeAssembly(typeof(Program).Assembly);
                w.Discovery.IncludeAssembly(typeof(GetProductsHandler).Assembly);
            } );
        }

        public  void ConfigureBuilder(WebApplication app)
        {
            app.MapOpenApi();              
            app.MapScalarApiReference();  

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

        }
    }
}
