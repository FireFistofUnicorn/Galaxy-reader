namespace Observer.Data
{
    public interface IRepository
    {
        public ObservationObjects? Objects { get; set; }

        /// <summary>
        /// Прочитать объектЫ
        /// </summary>
        void Init();

        /// <summary>
        /// Сохранить состояние в файл/БД
        /// </summary>
        /// <returns></returns>
        void Update();

        /// <summary>
        /// Добавить объект
        /// </summary>
        bool AddObject(ObservationObject observationObject);

        /// <summary>
        /// Изменить объект
        /// </summary>
        bool UpdateObject(ObservationObject observationObject);

        /// <summary>
        /// Удалить объект
        /// </summary>
        bool DeleteObject(ObservationObject observationObject);
    }
}