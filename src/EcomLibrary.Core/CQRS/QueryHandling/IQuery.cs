namespace EcomLibrary.Core.CQRS.QueryHandling;

public interface IQuery<out TResponse> : IRequest<TResponse> {}

