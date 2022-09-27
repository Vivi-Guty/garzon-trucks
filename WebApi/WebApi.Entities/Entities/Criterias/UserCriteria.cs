
using System.Runtime.Serialization;

namespace WebApi.Entities
{
    [DataContract]
    public class UserCriteria
    {

        [DataMember]
        public string? UserName { get; set; }

        [DataMember]
        public string? LoginName { get; set; }

        [DataMember]
        public string? UserMail { get; set; }

        [DataMember]
        public string? Upi { get; set; }

        [DataMember]
        public int? RoleId { get; set; }

        [DataMember]
        public int? OuId { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public int? CreatedBy { get; set; }

        [DataMember]
        public int? ModifiedBy { get; set; }

        [DataMember]
        public DateTime? CreatedDateFrom { get; set; }

        [DataMember]
        public DateTime? CreatedDateTo { get; set; }

        [DataMember]
        public DateTime? ModifiedDateFrom { get; set; }

        [DataMember]
        public DateTime? ModifiedDateTo { get; set; }
    }
}
