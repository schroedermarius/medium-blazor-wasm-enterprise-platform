using BenjaminAbt.MyDemoPlatform.Engine.Abstractions;

namespace Providers.Status.Engine.Queries;

public record class GetStatusQuery : IQuery<string>;
