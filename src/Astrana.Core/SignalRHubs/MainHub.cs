using Microsoft.AspNetCore.SignalR;

namespace Astrana.Core.SignalRHubs
{
    public class MainHub : Hub
    {
        public async Task SendMessageAsync(string data)
        {
            await Clients.All.SendAsync("ReceiveMessage", data);
        }
    }
}
