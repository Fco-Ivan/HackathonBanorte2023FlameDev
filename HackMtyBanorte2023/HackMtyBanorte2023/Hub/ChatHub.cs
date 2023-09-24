using Microsoft.AspNetCore.SignalR;

namespace HackMtyBanorte2023
{
    public class ChatHub : Hub
    {

        public async Task sendMessage(string user, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", "user", message);
        }

    }
}
