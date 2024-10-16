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

await Task.Delay(TimeSpan.FromSeconds(1)); // simulate work

logger.ProgramStopping();
