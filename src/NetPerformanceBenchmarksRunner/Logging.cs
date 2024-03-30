using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace NetPerformanceBenchmarksRunner;

[SimpleJob(RuntimeMoniker.Net80)]
[MarkdownExporterAttribute.GitHub]
[MemoryDiagnoser]
public class Logging
{
    private ILogger _logger = default!;

    private static readonly Action<ILogger, decimal, int, bool, Exception> _logInformation = LoggerMessage.Define<decimal, int, bool>(
        LogLevel.Information,
        new EventId(1, nameof(Logging)),
        "Information message, {0}, {1}, {2}");

    private static readonly Action<ILogger, bool, char, double, Exception> _logDebug = LoggerMessage.Define<bool, char, double>(
        LogLevel.Debug,
        new EventId(1, nameof(Logging)),
        "Information debug, {0}, {1}, {2}");

    private static readonly Action<ILogger, string, int, double, Exception> _logWarning = LoggerMessage.Define<string, int, double>(
        LogLevel.Warning,
        new EventId(1, nameof(Logging)),
        "Information warning, {0}, {1}, {2}");

    [GlobalSetup]
    public void Setup()
    {
        //var loggerFactory = NullLoggerFactory.Instance;
        //_logger = loggerFactory.CreateLogger<Logging>();
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = loggerFactory.CreateLogger<Logging>();
    }

    [Benchmark]
    public void LogInformation_WithMultipleValueTypes()
    {
        _logger.LogInformation("Information message, {0}, {1}, {2}", 15m, 137, true);
        _logger.LogDebug("Information debug, {0}, {1}, {2}", true, 'o', 150e6d);
        _logger.LogWarning("Information warning, {0}, {1}, {2}", "test", 9, 13.1d);
    }

    [Benchmark]
    public void LoggerMessage_WithMultipleValueTypes()
    {
        _logInformation(_logger, 15m, 137, true, null);
        _logDebug(_logger, true, 'o', 150e6, null);
        _logWarning(_logger, "test", 9, 13.1d, null);
    }
}