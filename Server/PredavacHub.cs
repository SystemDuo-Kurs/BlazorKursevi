using Microsoft.AspNetCore.SignalR;

namespace BlazorKursevi.Server
{
    public class PredavacHub : Hub
    {
        public void Test()
            => Console.WriteLine("ping :)");
    }
}