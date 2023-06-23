﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoteProject.Models;

#nullable disable

namespace VoteProject.Migrations
{
    [DbContext(typeof(VoteContext))]
    [Migration("20230606145617_newColum")]
    partial class newColum
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VoteProject.Models.TbJob", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("jobId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("jobName");

                    b.HasKey("JobId");

                    b.ToTable("TbJob", (string)null);
                });

            modelBuilder.Entity("VoteProject.Models.TbVote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("voteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteId"));

                    b.Property<string>("VoteName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("voteName");

                    b.HasKey("VoteId");

                    b.ToTable("TbVote", (string)null);
                });

            modelBuilder.Entity("VoteProject.Models.TbVoteResult", b =>
                {
                    b.Property<int>("VoteResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("voteResultId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteResultId"));

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<int>("IdOfDataBase")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("jobId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("notes");

                    b.Property<int>("VotesOptionId")
                        .HasColumnType("int")
                        .HasColumnName("votesOptionId");

                    b.Property<int>("YearOfExperienceId")
                        .HasColumnType("int")
                        .HasColumnName("yearOfExperienceId");

                    b.HasKey("VoteResultId");

                    b.HasIndex("JobId");

                    b.HasIndex("VotesOptionId");

                    b.HasIndex("YearOfExperienceId");

                    b.ToTable("TbVoteResult", (string)null);
                });

            modelBuilder.Entity("VoteProject.Models.TbVotesOption", b =>
                {
                    b.Property<int>("VoteOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("voteOptionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteOptionId"));

                    b.Property<string>("Options")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("options");

                    b.Property<int>("VoteId")
                        .HasColumnType("int")
                        .HasColumnName("voteId");

                    b.HasKey("VoteOptionId");

                    b.HasIndex("VoteId");

                    b.ToTable("TbVotesOption", (string)null);
                });

            modelBuilder.Entity("VoteProject.Models.TbYearOfExperince", b =>
                {
                    b.Property<int>("YearOfExperinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("yearOfExperinceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YearOfExperinceId"));

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("YearOfExperinceId");

                    b.ToTable("TbYearOfExperince", (string)null);
                });

            modelBuilder.Entity("VoteProject.Models.VwList", b =>
                {
                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("options")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("voteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("VwList", (string)null);
                });

            modelBuilder.Entity("VoteProject.Models.TbVoteResult", b =>
                {
                    b.HasOne("VoteProject.Models.TbJob", "Job")
                        .WithMany("TbVoteResults")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK_TbVoteResult_TbJob");

                    b.HasOne("VoteProject.Models.TbVotesOption", "VotesOption")
                        .WithMany("TbVoteResults")
                        .HasForeignKey("VotesOptionId")
                        .IsRequired()
                        .HasConstraintName("FK_TbVoteResult_TbVotesOption");

                    b.HasOne("VoteProject.Models.TbYearOfExperince", "YearOfExperience")
                        .WithMany("TbVoteResults")
                        .HasForeignKey("YearOfExperienceId")
                        .IsRequired()
                        .HasConstraintName("FK_TbVoteResult_TbYearOfExperince");

                    b.Navigation("Job");

                    b.Navigation("VotesOption");

                    b.Navigation("YearOfExperience");
                });

            modelBuilder.Entity("VoteProject.Models.TbVotesOption", b =>
                {
                    b.HasOne("VoteProject.Models.TbVote", "Vote")
                        .WithMany("TbVotesOptions")
                        .HasForeignKey("VoteId")
                        .IsRequired()
                        .HasConstraintName("FK_TbVotesOption_TbVote");

                    b.Navigation("Vote");
                });

            modelBuilder.Entity("VoteProject.Models.TbJob", b =>
                {
                    b.Navigation("TbVoteResults");
                });

            modelBuilder.Entity("VoteProject.Models.TbVote", b =>
                {
                    b.Navigation("TbVotesOptions");
                });

            modelBuilder.Entity("VoteProject.Models.TbVotesOption", b =>
                {
                    b.Navigation("TbVoteResults");
                });

            modelBuilder.Entity("VoteProject.Models.TbYearOfExperince", b =>
                {
                    b.Navigation("TbVoteResults");
                });
#pragma warning restore 612, 618
        }
    }
}
