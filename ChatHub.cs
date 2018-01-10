using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SimpleChat
{
    public class ChatHub : Hub
    {      
        public async Task Send(string message)
        {
            await Clients.All.InvokeAsync("Send", message);
        }
    }
}
