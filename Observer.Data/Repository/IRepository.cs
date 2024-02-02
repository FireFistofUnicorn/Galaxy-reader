namespace Observer.Data
{
    public interface IRepository
    {
        public ObservationObjects? Objects { get; set; }

        /// <summary>
        /// ��������� �������
        /// </summary>
        void Init();

        /// <summary>
        /// ��������� ��������� � ����/��
        /// </summary>
        /// <returns></returns>
        void Update();

        /// <summary>
        /// �������� ������
        /// </summary>
        bool AddObject(ObservationObject observationObject);

        /// <summary>
        /// �������� ������
        /// </summary>
        bool UpdateObject(ObservationObject observationObject);

        /// <summary>
        /// ������� ������
        /// </summary>
        bool DeleteObject(ObservationObject observationObject);
    }
}