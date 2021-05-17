using System;
using Microsoft.EntityFrameworkCore;
using Schwalbe.Shared.Entities;

namespace Schwalbe.Server.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }

        public DbSet<CallHistory> CallHistories { get; set; }

        public DbSet<Inquiry> Inquiries { get; set; }

        public DbSet<InquirerKind> InquirerKinds { get; set; }

        public DbSet<InquiryClassification> InquiryClassifications { get; set; }

        public DbSet<InquiryMethod> InquiryMethods { get; set; }

        public DbSet<Application> Applications { get; set; }
    }
}