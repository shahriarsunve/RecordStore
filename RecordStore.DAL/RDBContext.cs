using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Entity.Record;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecordStore.DAL
{
    public class RDBContext:DbContext
    {

        public RDBContext(DbContextOptions<RDBContext> options) : base(options)
        { 
        
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordData>()
                .HasKey(nameof(RecordData.category), nameof(RecordData.keyname));
        }

        public DbSet<RecordData> RecordDatas { get; set; }
    }
}
