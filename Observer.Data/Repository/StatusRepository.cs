using System.Net.NetworkInformation;

namespace Observer.Data.Repository
{
    public class StatusRepository : IObservationObjectRepository
    {
        public ObservationObjects? Objects { get; set; }

        public void Update()
        {
            string path = "C:/Users/Burtsev/source/repos/Observer/Observer.Watcher/Models/JsonWrite.json";
            File.WriteAllText(path, ObserverObjectsSerializer.ToJson(Objects ?? throw new ArgumentNullException()));
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool AddObject(ObservationObject observationObject)
        {
            throw new NotImplementedException();
        }

        public bool UpdateObject(ObservationObject observationObject)
        {
            throw new NotImplementedException();
        }

        public bool DeleteObject(ObservationObject observationObject)
        {
            throw new NotImplementedException();
        }
    }
}
