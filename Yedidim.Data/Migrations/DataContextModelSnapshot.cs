﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yedidim.Data;

#nullable disable

namespace Yedidim.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Yedidim.Core.Entities.CallFromPeople", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypesOfCallID")
                        .HasColumnType("int");

                    b.Property<int>("VolunteerID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypesOfCallID");

                    b.HasIndex("VolunteerID");

                    b.ToTable("CallsFromPeople", (string)null);
                });

            modelBuilder.Entity("Yedidim.TypesOfCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discribition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypesOfCall", (string)null);
                });

            modelBuilder.Entity("Yedidim.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pwd")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Volunteers", (string)null);
                });

            modelBuilder.Entity("Yedidim.Core.Entities.CallFromPeople", b =>
                {
                    b.HasOne("Yedidim.TypesOfCall", "TypesOfCall")
                        .WithMany("callFromPeople")
                        .HasForeignKey("TypesOfCallID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Yedidim.Volunteer", "Volunteer")
                        .WithMany("callFromPeople")
                        .HasForeignKey("VolunteerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypesOfCall");

                    b.Navigation("Volunteer");
                });

            modelBuilder.Entity("Yedidim.TypesOfCall", b =>
                {
                    b.Navigation("callFromPeople");
                });

            modelBuilder.Entity("Yedidim.Volunteer", b =>
                {
                    b.Navigation("callFromPeople");
                });
#pragma warning restore 612, 618
        }
    }
}