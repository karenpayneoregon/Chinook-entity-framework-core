﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ChinookLibrary.Data;
using ChinookLibrary.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChinookLibrary.Data.Configurations
{
    public partial class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(120);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Genre> entity);
    }
}