using DIDemoLib;
using WorkerService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>()
    .AddTransient<IMessages, Messages>();

var host = builder.Build();
host.Run();
