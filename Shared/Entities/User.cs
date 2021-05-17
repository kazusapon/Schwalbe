using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schwalbe.Shared.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string LoginId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public byte[] Salt { get; set; }

        public string Token { get; set; }

        public List<Inquiry> Inquiries { get; set; }

        public List<CallHistory> CallHistories { get; set; }
    }
}