using CodeBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeBase.DbContextModelling
{
    public class CreateAccountConfiguration: IEntityTypeConfiguration<CreateAccount>
    {
        public void Configure(EntityTypeBuilder<CreateAccount> builder)
        {
            builder.HasKey(c => c.NicNumber);

            builder.Property(c => c.Email).HasConversion<string>()
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.MobileNumber)
                .IsRequired()
                .HasMaxLength(16);

            builder.HasOne(c => c.PinCode)
                .WithOne(c => c.CreateAccount)
                .HasForeignKey<CreateAccount>(e => e.NicNumber)
                .HasPrincipalKey<PinCode>(e=>e.Id);
        }
    }
}
