﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Week7.ProjectVenerdi.RepoEF;

namespace Week7.ProjectVenerdi.RepoEF.Migrations
{
    [DbContext(typeof(RubricaContext))]
    partial class RubricaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Week7.ProjectVenerdi.Core.Entities.Address", b =>
                {
                    b.Property<int>("IdAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CAP")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdContact")
                        .HasColumnType("int");

                    b.Property<string>("Nation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAddress");

                    b.HasIndex("IdContact");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Week7.ProjectVenerdi.Core.Entities.Contact", b =>
                {
                    b.Property<int>("IdContact")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdContact");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Week7.ProjectVenerdi.Core.Entities.Address", b =>
                {
                    b.HasOne("Week7.ProjectVenerdi.Core.Entities.Contact", "Contact")
                        .WithMany("addresses")
                        .HasForeignKey("IdContact")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Week7.ProjectVenerdi.Core.Entities.Contact", b =>
                {
                    b.Navigation("addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
