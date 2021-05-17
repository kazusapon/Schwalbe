using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schwalbe.Shared.Entities
{
    public class InquiryMethod
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Inquiry> Inquiries { get; set; }
    }
}