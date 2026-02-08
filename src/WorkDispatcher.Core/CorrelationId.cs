namespace WorkDispatcher.Core;

public record CorrelationId(string Value) : Id(Value);