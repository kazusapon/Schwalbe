using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schwalbe.Shared.Entities
{
    public class Inquiry
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
        
        public int ApplicationId { get; set; }

        public Application Application { get; set; }

        public int InquirerKindId { get; set; }

        public InquirerKind InquirerKind { get; set; }

        public int InquiryMethodId { get; set; }

        public InquiryMethod InquiryMethod { get; set; }

        public int InquiryClassificationId { get; set; }

        public InquiryClassification InquiryClassification { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public bool CompletedFlag { get; set; }

        public bool ApprovalFlag { get; set; }

        public int? RelatedInquiryId { get; set; }

        public int? CallHistoryId { get; set; }

        public CallHistory CallHistory { get; set; }

        public DateTime IncomingDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}