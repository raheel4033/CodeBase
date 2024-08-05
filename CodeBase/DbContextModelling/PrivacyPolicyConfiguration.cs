using CodeBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeBase.DbContextModelling
{
    public class PrivacyPolicyConfiguration:IEntityTypeConfiguration<PrivacyPolicy>
    {
        public void Configure(EntityTypeBuilder<PrivacyPolicy> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p=>p.AgreeToTermsAndConditions).IsRequired().HasDefaultValue
                (false);
        }
    }
}
