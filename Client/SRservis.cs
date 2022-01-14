using BlazorKursevi.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace BlazorKursevi.Client
{
    public class SRservis
    {
        private HubConnection _predavacHub;
        public HubConnection PredavacHub { get => _predavacHub; }

        public List<Predavac> Predavaci { get; set; } = new();

        public SRservis(NavigationManager nm)
        {
            _predavacHub = new HubConnectionBuilder()
                .WithUrl(nm.BaseUri + "predavacHub")
                .Build();
            _predavacHub.StartAsync();
            _predavacHub.On<List<Predavac>>("evoJe", list => PredavaciSvi(list));

            _predavacHub.SendAsync("DohvatiSvePredavace");
        }

        public void PredavaciSvi(List<Predavac> list)
            => Predavaci = list;
    }
}