using BenjaminAbt.MyDemoPlatform.Engine.Abstractions;
using Microsoft.Extensions.Logging;
using Providers.Status.Engine.Queries;

namespace Providers.Status.Engine;

public class GetStatusQueryHandler : IQueryHandler<GetStatusQuery, string>
{
    private readonly ILogger<GetStatusQueryHandler> _logger;

    public GetStatusQueryHandler(ILogger<GetStatusQueryHandler> logger)
    {
        _logger = logger;
    }

    public Task<string> Handle(GetStatusQuery request, CancellationToken cancellationToken)
    {
        GetStatusQueryHandlerLog.HandleGetStatusQuery(_logger);
        try
        {
            var result = "OK Status Result via Event Dispatcher!";
            GetStatusQueryHandlerLog.HandleGetStatusQuerySuccess(_logger, result);
            return Task.FromResult(result);
        }
        catch (Exception e)
        {
            GetStatusQueryHandlerLog.HandleGetStatusQueryError(_logger, e);
        }

        return Task.FromResult("ERROR");
    }
}

public static partial class GetStatusQueryHandlerLog
{
    [LoggerMessage(1, LogLevel.Information, "GetStatusQueryHandler: Handle GetStatusQuery")]
    public static partial void HandleGetStatusQuery(ILogger logger);

    [LoggerMessage(2, LogLevel.Information, "GetStatusQueryHandler: Handle GetStatusQuery (Result: {Result}) succeeded")]
    public static partial void HandleGetStatusQuerySuccess(ILogger logger, string result);

    [LoggerMessage(3, LogLevel.Error, "GetStatusQueryHandler: Handle GetStatusQuery failed")]
    public static partial void HandleGetStatusQueryError(ILogger logger, Exception e);
}
