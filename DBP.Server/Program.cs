var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<TimeEntryService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/time-entries", (TimeEntryService service) => service.GetTimeEntries());

app.Run();
