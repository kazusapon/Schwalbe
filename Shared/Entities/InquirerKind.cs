using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schwalbe.Shared.Entities
{
    public class InquirerKind
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Inquiry> Inquiries { get; set; }
    }
}