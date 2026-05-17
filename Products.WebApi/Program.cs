using Products.WebApi;

var builder = WebApplication.CreateBuilder(args);

StartUp startUp = new StartUp();

startUp.ConfigureServices(builder);

startUp.ConfigureWolverineHost(builder);


var app = builder.Build();

startUp.ConfigureBuilder(app);

app.Run();
