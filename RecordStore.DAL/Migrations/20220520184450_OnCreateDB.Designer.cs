﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordStore.DAL;

namespace RecordStore.DAL.Migrations
{
    [DbContext(typeof(RDBContext))]
    [Migration("20220520184450_OnCreateDB")]
    partial class OnCreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("RecordStore.DAL.Entity.Record.RecordData", b =>
                {
                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("keyname")
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("value")
                        .HasColumnType("TEXT");

                    b.HasKey("category", "keyname");

                    b.ToTable("RecordDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
