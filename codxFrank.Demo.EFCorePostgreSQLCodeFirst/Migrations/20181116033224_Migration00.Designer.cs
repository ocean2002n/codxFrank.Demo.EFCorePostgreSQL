﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using codxFrank.Demo.EFCorePostgreSQLCodeFirst.Models;

namespace codxFrank.Demo.EFCorePostgreSQLCodeFirst.Migrations
{
    [DbContext(typeof(PHIS2Context))]
    [Migration("20181116033224_Migration00")]
    partial class Migration00
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("codxFrank.Demo.EFCorePostgreSQLCodeFirst.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerID");

                    b.Property<int>("Age");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}