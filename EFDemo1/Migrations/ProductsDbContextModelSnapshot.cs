﻿// <auto-generated />
using EFDemo1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDemo1.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("PersonSequence");

            modelBuilder.Entity("EFDemo1.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EFDemo1.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [PersonSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("PersonId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("EFDemo1.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EFDemo1.Entities.Customer", b =>
                {
                    b.HasBaseType("EFDemo1.Entities.Person");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EFDemo1.Entities.Supplier", b =>
                {
                    b.HasBaseType("EFDemo1.Entities.Person");

                    b.Property<string>("GSTNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasIndex("ProductId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("EFDemo1.Entities.Product", b =>
                {
                    b.HasOne("EFDemo1.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFDemo1.Entities.Supplier", b =>
                {
                    b.HasOne("EFDemo1.Entities.Product", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EFDemo1.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EFDemo1.Entities.Product", b =>
                {
                    b.Navigation("Suppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
