using System.Diagnostics.CodeAnalysis;

namespace WorkDispatcher.Core;

// TODO: way to gen deterministic ID?
public record CoreMessage<T>(CorrelationId CorrelationId, Id DeterministicId, DateTime DispatchedAt, T Data);
