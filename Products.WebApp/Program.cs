using Products.WebApp;

var builder = WebApplication.CreateBuilder(args);
StartUp.ConfigureServices(builder.Services);


var app = builder.Build();

StartUp.ConfigureBuilder(app);

app.Run();
