using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week7.ProjectVenerdi.Core.Entities;

namespace Week7.ProjectVenerdi.RepoEF
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> modelBuilder)
        {
            modelBuilder.ToTable("Address");
            modelBuilder.HasKey(a => a.IdAddress);

            modelBuilder.HasOne(c=>c.Contact).WithMany(c=>c.addresses).HasForeignKey(a => a.IdContact);
        }
    }
}