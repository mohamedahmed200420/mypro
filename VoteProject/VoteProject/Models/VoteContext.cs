using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VoteProject.Models;

public partial class VoteContext : DbContext
{
    public VoteContext()
    {
    }

    public VoteContext(DbContextOptions<VoteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbJob> TbJobs { get; set; }

    public virtual DbSet<TbVote> TbVotes { get; set; }

    public virtual DbSet<TbVoteResult> TbVoteResults { get; set; }

    public virtual DbSet<TbVotesOption> TbVotesOptions { get; set; }

    public virtual DbSet<TbYearOfExperince> TbYearOfExperinces { get; set; }
    public virtual DbSet<VwList> VwList { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-87B2RUQ;Database=Vote;Trusted_Connection=true;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbJob>(entity =>
        {
            entity.HasKey(e => e.JobId);

            entity.ToTable("TbJob");

            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.JobName)
                .HasMaxLength(300)
                .HasColumnName("jobName");
        });

        modelBuilder.Entity<TbVote>(entity =>
        {
            entity.HasKey(e => e.VoteId);

            entity.ToTable("TbVote");

            entity.Property(e => e.VoteId).HasColumnName("voteId");
            entity.Property(e => e.VoteName)
                .HasMaxLength(50)
                .HasColumnName("voteName");
        });

        modelBuilder.Entity<TbVoteResult>(entity =>
        {
            entity.HasKey(e => e.IdOfDataBase);

            entity.ToTable("IdOfDataBase");

            entity.HasKey(e => e.VoteResultId);

            entity.ToTable("TbVoteResult");

            entity.Property(e => e.VoteResultId).HasColumnName("voteResultId");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .HasColumnName("notes");
            entity.Property(e => e.VotesOptionId).HasColumnName("votesOptionId");
            entity.Property(e => e.YearOfExperienceId).HasColumnName("yearOfExperienceId");

            entity.HasOne(d => d.Job).WithMany(p => p.TbVoteResults)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbVoteResult_TbJob");

            entity.HasOne(d => d.VotesOption).WithMany(p => p.TbVoteResults)
                .HasForeignKey(d => d.VotesOptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbVoteResult_TbVotesOption");

            entity.HasOne(d => d.YearOfExperience).WithMany(p => p.TbVoteResults)
                .HasForeignKey(d => d.YearOfExperienceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbVoteResult_TbYearOfExperince");
        });

        modelBuilder.Entity<TbVotesOption>(entity =>
        {
            entity.HasKey(e => e.VoteOptionId);

            entity.ToTable("TbVotesOption");

            entity.Property(e => e.VoteOptionId).HasColumnName("voteOptionId");
            entity.Property(e => e.Options)
                .HasMaxLength(100)
                .HasColumnName("options");
            entity.Property(e => e.VoteId).HasColumnName("voteId");

            entity.HasOne(d => d.Vote).WithMany(p => p.TbVotesOptions)
                .HasForeignKey(d => d.VoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbVotesOption_TbVote");
        });
        modelBuilder.Entity<VwList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VwList");

          

        });
        modelBuilder.Entity<TbYearOfExperince>(entity =>
        {
            entity.HasKey(e => e.YearOfExperinceId);

            entity.ToTable("TbYearOfExperince");

            entity.Property(e => e.YearOfExperinceId).HasColumnName("yearOfExperinceId");
            entity.Property(e => e.Year).HasColumnName("year");

        });
        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
