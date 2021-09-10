using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week7.ProjectVenerdi.Core.Entities;

namespace Week7.ProjectVenerdi.RepoEF
{
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> modelBuilder)
        {
            modelBuilder.ToTable("Contacts");
            modelBuilder.HasKey(c => c.IdContact);

            modelBuilder.HasMany(a => a.addresses).WithOne(c => c.Contact).HasForeignKey(c => c.IdContact);
        }
    }
}