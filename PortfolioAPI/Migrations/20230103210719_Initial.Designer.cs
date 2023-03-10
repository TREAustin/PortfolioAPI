// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortfolioAPI.Models;

#nullable disable

namespace PortfolioAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230103210719_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PortfolioAPI.Models.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Examples");
                });

            modelBuilder.Entity("PortfolioAPI.Models.Framework", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("ExampleId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExampleId");

                    b.HasIndex("Id");

                    b.ToTable("Frameworks");
                });

            modelBuilder.Entity("PortfolioAPI.Models.Image", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("ExampleId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExampleId");

                    b.HasIndex("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("PortfolioAPI.Models.Langauge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExampleId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExampleId");

                    b.HasIndex("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("PortfolioAPI.Models.OperatingSystem", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("ExampleId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExampleId");

                    b.HasIndex("Id");

                    b.ToTable("OperatingSystems");
                });

            modelBuilder.Entity("PortfolioAPI.Models.Framework", b =>
                {
                    b.HasOne("PortfolioAPI.Models.Example", "Example")
                        .WithMany()
                        .HasForeignKey("ExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Example");
                });

            modelBuilder.Entity("PortfolioAPI.Models.Image", b =>
                {
                    b.HasOne("PortfolioAPI.Models.Example", "Example")
                        .WithMany()
                        .HasForeignKey("ExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Example");
                });

            modelBuilder.Entity("PortfolioAPI.Models.Langauge", b =>
                {
                    b.HasOne("PortfolioAPI.Models.Example", "Example")
                        .WithMany()
                        .HasForeignKey("ExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Example");
                });

            modelBuilder.Entity("PortfolioAPI.Models.OperatingSystem", b =>
                {
                    b.HasOne("PortfolioAPI.Models.Example", "Example")
                        .WithMany()
                        .HasForeignKey("ExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Example");
                });
#pragma warning restore 612, 618
        }
    }
}
