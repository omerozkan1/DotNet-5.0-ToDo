﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmerOzkan.ToDo.Entities.Domains;

namespace OmerOzkan.ToDo.DataAccess.Concrete.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(I => I.Id);

            builder.Property(I => I.UserName).HasMaxLength(100).IsRequired();
            //builder.Property(I => I.Password).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(100);
            builder.Property(I => I.Name).HasMaxLength(100);
            builder.Property(I => I.SurName).HasMaxLength(100);

            //builder.HasMany(I => I.Duties).WithOne(I => I.AppUser).HasForeignKey(I => I.AppUserId);
            //builder.HasMany(I => I.Notifications).WithOne(I => I.AppUser).HasForeignKey(I => I.AppUserId);
        }
    }
}
