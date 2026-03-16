// Creates a WebApplicationBuilder instance.
// This sets up the application's configuration, logging, and dependency injection container.
var builder = WebApplication.CreateBuilder(args);



// Add/Register services with the dependency injection container.
// This is where we add services like controllers, database contexts, authentication, etc.
builder.Services.AddCarter();

// Builds the WebApplication instance using the configured builder.
// After this step, the application's middleware pipeline can be configured.
var app = builder.Build();

// Configure the HTTP request pipeline.
// Middleware components (like routing, authentication, error handling, etc.) are added here
// to process incoming HTTP requests and outgoing responses.
app.MapCarter();

// Starts the application and begins listening for incoming HTTP requests.
app.Run();
