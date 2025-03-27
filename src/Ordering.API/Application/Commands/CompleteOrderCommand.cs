namespace eShop.Ordering.API.Application.Commands;

public record CompleteOrderCommand(int OrderNumber) : IRequest<bool>;

