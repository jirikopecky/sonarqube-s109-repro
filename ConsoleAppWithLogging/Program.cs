using ConsoleAppWithLogging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection();
services.AddLogging(builder =>
{
    builder.AddConsole();
});

await using var sp = services.BuildServiceProvider();

var logger = sp.GetRequiredService<ILogger<Program>>();

logger.ProgramStarting();

await Task.Delay(100); // simulate work

logger.ProgramStopping();
