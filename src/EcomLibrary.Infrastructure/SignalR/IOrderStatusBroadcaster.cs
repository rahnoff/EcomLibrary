namespace EcomLibrary.Infrastructure.SignalR;

public interface IOrderStatusBroadcaster
{
    Task UpdateOrderStatus(UpdateOrderStatusRequest request);
}
