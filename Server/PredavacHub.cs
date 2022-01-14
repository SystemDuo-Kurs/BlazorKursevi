using BlazorKursevi.Server.Servisi;
using Microsoft.AspNetCore.SignalR;

namespace BlazorKursevi.Server
{
    public class PredavacHub : Hub
    {
        private PredavaciServis PredavaciServis { init; get; }

        public PredavacHub(PredavaciServis predavaciServis)
        {
            PredavaciServis = predavaciServis;
        }

        public async Task DohvatiSvePredavace()
        {
            await Clients.Caller.SendAsync("evoJe", PredavaciServis.DajSvePredavace());
        }
    }
}