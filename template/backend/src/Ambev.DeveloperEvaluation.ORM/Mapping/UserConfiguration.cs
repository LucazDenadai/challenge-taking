﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
        builder.Property(u => u.Password).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Phone).HasMaxLength(20);

        builder.Property(u => u.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(u => u.Role)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.OwnsOne(u => u.Name, name =>
        {
            name.Property(n => n.FirstName).IsRequired().HasMaxLength(50);
            name.Property(n => n.LastName).IsRequired().HasMaxLength(50);
        });

        builder.OwnsOne(u => u.Address, address =>
        {
            address.Property(a => a.City).IsRequired().HasMaxLength(100);
            address.Property(a => a.Street).IsRequired().HasMaxLength(100);
            address.Property(a => a.Number).IsRequired();
            address.Property(a => a.Zipcode).IsRequired().HasMaxLength(20);

            address.OwnsOne(a => a.Geolocation, geo =>
            {
                geo.Property(g => g.Lat).IsRequired().HasMaxLength(20);
                geo.Property(g => g.Long).IsRequired().HasMaxLength(20);
            });
        });
    }
}
