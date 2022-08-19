﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Security.Infrastructure.DataModel.Context;
using System;
using Security.Domain.Entities;

namespace Security.Infrastructure.DataModel.Context.Configurations
{
    public partial class MasterDetConfiguration : IEntityTypeConfiguration<MasterDet>
    {
        public void Configure(EntityTypeBuilder<MasterDet> entity)
        {
            entity.ToTable("MasterDet");

            entity.Property(e => e.DateCrea).HasColumnType("datetime");

            entity.Property(e => e.DateUpd).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Value2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Master)
                .WithMany(p => p.MasterDets)
                .HasForeignKey(d => d.IdMaster)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MasterDet_Master");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MasterDet> entity);
    }
}