using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Observer.Data
{
    /// <summary>
    /// ������ �������� ���������� 
    /// </summary>
    public partial class ObservationObjects
    {
        /// <summary>
        /// ������ � ��������� ����������
        /// </summary>
        [JsonProperty("objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObservationObject> Items { get; set; } = new List<ObservationObject>();
    }

    /// <summary>
    /// ������ ����������
    /// </summary>
    public partial class ObservationObject
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        /// <summary>
        /// ������ �������� ���
        /// </summary>
        [JsonProperty("fqdnName", NullValueHandling = NullValueHandling.Ignore)]
        public string FqdnName { get; set; }

        /// <summary>
        /// �������� ��������� �� ������� ��������� ����������
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// ��� ��������� (������� - 1/������ - 2)
        /// </summary>
        [JsonProperty("programmType", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgrammType { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; }

        /// <summary>
        /// ������� �������� ������������ �������
        /// </summary>
        [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsActive { get; set; }

        /// <summary>
        /// ��������� ����, �� �������������
        /// </summary>
        [JsonIgnore]
        public DateTime LastNotifySend { get; set; } = new DateTime();

        /// <summary>
        /// ���������� ������ ����������� ���������, �������� ��� ���(�������� �������) 2 - ���������, 1 - ��� ��������
        /// </summary>
        [JsonProperty("activeStatus", NullValueHandling = NullValueHandling.Ignore)]
        public int ActiveStatus { get; set; }
    }

    public partial class ObservationObject
    {
        public ObservationObject Clone() => (ObservationObject)this.MemberwiseClone();

        public override bool Equals(object? obj)
        {
            if (obj is ObservationObject tempObj)
            {
                if(this.Id != tempObj.Id) return false;
                if(this.FqdnName != tempObj.FqdnName) return false;
                if(this.Name != tempObj.Name) return false;
                if(this.ProgrammType != tempObj.ProgrammType) return false;
                if(this.Message != tempObj.Message) return false;
                if(this.IsActive != tempObj.IsActive) return true;
                if(this.ActiveStatus != tempObj.ActiveStatus) return false;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}