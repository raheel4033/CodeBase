using CodeBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeBase.DbContextModelling
{
    public class PinCodeConfiguration:IEntityTypeConfiguration<PinCode>
    {
        public void Configure(EntityTypeBuilder<PinCode> builder) 
        {
            builder.HasKey(p => p.Id);

            builder.Property(p=>p.GetEmailCode).HasMaxLength(50).IsRequired();
            builder.Property(p => p.EnterPhoneCode).HasMaxLength(10);


        }
    }
}
