using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Data.repository
{
    public class SettingsRepository<T> : IObservationObjectRepository<T> where T : new()
    {
        public string FilePath { get; set; } = String.Empty;
        public T? Elements { get; set; }
        
        public SettingsRepository(string path) => this.FilePath = path;


        public T Init()
        {
            if (string.IsNullOrEmpty(FilePath))
                throw new Exception("Wrong path to file");

            if (File.Exists(FilePath) == false)
                throw new Exception("File not found");

            this.Elements = ObserverObjectsSerializer<T>.FromJson(File.ReadAllText(this.FilePath)) ?? new T();

            return this.Elements;
        }

        public void Update()
        {
            if (string.IsNullOrEmpty(FilePath))
                throw new Exception("Wrong path to file");

            if (File.Exists(FilePath) == false)
                throw new Exception("File not found");

            File.WriteAllText(FilePath, ObserverObjectsSerializer<T>.ToJson(Elements ?? new T()));
        }
    }
}
