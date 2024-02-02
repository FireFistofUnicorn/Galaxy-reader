
namespace Observer.Data.Repository
{
    public interface IStatusRepository
    {
        public ObservationObjects? Status { get; set; }
        /// <summary>
        /// Записать объекты в json файл
        /// </summary>
        void Writer();
        /// <summary>
        /// Обновить данные в json файле
        /// </summary>
        void Update();
    }
}
