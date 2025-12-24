using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace MTG.InventoryManager.Presentation.WebApi.Logging;

internal static class SerilogLoggerConfiguration
{
    public static LoggerConfiguration GetLoggerConfiguration(IHostEnvironment environment)
    {
        var minimumLevel = environment.IsDevelopment()
            ? LogEventLevel.Debug 
            : LogEventLevel.Information;

        var loggerConfig = new LoggerConfiguration()
            .MinimumLevel.Is(minimumLevel)
            .Enrich.WithEnvironmentName()
            .Enrich.WithMachineName()
            .Enrich.WithProcessId()
            .Enrich.WithThreadId()
            .Enrich.WithThreadName();

        loggerConfig.WriteTo
            .Console(
                minimumLevel,
                outputTemplate: "[{Timestamp:HH:mm:ss.zzz} {Level:u3}] {CorrelationId} {SourceContext} {Message:lj}{NewLine}{Exception}",
                theme: AnsiConsoleTheme.Code);
        
        return loggerConfig;
    }
}