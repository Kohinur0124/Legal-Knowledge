﻿// <auto-generated />
using LegalKnowledge.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LegalKnowledge.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Chapters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int")
                        .HasColumnName("DepartmentId");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("Chapters", "dbo");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentNumber")
                        .HasColumnType("int")
                        .HasColumnName("DepartmentNumber");

                    b.Property<int>("DocumentsId")
                        .HasColumnType("int")
                        .HasColumnName("DocumentsId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("DocumentsId");

                    b.ToTable("Departments", "dbo");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Documents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.Property<int>("YearOfPublication")
                        .HasColumnType("int")
                        .HasColumnName("YearOfPublication");

                    b.HasKey("Id");

                    b.ToTable("Documents", "dbo");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Substances", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChaptersId")
                        .HasColumnType("int")
                        .HasColumnName("ChaptersId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.Property<int>("Part")
                        .HasColumnType("int")
                        .HasColumnName("Part");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("ChaptersId");

                    b.ToTable("Substances", "dbo");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.TestQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Events")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Events");

                    b.Property<string>("Punishment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Punishment");

                    b.Property<int>("SubstancesId")
                        .HasColumnType("int")
                        .HasColumnName("SubstancesId");

                    b.HasKey("Id");

                    b.HasIndex("SubstancesId");

                    b.ToTable("TestQuestions", "dbo");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("Amount");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<int>("Languagaes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.ToTable("User", "dbo");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Chapters", b =>
                {
                    b.HasOne("LegalKnowledge.Domain.Entities.Departments", "Departments")
                        .WithMany("Chapters")
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Departments", b =>
                {
                    b.HasOne("LegalKnowledge.Domain.Entities.Documents", "Documents")
                        .WithMany("Departments")
                        .HasForeignKey("DocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Substances", b =>
                {
                    b.HasOne("LegalKnowledge.Domain.Entities.Chapters", "Chapters")
                        .WithMany("Substances")
                        .HasForeignKey("ChaptersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapters");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.TestQuestions", b =>
                {
                    b.HasOne("LegalKnowledge.Domain.Entities.Substances", "Substances")
                        .WithMany("TestQuestions")
                        .HasForeignKey("SubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Substances");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Chapters", b =>
                {
                    b.Navigation("Substances");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Departments", b =>
                {
                    b.Navigation("Chapters");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Documents", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("LegalKnowledge.Domain.Entities.Substances", b =>
                {
                    b.Navigation("TestQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
