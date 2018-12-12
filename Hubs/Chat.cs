using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRSample
{

    public class Chat : Hub
    {      
        public async Task Send(string nick, string message)
        {
            await Clients.All.SendAsync("Send", nick, message);
        }
    }
}