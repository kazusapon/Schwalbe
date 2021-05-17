using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schwalbe.Shared.Entities
{
    public class CallHistory
    {
        [Key]
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string InquirerName { get; set; }

        public string TelephoneNo { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }

        public DateTime IncomingDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}