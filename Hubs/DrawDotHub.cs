using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalrChat.Hubs
{
    public class DrawDotHub : Hub
    {
        public async Task UpdateCanvas(int x, int y, string color)
        {
            await Clients.All.SendAsync("updateDot", x, y, color);
        }

        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }

}