using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IngatlanBackend.Models;

public partial class IngatlanContext : DbContext
{
    public IngatlanContext()
    {
    }

    public IngatlanContext(DbContextOptions<IngatlanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingatlanok> Ingatlanoks { get; set; }

    public virtual DbSet<Kategorium> Kategoria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ingatlan;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingatlanok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ingatlan__3213E83FDA6C70CD");

            entity.ToTable("ingatlanok");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ar).HasColumnName("ar");
            entity.Property(e => e.HirdetesDatuma)
                .HasDefaultValueSql("(CONVERT([date],getdate()))")
                .HasColumnType("date")
                .HasColumnName("hirdetesDatuma");
            entity.Property(e => e.Kategoria).HasColumnName("kategoria");
            entity.Property(e => e.KepUrl)
                .IsUnicode(false)
                .HasColumnName("kepUrl");
            entity.Property(e => e.Leiras)
                .IsUnicode(false)
                .HasColumnName("leiras");
            entity.Property(e => e.Tehermentes).HasColumnName("tehermentes");

            entity.HasOne(d => d.KategoriaNavigation).WithMany(p => p.Ingatlanoks)
                .HasForeignKey(d => d.Kategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ingatlano__kateg__4E88ABD4");
        });

        modelBuilder.Entity<Kategorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kategori__3213E83FB4E71177");

            entity.ToTable("kategoria");

            entity.HasIndex(e => e.Nev, "UQ__kategori__DF900F67930AB94D").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nev)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nev");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
