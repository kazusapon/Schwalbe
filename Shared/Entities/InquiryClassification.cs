using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schwalbe.Shared.Entities
{
    public class InquiryClassification
    {
        [Key]
        public int Id { get; set; }

        public int Name { get; set; }

        public List<Inquiry> Inquiries { get; set; }
    }
}