using Microsoft.AspNetCore.SignalR;

namespace Astrana.Core.SignalRHubs
{
    public class MainHub : Hub
    {
        public async Task SendMessageAsync(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
