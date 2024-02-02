namespace Observer.Data
{
    public interface IObservationObjectRepository<T>
    {
        public T? Elements { get; set; }

        /// <summary>
        /// ��������� ������/�
        /// </summary>
        T Init();

        /// <summary>
        /// ��������� ��������� � ����/��
        /// </summary>
        /// <returns></returns>
        void Update();
    }
}