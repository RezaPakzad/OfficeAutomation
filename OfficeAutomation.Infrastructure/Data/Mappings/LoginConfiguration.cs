using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OfficeAutomation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeAutomation.Domain.ValueObjects;

namespace OfficeAutomation.Infrastructure.Data.Mappings
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(l => l.IdLogin);
            builder.Property(l => l.UserName).IsRequired().HasMaxLength(20);
            builder.Property(l => l.Password).IsRequired().HasMaxLength(50);
            builder.Property(l => l.Password2).HasMaxLength(50);
            //builder.Property(l => l.ConfirmPassword).HasConversion(
            //    v => v.Value,
            //    v => new PasswordConfirmation(v, "") // Note: Matching logic in domain
            //).IsRequired();
            builder.HasOne(l => l.Personal).WithMany().HasForeignKey(l => l.IdPersonal);
            builder.Ignore(l => l.OldPassword); // NotMapped
        }
    }
}
