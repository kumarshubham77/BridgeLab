﻿// <auto-generated />
using System;
using FundooRepository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundooRepository.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20191114051030_profile")]
    partial class profile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Models.LabelModels.LabelModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Label");

                    b.HasKey("ID");

                    b.ToTable("label");
                });

            modelBuilder.Entity("Common.Models.NotesModels.NotesModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Images");

                    b.Property<bool>("IsArchive");

                    b.Property<bool>("IsPin");

                    b.Property<bool>("IsTrash");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Reminder");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("notes");
                });

            modelBuilder.Entity("Common.Models.UserModels.UserModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardType");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("ProfilePicture");

                    b.HasKey("Email");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
