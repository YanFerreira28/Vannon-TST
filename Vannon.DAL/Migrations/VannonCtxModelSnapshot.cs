﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vannon.DataAccess.Context;

namespace Vannon.DAL.Migrations
{
    [DbContext(typeof(VannonCtx))]
    partial class VannonCtxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Vannon.Model.Entity.Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("idLocation")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<int?>("locationid")
                        .HasColumnType("int");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("locationid");

                    b.HasIndex("userid");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Vannon.Model.Entity.Location", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("dataDevolucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMovie")
                        .HasColumnType("int");

                    b.Property<int?>("movieid")
                        .HasColumnType("int");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("movieid");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Vannon.Model.Entity.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("categoria")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Vannon.Model.Entity.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Vannon.Model.Entity.Client", b =>
                {
                    b.HasOne("Vannon.Model.Entity.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationid");

                    b.HasOne("Vannon.Model.Entity.User", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("location");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Vannon.Model.Entity.Location", b =>
                {
                    b.HasOne("Vannon.Model.Entity.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movieid");

                    b.Navigation("movie");
                });
#pragma warning restore 612, 618
        }
    }
}
