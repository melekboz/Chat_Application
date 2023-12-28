using Microsoft.AspNetCore.SignalR;

namespace Chat_Application.Hubs
{
    //This  handle connections, messages, and events between clients.
    //Implement methods within this class to send/receive messages.
    public class ChatHub : Hub //Server-side
    {
        public async Task SendMessage(string user, string message)
        {
            string currentTime = DateTime.Now.ToString(); // Get the current date and time
            var messageObject = new { user = user, message = message, dateTime = currentTime };
            await Clients.All.SendAsync("ReceiveMessage", messageObject);
        }                                                                               //user, message
    }
}
