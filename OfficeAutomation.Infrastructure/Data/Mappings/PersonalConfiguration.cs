using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

using OfficeAutomation.Domain.ValueObjects;

namespace Infrastructure.Data.Mappings
{
    public class PersonalConfiguration : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.HasKey(p => p.IdPersonal);
            builder.Property(p => p.PersonalCode).IsRequired();
            builder.Property(p => p.Fname).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Lname).IsRequired().HasMaxLength(50);
            builder.Property(p => p.ParentName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.NationalCode).HasConversion(
                v => v.Value,
                v => new NationalCode(v)
            ).IsRequired().HasMaxLength(20);
            builder.Property(p => p.CertificateId).HasConversion(
                v => v.Value,
                v => new CertificateId(v)
            ).HasMaxLength(20);
            builder.Property(p => p.BirthDate).HasMaxLength(10);
            builder.HasOne(p => p.City).WithMany().HasForeignKey(p => p.IdCity);
            builder.Property(p => p.AdressOfResidence).HasMaxLength(150);
            builder.Property(p => p.PostCode).HasMaxLength(20);
            builder.Property(p => p.MobileNumber).IsRequired().HasMaxLength(20);
            builder.Property(p => p.PhoneEmergency).HasMaxLength(20);
            builder.Property(p => p.PhoneInternal).HasMaxLength(20);
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
            builder.Property(p => p.InsuranceNumber).HasMaxLength(20);
            builder.Property(p => p.AccountNumber).HasMaxLength(20);
            builder.Property(p => p.SoldierStatusReason).HasMaxLength(100);
            builder.Property(p => p.StartDateWork).HasMaxLength(20);
            builder.Property(p => p.IdSizeType).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.BreechesSize).HasMaxLength(10);
            builder.Property(p => p.ShoeSize).HasMaxLength(10);
            builder.Property(p => p.IdBloodType).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.IdTypeHome).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.IdSex).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.IdReligion).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.IdCitizenShip).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.IdSoldierStatus).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.FileName).HasMaxLength(20);
            builder.Property(p => p.FileName1).HasMaxLength(20);
            builder.Property(p => p.SignatureFile).HasMaxLength(50);
            builder.Property(p => p.RelatedSkills).HasMaxLength(500);
            builder.Property(p => p.RelatedNotSkills).HasMaxLength(500);
            builder.Property(p => p.ReferenceFullName1).HasMaxLength(50);
            builder.Property(p => p.ReferenceAdress1).HasMaxLength(150);
            builder.Property(p => p.ReferenceMobile1).HasMaxLength(15);
            builder.Property(p => p.ReferenceRelative1).HasMaxLength(50);
            builder.Property(p => p.ReferenceFullName2).HasMaxLength(50);
            builder.Property(p => p.ReferenceAdress2).HasMaxLength(150);
            builder.Property(p => p.ReferenceMobile2).HasMaxLength(15);
            builder.Property(p => p.ReferenceRelative2).HasMaxLength(50);
            builder.Property(p => p.CertificateId1).HasMaxLength(20);
            builder.Property(p => p.CertificateDate).HasMaxLength(10);
            builder.Property(p => p.RegisterDateM);
            builder.Property(p => p.RegisterDate).HasMaxLength(20);
            builder.Property(p => p.RegisterTime).HasMaxLength(10);
            builder.Property(p => p.ClientIp).HasMaxLength(20);
        }
    }
}