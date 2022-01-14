using BlazorKursevi.Shared;

namespace BlazorKursevi.Server.Servisi
{
    public class PredavaciServis
    {
        private Db Db { init; get; }

        public PredavaciServis(Db db)
        {
            Db = db;
        }

        public List<Predavac> DajSvePredavace()
            => Db.Predavaci.ToList();
    }
}